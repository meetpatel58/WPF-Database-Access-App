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
    public partial class NewUserForm : MetroForm
    {
        public SqlConnection conn = new SqlConnection();
        public NewUserForm()
        {
            InitializeComponent();
            string Server = Properties.Settings.Default.Server;
            string Database = Properties.Settings.Default.Database;
            string User = Properties.Settings.Default.User;
            string Password = Properties.Settings.Default.Password;
            string conn_string = "Data Source=" + Server + ";Database=" + Database + ";user=" + User + ";Password=" + Password + ";" + "connection timeout=10;";
            conn.ConnectionString = conn_string;
           // FillCombobox();

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to Create New User?", "Confirm Entry", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (UserTbox.Text != "" && PasswordTbox.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("insert into Logins(Loginuser,Loginpass,Privilages) values(@Loginuser,@Loginpass,@Privilages)", conn);
                    cmd.Parameters.AddWithValue("@Loginuser", UserTbox.Text);
                    cmd.Parameters.AddWithValue("@Loginpass", PasswordTbox.Text);
                    cmd.Parameters.AddWithValue("@Privilages", PComboBox.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Created Succesfully");

                    conn.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter some Data");
                }
            }
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }

        protected void FillCombobox()
        {
            PComboBox.Items.Add("Edit");
            PComboBox.Items.Add("View");

            PComboBox.SelectedIndex = PComboBox.FindStringExact("View");
        }
    }
}
