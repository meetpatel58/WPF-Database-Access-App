using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Reflection;
using System.Linq;
using MetroFramework.Forms;
using MetroFramework;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace Screen
{
    public partial class CategoryForm : MetroForm
    {
        public SqlConnection conn = new SqlConnection();
        public CategoryForm()
        {
            InitializeComponent();
            string Server = Properties.Settings.Default.Server;
            string Database = Properties.Settings.Default.Database;
            string User = Properties.Settings.Default.User;
            string Password = Properties.Settings.Default.Password;
            string conn_string = "Data Source=" + Server + ";Database=" + Database + ";user=" + User + ";Password=" + Password + ";" + "connection timeout=10;";
            conn.ConnectionString = conn_string;
            if (Login_Screen.Pflag == 1)
            {
                SaveBtn.Visible = false;
            }
        }

        SqlDataAdapter adapt;
        DataTable dt;
        SqlCommandBuilder scb;

        private void CatagoryForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            adapt = new SqlDataAdapter("select * from Category", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            CatagoryGridView.DataSource = dt;
            conn.Close();


        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            if (Login_Screen.Pflag == 1)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to Logout", "Exit?", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    Login_Screen.Pflag = 0;
                    this.Hide();
                    Login_Screen form2 = new Login_Screen();
                    form2.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                DialogResult dialog2 = MessageBox.Show("Are you sure you want to Save Changes and Logout", "Save and Exit?", MessageBoxButtons.YesNoCancel);
                if (dialog2 == DialogResult.Yes)
                {
                    Login_Screen.Pflag = 0;

                    scb = new SqlCommandBuilder(adapt);
                    adapt.Update(dt);

                    this.Hide();
                    Login_Screen form2 = new Login_Screen();
                    form2.ShowDialog();
                    this.Close();
                }
                if (dialog2 == DialogResult.No)
                {
                    Login_Screen.Pflag = 0;
                    this.Hide();
                    Login_Screen form2 = new Login_Screen();
                    form2.ShowDialog();
                    this.Close();
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(adapt);
            adapt.Update(dt);
            MessageBox.Show("Table Updated Successfully!");
        }


    }
}
