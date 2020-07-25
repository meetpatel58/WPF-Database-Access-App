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

namespace Screen
{
    public partial class Screen_Form : MetroForm
    {
        Dictionary<string, string> Restrictions = new Dictionary<string, string>();
        public SqlConnection conn = new SqlConnection();
        DataTable schemaTable; 
        public void Read_database()
        {

            string query = " SELECT * FROM Data WHERE RKey=1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            MB_XAU.Text = dr[1].ToString();
            MA_XAU.Text = dr[2].ToString();
            MB_XAG.Text = dr[3].ToString();
            MA_XAG.Text = dr[4].ToString();
            S_XAU.Text = dr[5].ToString();
            S_XAG.Text = dr[6].ToString();
            XAU_BID.Text = dr[7].ToString();
            XAU_ASK.Text = dr[8].ToString();
            XAG_BID.Text = dr[9].ToString();
            XAG_ASK.Text = dr[10].ToString();
            KGB_995.Text = dr[11].ToString();
            TTB.Text = dr[12].ToString();
            T5_995.Text = dr[13].ToString();
            T5_999.Text = dr[14].ToString();
            T10_995.Text = dr[15].ToString();
            T10_999.Text = dr[16].ToString();
            AED_PG.Text = dr[17].ToString();
            dr.Dispose();
            dr.Close();

                   
        }

        void Read_Restrictions()
        {

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

                Restrictions.Add(col[index], dr3[index].ToString());
            }
            dr3.Dispose();
            dr3.Close();

            string query1 = " SELECT * FROM Hide_Unhide WHERE RKey=1";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            dr1.Read();

            if (dr1[1].ToString() == "1")
            { GoldShiftGb.Show(); }
            else
            { GoldShiftGb.Hide(); }

            if (dr1[2].ToString() == "1")
            { S_XAU_Label.Show(); S_XAU.Show(); S_XAU_Sign.Show(); }
            else
            { S_XAU_Label.Hide(); S_XAU.Hide(); S_XAU_Sign.Hide(); }

            if (dr1[3].ToString() == "1")
            { MG_XAU_Gbox.Show(); }
            else
            { MG_XAU_Gbox.Hide(); }

            if (dr1[4].ToString() == "1")
            { MasterSliverXAG.Show(); }
            else
            { MasterSliverXAG.Hide(); }

            if (dr1[5].ToString() == "1")
            { SilverShift.Show(); }
            else
            { SilverShift.Hide(); }

            if (dr1[6].ToString() == "1")
            { S_XAG_Label.Show(); S_XAG.Show(); }
            else
            { S_XAG_Label.Hide(); S_XAG.Hide(); }

            if (dr1[7].ToString() == "1")
            { T10_Gbox.Show(); }
            else
            { T10_Gbox.Hide(); }

            if (dr1[8].ToString() == "1")
            { T5_Gbox.Show(); }
            else
            { T5_Gbox.Hide(); }

            if (dr1[9].ToString() == "1")
            { KGB_995_Label.Show(); KGB_995.Show(); KGB_995_Sign.Show(); }
            else
            { KGB_995_Label.Hide(); KGB_995.Hide(); KGB_995_Sign.Hide(); }

            if (dr1[10].ToString() == "1")
            { TTB_Label.Show(); TTB.Show(); TTB_Sign.Show();}
            else
            { TTB_Label.Hide(); TTB.Hide(); TTB_Sign.Hide(); }

            if (dr1[11].ToString() == "1")
            { AED_PG_Label.Show(); AED_PG.Show(); }
            else
            { AED_PG_Label.Hide(); AED_PG.Hide(); }

            dr1.Dispose();
            dr1.Close();

        }
       
        public Screen_Form()
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
                SQLstatus.Text = "DB Connected";
                SQLstatus.BackColor = Color.Green;
            }
            catch (Exception err)
            {
                MessageBox.Show(new Form { TopMost = true }, "Error in connecting to the Database");
                SQLstatus.Text = "DB Not Connected";
                SQLstatus.BackColor = Color.Red;
            }

            Read_database();
            Read_Restrictions();
            
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Stop();
            conn.Dispose();
            conn.Close();
            this.Hide();
            // show other form
            Login_Screen form2 = new Login_Screen();
            form2.ShowDialog();
            // close application
            this.Close();
        }

        private void Common_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Update Data SET MA_XAU=2.00 WHERE RKey=1
           string name = ((MetroFramework.Controls.MetroTextBox)sender).Name.ToString();
           string cmd_string = "UPDATE Data SET " + name + "=@New_" + name + " WHERE RKey=1";
           if (Convert.ToInt32(e.KeyChar) == (int)Keys.Enter)
            {
                
                string Set_Fr = ((MetroFramework.Controls.MetroTextBox)sender).Name.ToString() + "_Fr";
                string Set_To = ((MetroFramework.Controls.MetroTextBox)sender).Name.ToString() + "_To";
                Decimal Fr = Convert.ToDecimal(Restrictions[Set_Fr]);
                Decimal To = Convert.ToDecimal(Restrictions[Set_To]);
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                int len_fr = Restrictions[Set_Fr].ToString().Length;
                int len_to = Restrictions[Set_To].ToString().Length;
                string point_fr = Restrictions[Set_Fr].ToString();
                string point_to = Restrictions[Set_To].ToString();
  
                if (len_fr >= len_to)
                {
                  
                    for (int i = 0; i < len_fr; i++)
                    {
                        if (point_fr[i] == '.') { sb.Append('.'); }
                        else if (point_fr[i] == '-' || point_fr[i] == '+') {  }
                        else { sb.Append('0'); }

                    }
                }
                else
                {
 
                    for (int i = 0; i < len_to; i++)
                    {
                        if (point_to[i] == '.') { sb.Append('.'); }
                        else if (point_to[i] == '-' || point_to[i] == '+') {  }
                        else { sb.Append('0'); }

                    }


                }

                try
                {
                    Decimal temp = Convert.ToDecimal(((MetroFramework.Controls.MetroTextBox)sender).Text);
                    if (temp <= To && temp >= Fr && temp.ToString().Length <= (sb.ToString().Length)+1)
                    {
                        
                        string display_temp = temp.ToString(sb.ToString());
                        System.Text.StringBuilder display = new System.Text.StringBuilder();
                        int st_start = 0;
                        if (temp != 0)
                        {
                            for (int i = 0; i < display_temp.Length; i++)
                            {
                                if (display_temp[i] == '-') { display.Append('-'); }
                                else if (display_temp[i] == '0' && st_start == 0) { }
                                else if (display_temp[i] == '.') { display.Append('.'); st_start = 1; }
                                else { display.Append(display_temp[i]); st_start = 1; }

                            }
                        }
                        else
                        {
                           display.Append("0");
                        }
                        ((MetroFramework.Controls.MetroTextBox)sender).Text = display.ToString();
                        using (SqlCommand cmd = new SqlCommand(cmd_string, conn))
                        {
                            cmd.Parameters.AddWithValue("@New_" + name, display.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        hiddenTb.Select();
                        Common_Leave(sender, EventArgs.Empty);
                    }
                    else
                    {
                        MessageBox.Show("Restricted Value" + Environment.NewLine + Environment.NewLine + "Allowed Value From " + Fr + " To " + To);
                        Common_Enter(sender, EventArgs.Empty);
                    }
                }
                catch (Exception h)
                {

                    MessageBox.Show("Restricted Value" + Environment.NewLine + Environment.NewLine + "Allowed Value From " + Fr + " To " + To);
                    Common_Enter(sender, EventArgs.Empty);
                }
 
               
            }
        }

       

        private void timerTbx_Enter(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hiddenTb.Select();  
            Read_database();
        }

        private void Common_Enter(object sender, EventArgs e)
        {
            ((MetroFramework.Controls.MetroTextBox)sender).SelectAll();
            SQLstatus.Text = "DB Update Mode";
            timer1.Stop();
            timer2.Start();
            
        }

        private void Common_Leave(object sender, EventArgs e)
        {       
            SQLstatus.Text = "DB Reading Mode";
            timer2.Stop();
            timer1.Start();
        }

        private void Screen_Form_FormClosing(object sender, FormClosingEventArgs e)
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

        private void CommonMouse_Enter(object sender, MouseEventArgs e)
        {
            ((MetroFramework.Controls.MetroTextBox)sender).SelectAll();
            SQLstatus.Text = "DB Update Mode";
            timer1.Stop();
            timer2.Start();
        }



    
      
    
    }
}
