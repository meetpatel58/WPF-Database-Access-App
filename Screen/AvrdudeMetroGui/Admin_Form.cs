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
    public partial class Admin_Form : MetroForm
    {
        public SqlConnection conn = new SqlConnection();
        public Admin_Form()
        {
            InitializeComponent();
            ServerTbox.Text = Properties.Settings.Default.Server;
            DatabaseTbox.Text = Properties.Settings.Default.Database;
            UserTbox.Text = Properties.Settings.Default.User;
            PasswordTbox.Text = Properties.Settings.Default.Password;
            SQLstatus.Text = "DB Disconnected Click to Retry";
            SQLstatus.BackColor = Color.Red;
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = ServerTbox.Text ;
            Properties.Settings.Default.Database = DatabaseTbox.Text;
            Properties.Settings.Default.User = UserTbox.Text;
            Properties.Settings.Default.Password = PasswordTbox.Text;
            Properties.Settings.Default.Save();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            // show other form
            Login_Screen form2 = new Login_Screen();
            form2.ShowDialog();
            // close application
            this.Close();
        }

        public void Splashstart()
        {
            Application.Run(new Splashscreen());
        }

        private void SQLStatus_Click(object sender, EventArgs e)
        {
            var thread = new Thread(Splashstart);
            thread.Start();
            Thread.Sleep(500);


            string Server = Properties.Settings.Default.Server;
            string Database = Properties.Settings.Default.Database;
            string User = Properties.Settings.Default.User;
            string Password = Properties.Settings.Default.Password;
            string conn_string = "Data Source=" + Server + ";Database=" + Database + ";user=" + User + ";Password=" + Password + ";" + "connection timeout=10;";
            if (conn.State.ToString() == "Closed")
            {
                try
                {
                    conn.ConnectionString = conn_string;
                    conn.Open();
                    SQLstatus.Text = "DB Connected";
                    SQLstatus.BackColor = Color.Green;
                }
                catch (Exception err)
                {
                    MessageBox.Show(new Form { TopMost = true }, "Error in connecting to the Database");
                    SQLstatus.Text = "DB Not Connected";
                    SQLstatus.BackColor = Color.Red;
                }
            }
            conn.Dispose();
            conn.Close();
            try
            {
                thread.Interrupt();
                thread.Abort();
            }
            catch (System.Threading.ThreadAbortException)
            {

            }

        }

        private void Admin_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                conn.Close();
                conn.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error in Closing Connection");
            }
        }

        private void LoginsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageLoginsForm form = new ManageLoginsForm();
            form.ShowDialog();
        }
    }
}
