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
    public partial class LoginsEditForm : MetroForm
    {
        public SqlConnection conn = new SqlConnection();
        String Textbox1, Textbox2, Textbox3, Identity;
        public LoginsEditForm(string ID)
        {
            InitializeComponent();
            Textbox1 = ManageLoginsForm.Tbox1;
            Textbox2 = ManageLoginsForm.Tbox2;
            Textbox3 = ManageLoginsForm.Tbox3;

            Identity = ID;
            string Server = Properties.Settings.Default.Server;
            string Database = Properties.Settings.Default.Database;
            string User = Properties.Settings.Default.User;
            string Password = Properties.Settings.Default.Password;
            string conn_string = "Data Source=" + Server + ";Database=" + Database + ";user=" + User + ";Password=" + Password + ";" + "connection timeout=10;";
            conn.ConnectionString = conn_string;

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to Update?", "Confirm Update", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Logins set Loginuser=@Loginuser, Loginpass=@Loginpass, Privilages=@Privilages where Loginuser = @id", conn);
                cmd.Parameters.AddWithValue("@id", Identity);
                cmd.Parameters.AddWithValue("@Loginuser", UserTbox.Text);
                cmd.Parameters.AddWithValue("@Loginpass", PasswordTbox.Text);
                cmd.Parameters.AddWithValue("@Privilages", PrivComboBox.Text);
                //A
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();
                this.Close();
            }


        }

        private void LoginsEditForm_Load(object sender, EventArgs e)
        {
            UserTbox.Text = Textbox1;
            PasswordTbox.Text = Textbox2;

            //PrivComboBox.Text = Textbox3;
            string Priv = Textbox3.Trim();

            PrivComboBox.Items.Add("Edit");
            PrivComboBox.Items.Add("View");

            if (Priv == "Edit")
            {
                PrivComboBox.SelectedIndex = PrivComboBox.FindStringExact("Edit");
            }
            if (Priv == "View")
            {
                PrivComboBox.SelectedIndex = PrivComboBox.FindStringExact("View");
            }
        }
    }
}
