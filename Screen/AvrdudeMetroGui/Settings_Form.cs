using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Configuration;
using System.Reflection;
using System.Xml;

namespace Screen
{
    public partial class Settings_Form : MetroForm
    {
        Dictionary<string, string> Rest_dic = new Dictionary<string, string>();
        Dictionary<string, string> hide_dic = new Dictionary<string, string>();
        public SqlConnection conn = new SqlConnection();
        DataTable schemaTable; 

        public Settings_Form()
        {
            InitializeComponent();
            string Server = Properties.Settings.Default.Server;
            string Database = Properties.Settings.Default.Database;
            string User = Properties.Settings.Default.User;
            string Password = Properties.Settings.Default.Password;
            string conn_string = "Data Source=" + Server + ";Database=" + Database + ";user=" + User + ";Password=" + Password + ";" + "connection timeout=10;";
            conn.ConnectionString = conn_string;
            try
            {
                conn.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(new Form { TopMost = true }, "Error in connecting to the Database");
            }

            Refresh_form();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {

            conn.Dispose();
            conn.Close();
            this.Hide();
            // show other form
            Login_Screen form2 = new Login_Screen();
            form2.ShowDialog();
            // close application
            this.Close();
        }

        void Read_hide()
        {
            hide_dic.Clear();
            string query3 = " SELECT * FROM Hide_Unhide WHERE RKey=1";
            string query2 = " SELECT * FROM Hide_Unhide WHERE RKey=1 ";
            string[] col = new string[36];
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            SqlDataReader dr2 = cmd2.ExecuteReader(CommandBehavior.KeyInfo);
            dr2.Read();
            //Retrieve column schema into a DataTable.
            schemaTable = dr2.GetSchemaTable();
            int loop = 0;
            foreach (DataRow myField in schemaTable.Rows)
            {
                col[loop] = myField[0].ToString();
                loop++;
            }
            dr2.Dispose();
            dr2.Close();


            SqlDataReader dr3 = cmd3.ExecuteReader();
            dr3.Read();
            int index;
            for (index = 0; index < 12; index++)
            {
                hide_dic.Add(col[index], dr3[index].ToString());
            }
            dr3.Dispose();
            dr3.Close();

        }

        private void Refresh_form()
        {
            string query = " SELECT * FROM Hide_Unhide WHERE RKey=1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
          
            if (dr[1].ToString() == "1")
            { GoldShift.Text = "Gold Shift ON"; GoldShift.BackColor = Color.Green; GoldShiftGb.Show(); }
            else
            { GoldShift.Text = "Gold Shift OFF"; GoldShift.BackColor = Color.Red; GoldShiftGb.Hide(); }

            if (dr[2].ToString() == "1")
            { GoldSpreadShift.Text = "Gold Spread Shift ON"; GoldSpreadShift.BackColor = Color.Green; S_XAU_Label.Show(); }
            else
            { GoldSpreadShift.Text = "Gold Spread Shift OFF"; GoldSpreadShift.BackColor = Color.Red; S_XAU_Label.Hide(); }

            if (dr[3].ToString() == "1")
            { MasterGoldXAU.Text = "Master Gold XAU ON"; MasterGoldXAU.BackColor = Color.Green; MG_XAU_Gbox.Show(); }
            else
            { MasterGoldXAU.Text = "Master Gold XAU OFF"; MasterGoldXAU.BackColor = Color.Red; MG_XAU_Gbox.Hide(); }

            if (dr[4].ToString() == "1")
            { MasterSilverXAG.Text = "Master Silver XAG ON"; MasterSilverXAG.BackColor = Color.Green; MasterSliverXAG.Show(); }
            else
            { MasterSilverXAG.Text = "Master Silver XAG OFF"; MasterSilverXAG.BackColor = Color.Red; MasterSliverXAG.Hide(); }

            if (dr[5].ToString() == "1")
            { SilverShift.Text = "Silver Shift ON"; SilverShift.BackColor = Color.Green; SilverShiftGb.Show(); }
            else
            { SilverShift.Text = "Silver Shift OFF"; SilverShift.BackColor = Color.Red; SilverShiftGb.Hide(); }

            if (dr[6].ToString() == "1")
            { SilverSpreadShift.Text = "Silver Spread Shift ON"; SilverSpreadShift.BackColor = Color.Green; S_XAG_Label.Show(); }
            else
            { SilverSpreadShift.Text = "Silver Spread Shift OFF"; SilverSpreadShift.BackColor = Color.Red; S_XAG_Label.Hide(); }

            if (dr[7].ToString() == "1")
            { T10.Text = "10 Tola Chain ON"; T10.BackColor = Color.Green; T10_Gbox.Show(); }
            else
            { T10.Text = "10 Tola Chain OFF"; T10.BackColor = Color.Red; T10_Gbox.Hide(); }

            if (dr[8].ToString() == "1")
            { T5.Text = "5 Tola Chain ON"; T5.BackColor = Color.Green; T5_Gbox.Show(); }
            else
            { T5.Text = "5 Tola Chain OFF"; T5.BackColor = Color.Red; T5_Gbox.Hide(); }

            if (dr[9].ToString() == "1")
            { KGBar.Text = "KG Bar ON"; KGBar.BackColor = Color.Green; KGB_995_Label.Show(); }
            else
            { KGBar.Text = "KG Bar OFF"; KGBar.BackColor = Color.Red; KGB_995_Label.Hide(); }

            if (dr[10].ToString() == "1")
            { TTBar.Text = "TT Bar ON"; TTBar.BackColor = Color.Green; TTB_Label.Show(); }
            else
            { TTBar.Text = "TT Bar OFF"; TTBar.BackColor = Color.Red; TTB_Label.Hide(); }

            if (dr[11].ToString() == "1")
            { AED.Text = "AED Per Gram ON"; AED.BackColor = Color.Green; AED_PG_Label.Show(); }
            else
            { AED.Text = "AED Per Gram OFF"; AED.BackColor = Color.Red; AED_PG_Label.Hide(); }

            dr.Dispose();
            dr.Close();




            //if (Properties.Settings.Default.GoldShift == true)
            //{ GoldShift.Text = "Gold Shift ON"; GoldShift.BackColor = Color.Green; GoldShiftGb.Show(); }
            //else
            //{ GoldShift.Text = "Gold Shift OFF"; GoldShift.BackColor = Color.Red; GoldShiftGb.Hide(); }

            //if (Properties.Settings.Default.GoldSpreadShift == true)
            //{ GoldSpreadShift.Text = "Gold Spread Shift ON"; GoldSpreadShift.BackColor = Color.Green;  S_XAU_Label.Show(); }
            //else
            //{ GoldSpreadShift.Text = "Gold Spread Shift OFF"; GoldSpreadShift.BackColor = Color.Red; S_XAU_Label.Hide(); }

            //if (Properties.Settings.Default.MasterGoldXAU == true)
            //{ MasterGoldXAU.Text = "Master Gold XAU ON"; MasterGoldXAU.BackColor = Color.Green; MG_XAU_Gbox.Show(); }
            //else
            //{ MasterGoldXAU.Text = "Master Gold XAU OFF"; MasterGoldXAU.BackColor = Color.Red; MG_XAU_Gbox.Hide(); }

            //if (Properties.Settings.Default.MasterSilverXAG == true)
            //{ MasterSilverXAG.Text = "Master Silver XAG ON"; MasterSilverXAG.BackColor = Color.Green; MasterSliverXAG.Show(); }
            //else
            //{ MasterSilverXAG.Text = "Master Silver XAG OFF"; MasterSilverXAG.BackColor = Color.Red; MasterSliverXAG.Hide(); }

            //if (Properties.Settings.Default.SilverShift == true)
            //{ SilverShift.Text = "Silver Shift ON"; SilverShift.BackColor = Color.Green; SilverShiftGb.Show(); }
            //else
            //{ SilverShift.Text = "Silver Shift OFF"; SilverShift.BackColor = Color.Red; SilverShiftGb.Hide(); }

            //if (Properties.Settings.Default.SilverSpreadShift == true)
            //{ SilverSpreadShift.Text = "Silver Spread Shift ON"; SilverSpreadShift.BackColor = Color.Green; S_XAG_Label.Show(); }
            //else
            //{ SilverSpreadShift.Text = "Silver Spread Shift OFF"; SilverSpreadShift.BackColor = Color.Red; S_XAG_Label.Hide(); }

            //if (Properties.Settings.Default.T10 == true)
            //{ T10.Text = "10 Tola Chain ON"; T10.BackColor = Color.Green; T10_Gbox.Show(); }
            //else
            //{ T10.Text = "10 Tola Chain OFF"; T10.BackColor = Color.Red; T10_Gbox.Hide(); }

            //if (Properties.Settings.Default.T5 == true)
            //{ T5.Text = "5 Tola Chain ON"; T5.BackColor = Color.Green; T5_Gbox.Show(); }
            //else
            //{ T5.Text = "5 Tola Chain OFF"; T5.BackColor = Color.Red; T5_Gbox.Hide(); }

            //if (Properties.Settings.Default.KGbar == true)
            //{ KGBar.Text = "KG Bar ON"; KGBar.BackColor = Color.Green;  KGB_995_Label.Show(); }
            //else
            //{ KGBar.Text = "KG Bar OFF"; KGBar.BackColor = Color.Red;  KGB_995_Label.Hide(); }

            //if (Properties.Settings.Default.TTbar == true)
            //{ TTBar.Text = "TT Bar ON"; TTBar.BackColor = Color.Green; TTB_Label.Show(); }
            //else
            //{ TTBar.Text = "TT Bar OFF"; TTBar.BackColor = Color.Red;  TTB_Label.Hide(); }

            //if (Properties.Settings.Default.AED == true)
            //{ AED.Text = "AED Per Gram ON"; AED.BackColor = Color.Green;  AED_PG_Label.Show(); }
            //else
            //{ AED.Text = "AED Per Gram OFF"; AED.BackColor = Color.Red;  AED_PG_Label.Hide(); }


        }

        private void Common_Click(object sender, EventArgs e)
        {
            Read_hide();
            string Set_p = ((MetroFramework.Controls.MetroTile)sender).Name.ToString();
            string cmd_string;        
            if (hide_dic[Set_p].ToString() == "1")
            {

                cmd_string = "UPDATE Hide_Unhide SET " + Set_p + "=" + "0" + " WHERE RKey=1";

            }
            else
            {
                cmd_string = "UPDATE Hide_Unhide SET " + Set_p + "=" + "1" + " WHERE RKey=1";

            }
            using (SqlCommand cmd = new SqlCommand(cmd_string, conn))
            {
                cmd.ExecuteNonQuery();
            }

            Refresh_form();
    
        }



        private void Common_KeyPress(object sender, KeyPressEventArgs e)
        {
            string name = ((MetroFramework.Controls.MetroTextBox)sender).Name.ToString();
            
            if (Convert.ToInt32(e.KeyChar) == (int)Keys.Enter)
            {
                
                try
                {
                    if (((MetroFramework.Controls.MetroTextBox)sender).Text == null)
                    {
                        ((MetroFramework.Controls.MetroTextBox)sender).Text = "0.0";
                    }
                    else
                    {
                        decimal temp = Convert.ToDecimal(((MetroFramework.Controls.MetroTextBox)sender).Text);
                    }

                    string cmd_string = "UPDATE Restriction SET " + name + "=" + ((MetroFramework.Controls.MetroTextBox)sender).Text + " WHERE RKey=1";
                   
                    using (SqlCommand cmd = new SqlCommand(cmd_string,conn))
                    {
                          cmd.ExecuteNonQuery();
                    }
                                      

                }
                catch
                {
                    MessageBox.Show("Please Enter Numeric Value  key");
                }
            }
        }


        void Read_Restrictions()
        {
            Rest_dic.Clear();
            string query3 = " SELECT * FROM Restriction WHERE RKey=1";
            string query2 = " SELECT * FROM Restriction WHERE RKey=1 ";
            string[] col = new string[36];
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            SqlCommand cmd3 = new SqlCommand(query3, conn);
            SqlDataReader dr2 = cmd2.ExecuteReader(CommandBehavior.KeyInfo);
            dr2.Read();
            //Retrieve column schema into a DataTable.
            schemaTable = dr2.GetSchemaTable();
            int loop = 0;
            foreach (DataRow myField in schemaTable.Rows)
            {
                col[loop] = myField[0].ToString();
                loop++;
            }
            dr2.Dispose();
            dr2.Close();


            SqlDataReader dr3 = cmd3.ExecuteReader();
            dr3.Read();
            int index;
            for (index = 0; index < 35; index++)
            {

                Rest_dic.Add(col[index], dr3[index].ToString());
            }
            dr3.Dispose();
            dr3.Close();

        }

        private void ReadRestBtn_Click(object sender, EventArgs e)
        {
            Read_Restrictions();                      
            foreach (Control txtbox in this.Restrictions.Controls)
            {
                MetroFramework.Controls.MetroTextBox tb = txtbox as MetroFramework.Controls.MetroTextBox;
              
                if (null != tb)
                {
                    txtbox.Text = Rest_dic[tb.Name.ToString()].ToString();
                    //txtbox.Text = Properties.Settings.Default[tb.Name.ToString()].ToString();
                }

                        
         }
      }


        private void Common_Save(object sender, EventArgs e)
        {
            foreach (Control txtbox in this.Restrictions.Controls)
            {
                
                MetroFramework.Controls.MetroTextBox tb = txtbox as MetroFramework.Controls.MetroTextBox;
                if (txtbox.GetType().ToString() == "MetroFramework.Controls.MetroTextBox")
                {
                    try
                    {
                        if (txtbox.Text == "0" || string.IsNullOrEmpty(txtbox.Text))
                        {

                            string cmd_string = "UPDATE Restriction SET " + tb.Name.ToString() + "=" + "0" + " WHERE RKey=1";

                            using (SqlCommand cmd = new SqlCommand(cmd_string, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }

                        }
                        else
                        {
                            decimal temp = Convert.ToDecimal(txtbox.Text);
                            string cmd_string = "UPDATE Restriction SET " + tb.Name.ToString() + "=" + txtbox.Text + " WHERE RKey=1";

                            using (SqlCommand cmd = new SqlCommand(cmd_string, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }

                        }

                    }
                    catch
                    {
                        MessageBox.Show("Please Enter Numeric Value in " + txtbox.Name.ToString());
                    }

                }
            }
        }

        private void Settings_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            conn.Close();
        }


    }
}
