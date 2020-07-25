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
    public partial class NewForm : MetroForm
    {
        public SqlConnection conn = new SqlConnection();

        private static Microsoft.Office.Interop.Excel.Workbook mWorkBook;
        private static Microsoft.Office.Interop.Excel.Sheets mWorkSheets;
        private static Microsoft.Office.Interop.Excel.Worksheet mWSheet1;
        private static Microsoft.Office.Interop.Excel.Application oXL;
        public static String Tbox1, Tbox2, Tbox3, Tbox4, Tbox5, Tbox6, Tbox7, Tbox8, Tbox9, Tbox10, Tbox11, Tbox12, Tbox13, Tbox14, Tbox15;         //A

        public NewForm()
        {
            
            InitializeComponent();
            string Server = Properties.Settings.Default.Server;
            string Database = Properties.Settings.Default.Database;
            string User = Properties.Settings.Default.User;
            string Password = Properties.Settings.Default.Password;
            string conn_string = "Data Source=" + Server + ";Database=" + Database + ";user=" + User + ";Password=" + Password + ";" + "connection timeout=10;";
            conn.ConnectionString = conn_string;

            if (Login_Screen.Pflag == 1)             //Disable editing if Not Enough Privilages
            {
                EnterBtn.Enabled = false;
                UpdateBtn.Text = "View";
                Deletebtn.Enabled = false;
            }
        }
        
        SqlDataAdapter adapt;
        DataTable dt;
        String ID;

        private void EnterBtn_Click(object sender, EventArgs e)
        {
                EnterForm enterform = new EnterForm();
                enterform.ShowDialog();
                RefreshData();
                SelectDefault();
        }
   
        private void RefreshData()
        {

            adapt = new SqlDataAdapter("select * from PartDetails", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void SelectDefault()
        {
            ID = dataGridView1.Rows[0].Cells[0].Value.ToString();
            Tbox1 = dataGridView1.Rows[0].Cells[0].Value.ToString();
            Tbox2 = dataGridView1.Rows[0].Cells[1].Value.ToString();
            Tbox3 = dataGridView1.Rows[0].Cells[2].Value.ToString();
            Tbox4 = dataGridView1.Rows[0].Cells[3].Value.ToString();
            Tbox5 = dataGridView1.Rows[0].Cells[4].Value.ToString();
            Tbox6 = dataGridView1.Rows[0].Cells[5].Value.ToString();
            Tbox7 = dataGridView1.Rows[0].Cells[6].Value.ToString();
            Tbox8 = dataGridView1.Rows[0].Cells[7].Value.ToString();
            Tbox9 = dataGridView1.Rows[0].Cells[8].Value.ToString();
            Tbox10 = dataGridView1.Rows[0].Cells[9].Value.ToString();
            Tbox11 = dataGridView1.Rows[0].Cells[10].Value.ToString();
            Tbox12 = dataGridView1.Rows[0].Cells[11].Value.ToString();
            Tbox13 = dataGridView1.Rows[0].Cells[12].Value.ToString();
            Tbox14 = dataGridView1.Rows[0].Cells[13].Value.ToString();
            Tbox15 = dataGridView1.Rows[0].Cells[14].Value.ToString();
            //A
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login_Screen.Pflag = 0;
            this.Hide();
            Login_Screen form2 = new Login_Screen();
            form2.ShowDialog();
            this.Close();
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
        
            FillCombobox();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            conn.Open();
            adapt = new SqlDataAdapter("select * from PartDetails", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

            SelectDefault();
        }
        
        private void SearchTbox_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            if (ComboBox1.Text == "ID")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where ID like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "MetroPartNo")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where MetroPartNo like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "VendorPartNo")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where VendorPartNo like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "Category")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where Category like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "PartDescription")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where PartDescription like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "Application")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where Application like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "UnitOfMeasure")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where UnitOfMeasure like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "MinOrderQuantity")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where MinOrderQuantity like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "UnitPrice")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where UnitPrice like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "SalePrice")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where SalePrice like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "HSNCode")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where HSNCode like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "TaxCode")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where TaxCode like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "VendorName")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where VendorName like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "OrderDescription")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where OrderDescription like '" + SearchTbox.Text + "%'", conn);
            }
            if (ComboBox1.Text == "DataSheet")
            {
                adapt = new SqlDataAdapter("select * from PartDetails where DataSheet like '" + SearchTbox.Text + "%'", conn);
            }
            //A


            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        protected void FillCombobox()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from PartDetails", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            var columns = ds.Tables[0].Columns
              .OfType<DataColumn>()
              .Select(c => c.ColumnName);

            //ComboBox1.Items.AddRange(columns.ToArray());
            for (int i = 0; i < columns.ToArray().Length; i++)
            {
                ComboBox1.Items.Add(columns.ToArray().GetValue(i).ToString());
            }
            conn.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tbox1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tbox2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Tbox3 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Tbox4 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Tbox5 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Tbox6 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Tbox7 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Tbox8 = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            Tbox9 = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            Tbox10 = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            Tbox11 = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            Tbox12 = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            Tbox13 = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            Tbox14 = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            Tbox15 = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            //A
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tbox1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tbox2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Tbox3 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Tbox4 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Tbox5 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Tbox6 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            Tbox7 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Tbox8 = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            Tbox9 = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            Tbox10 = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            Tbox11 = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            Tbox12 = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            Tbox13 = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            Tbox14 = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            Tbox15 = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            //A
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
             EditForm editform = new EditForm(ID);
             editform.ShowDialog();
             RefreshData();
             SelectDefault();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             EditForm editform = new EditForm(ID);
             editform.ShowDialog();
             RefreshData();
             SelectDefault();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to Delete?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (ID != null)
                {
                    SqlCommand cmd = new SqlCommand("delete PartDetails where ID=@id", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Deleted Successfully!");
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
