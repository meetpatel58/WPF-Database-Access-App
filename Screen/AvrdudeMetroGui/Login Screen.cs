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
    public partial class Login_Screen : MetroForm
    {
        public SqlConnection conn = new SqlConnection();
        public static int Pflag = 0; //(0=Edit / 1=View)
        public static int SelectTable;  //(0=Parts / 1=Vendor)

        public void Splashstart()
        {
            Application.Run(new Splashscreen());
        }
              
        public Login_Screen()
        {
            var thread = new Thread(Splashstart);
            thread.Start();
            Thread.Sleep(500);
            InitializeComponent();
            string Server = Properties.Settings.Default.Server;
            string Database = Properties.Settings.Default.Database;
            string User = Properties.Settings.Default.User;
            string Password = Properties.Settings.Default.Password;
            string conn_string = "Data Source=" + Server + ";Database=" + Database + ";user=" + User + ";Password=" + Password + ";" +"connection timeout=10;";
            conn.ConnectionString = conn_string;
            if (TableComboBox.Text == "Parts")
            {
                SelectTable = 0;
            }
            if (TableComboBox.Text == "Vendor")
            {
                SelectTable = 1;
            }


            try
            {
                conn.Open();
                SQLstatus.Text = "DB Connected";
                SQLstatus.BackColor = Color.Green;
            }
            catch (Exception err)
            {
                MessageBox.Show(new Form { TopMost = true }, "Error in connecting to the Database");
                SQLstatus.Text = "DB Disonnected";
                SQLstatus.BackColor = Color.Red;
            }
            try
            {
                thread.Interrupt();
                thread.Abort();
            }
            catch (System.Threading.ThreadAbortException)
            {

            }
        }
       

         
        private void LoginBtn_Click(object sender, EventArgs e)    //As VIEW
        {
            string txtuser = UserTbox.Text;
            string txtpass = PasswordTbox.Text;

            if (txtpass == Properties.Settings.Default.AdminPass && txtuser == Properties.Settings.Default.AdminUser)
            {
                if (conn.State == ConnectionState.Open) 
                { conn.Dispose(); conn.Close(); }
                // hide main form
                this.Hide();
                // show other form
                Admin_Form form2 = new Admin_Form();
                form2.ShowDialog();
                // close application
                this.Close();

            }
           /* else if(conn.State.ToString() == "Closed")
            {
                MessageBox.Show("Database is disconnected" + Environment.NewLine + "Please enter Admin Username & Password");
                UserTbox.SelectAll();
            }*/
            else
            {

                SqlCommand Comm1 = new SqlCommand(" SELECT Privilages FROM Logins WHERE Loginuser=@username and Privilages='View'", conn);
                Comm1.Parameters.Add(new SqlParameter("@username", txtuser));
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }
                SqlDataReader DR1 = Comm1.ExecuteReader();
                if (DR1.Read())
                {
                    Pflag = Pflag + 1;
                }
                DR1.Close();
                
                string query = " SELECT * FROM Logins WHERE Loginuser=@username AND LoginPass=@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                
                cmd.Parameters.Add(new SqlParameter("@username", txtuser));
                cmd.Parameters.Add(new SqlParameter("@password", txtpass));


                SqlDataReader dbr;
                dbr = cmd.ExecuteReader();
                int count = 0;
                while (dbr.Read())
                {
                    count = count + 1;
                }
                Pflag = 1;
                if (count == 1)
                {
                    dbr.Close();
                    conn.Close();

                    Properties.Settings.Default.LoginFormUser = txtuser;
                    Properties.Settings.Default.LoginFormPass = txtpass;

                    // hide main form
                    this.Hide();
                    if (TableComboBox.Text == "Part Details")
                    {
                        NewForm form3 = new NewForm();
                        form3.ShowDialog();
                    }
                    if (TableComboBox.Text == "Vendor Details")
                    {
                        VendorForm form3 = new VendorForm();
                        form3.ShowDialog();
                    }
                    if (TableComboBox.Text == "Category")
                    {
                        CategoryForm form3 = new CategoryForm();
                        form3.ShowDialog();
                    }
                }
                else
                {
                    dbr.Close();
                    conn.Close();
                    Pflag = 0;
                    MessageBox.Show("Username/Password Incorrect OR Not Entered");
                }
            }
        }

        private void LoginEditBtn_Click(object sender, EventArgs e)      //As EDIT
        {
            string txtuser = UserTbox.Text;
            string txtpass = PasswordTbox.Text;
            if (txtpass == Properties.Settings.Default.AdminPass && txtuser == Properties.Settings.Default.AdminUser)
            {
                if (conn.State == ConnectionState.Open)
                { conn.Dispose(); conn.Close(); }
                // hide main form
                this.Hide();
                // show other form
                Admin_Form form2 = new Admin_Form();
                form2.ShowDialog();
                // close application
                this.Close();

            }
            /*else if (conn.State.ToString() == "Closed")
            {
                MessageBox.Show("Database is disconnected" + Environment.NewLine + "Please enter Admin Username & Password");
                UserTbox.SelectAll();
            }*/
            else
            {

                SqlCommand Comm1 = new SqlCommand(" SELECT Privilages FROM Logins WHERE Loginuser=@username and Privilages='view'", conn);
                Comm1.Parameters.Add(new SqlParameter("@username", txtuser));
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }
                SqlDataReader DR2 = Comm1.ExecuteReader();
                if (DR2.Read())
                {
                    Pflag = Pflag + 1;
                }
                DR2.Close();

                string query = " SELECT * FROM Logins WHERE Loginuser=@username AND LoginPass=@password";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add(new SqlParameter("@username", txtuser));
                cmd.Parameters.Add(new SqlParameter("@password", txtpass));

                SqlDataReader dbr;
                dbr = cmd.ExecuteReader();
                int count = 0;
                while (dbr.Read())
                {
                    count = count + 1;
                }
                if (count == 1 && Pflag == 0)
                {
                    dbr.Close();
                    conn.Close();

                    Properties.Settings.Default.LoginFormUser = txtuser;
                    Properties.Settings.Default.LoginFormPass = txtpass;

                    this.Hide();                       // hide main form and open table form
                    if (TableComboBox.Text == "Part Details")
                    {
                        NewForm form3 = new NewForm();
                        form3.ShowDialog();
                    }
                    if (TableComboBox.Text == "Vendor Details")
                    {
                        VendorForm form3 = new VendorForm();
                        form3.ShowDialog();
                    }
                    if (TableComboBox.Text == "Category")
                    {
                        CategoryForm form3 = new CategoryForm();
                        form3.ShowDialog();
                    }
                }
                else
                {
                    dbr.Close();
                    conn.Close();
                    if (count != 1)
                    {
                        MessageBox.Show("Username/Password Incorrect OR Not Entered");
                    }
                    if (Pflag == 1)
                    {
                        MessageBox.Show("Not Enough Privilages");
                    }
                }
            }
        }

        private void SQLstatus_Click(object sender, EventArgs e)
        {
           
            var thread = new Thread(Splashstart);
            thread.Start();
            Thread.Sleep(500);

            string Server = Properties.Settings.Default.Server;
            string Database = Properties.Settings.Default.Database;
            string User = Properties.Settings.Default.User;
            string Password = Properties.Settings.Default.Password;
            string conn_string = "Data Source=" + Server + ";Database=" + Database + ";user=" + User + ";Password=" + Password + ";" + "connection timeout=10;";
            

            if (conn.State.ToString()=="Closed")
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

            try
           {
                thread.Interrupt();
                thread.Abort();
           }
            catch (System.Threading.ThreadAbortException)
            {

           }
        }

        private void Login_Screen_Activated(object sender, EventArgs e)
        {
           UserTbox.SelectAll();
        }

        private void Login_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                conn.Close();
                conn.Dispose();
                Application.Exit();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error in Closing Connection");
            }
        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'purchaseDataSet.Logins' table. You can move, or remove it, as needed.
           // this.loginsTableAdapter.Fill(this.purchaseDataSet.Logins)
            TableComboBox.SelectedIndex = 0;

            UserTbox.Text = Properties.Settings.Default.LoginFormUser;
            PasswordTbox.Text = Properties.Settings.Default.LoginFormPass;

            Properties.Settings.Default.LoginFormUser = "";
            Properties.Settings.Default.LoginFormPass = "";

            UserTbox.Focus();
        }   
    }   
}        
  
