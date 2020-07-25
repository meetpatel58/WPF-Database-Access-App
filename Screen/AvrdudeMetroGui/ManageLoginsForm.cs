using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MetroFramework.Forms;
using MetroFramework;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Screen
{
    public partial class ManageLoginsForm : MetroForm
    {
        public SqlConnection conn = new SqlConnection();
        public static String Tbox1, Tbox2, Tbox3;
        public ManageLoginsForm()
        {
            InitializeComponent();
            string Server = Properties.Settings.Default.Server;
            string Database = Properties.Settings.Default.Database;
            string User = Properties.Settings.Default.User;
            string Password = Properties.Settings.Default.Password;
            string conn_string = "Data Source=" + Server + ";Database=" + Database + ";user=" + User + ";Password=" + Password + ";" + "connection timeout=10;";
            conn.ConnectionString = conn_string;
        }
        SqlDataAdapter adapt;
        DataTable dt;
        String ID;

        private void ManageLoginsForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            adapt = new SqlDataAdapter("select * from Logins", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            LoginsGridView.DataSource = dt;
            conn.Close();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Screen form2 = new Login_Screen();
            form2.ShowDialog();
            this.Close();
        }

        private void LoginsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = LoginsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tbox1 = LoginsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tbox2 = LoginsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            Tbox3 = LoginsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void LoginsGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = LoginsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tbox1 = LoginsGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tbox2 = LoginsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            Tbox3 = LoginsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void LoginsGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LoginsEditForm editform = new LoginsEditForm(ID);
            editform.ShowDialog();
            RefreshData();
            SelectDefault();
        }
        private void RefreshData()
        {

            adapt = new SqlDataAdapter("select * from Logins", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            LoginsGridView.DataSource = dt;

        }

        private void SelectDefault()
        {
            ID = LoginsGridView.Rows[0].Cells[0].Value.ToString();
            Tbox1 = LoginsGridView.Rows[0].Cells[0].Value.ToString();
            Tbox2 = LoginsGridView.Rows[0].Cells[1].Value.ToString();
            Tbox3 = LoginsGridView.Rows[0].Cells[2].Value.ToString();
            //A
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            NewUserForm creatform = new NewUserForm();
            creatform.ShowDialog();
            RefreshData();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to Delete?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (ID != null)
                {
                    SqlCommand cmd = new SqlCommand("delete Logins where Loginuser=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("User Deleted Successfully!");
                    RefreshData();
                    SelectDefault();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");
                }
            }
        }
    }
}
