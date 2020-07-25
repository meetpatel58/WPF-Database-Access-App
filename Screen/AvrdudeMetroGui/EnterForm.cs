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
    public partial class EnterForm : MetroForm
    {
        public SqlConnection conn = new SqlConnection();
        public EnterForm()
        {
            InitializeComponent();
            string Server = Properties.Settings.Default.Server;
            string Database = Properties.Settings.Default.Database;
            string User = Properties.Settings.Default.User;
            string Password = Properties.Settings.Default.Password;
            string conn_string = "Data Source=" + Server + ";Database=" + Database + ";user=" + User + ";Password=" + Password + ";" + "connection timeout=10;";
            conn.ConnectionString = conn_string;
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog = MessageBox.Show("Are you sure you want to Enter Data?", "Confirm Entry", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (IDTbox.Text != "" && MetroPartNoTbox.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("insert into PartDetails(ID,MetroPartNo,VendorPartNo,Category,PartDescription,Application,UnitOfMeasure,MinOrderQuantity,UnitPrice,SalePrice,HSNCode,TaxCode,VendorName,OrderDescription,DataSheet) values(@ID,@MetroPartNo,@VendorPartNo,@Category,@PartDescription,@Application,@UnitOfMeasure,@MinOrderQuantity,@UnitPrice,@SalePrice,@HSNCode,@TaxCode,@VendorName,@OrderDescription,@DataSheet)", conn);
                    cmd.Parameters.AddWithValue("@ID", IDTbox.Text);
                    cmd.Parameters.AddWithValue("@MetroPartNo", MetroPartNoTbox.Text);
                    cmd.Parameters.AddWithValue("@VendorPartNo", VendorPartNoTbox.Text);
                    cmd.Parameters.AddWithValue("@Category", CategoryComboBox.Text);
                    cmd.Parameters.AddWithValue("@PartDescription", PartDescriptionTbox.Text);
                    cmd.Parameters.AddWithValue("@Application", ApplicationTbox.Text);
                    cmd.Parameters.AddWithValue("@UnitOfMeasure", UOMComboBox.Text);
                    cmd.Parameters.AddWithValue("@MinOrderQuantity", MinOrderQuantityTbox.Text);
                    cmd.Parameters.AddWithValue("@UnitPrice", UnitPriceTbox.Text);
                    cmd.Parameters.AddWithValue("@SalePrice", SalePriceTbox.Text);
                    cmd.Parameters.AddWithValue("@HSNCode", HSNCodeTbox.Text);
                    cmd.Parameters.AddWithValue("@TaxCode", TaxCodeComboBox.Text);
                    cmd.Parameters.AddWithValue("@VendorName", VendorNameComboBox.Text);
                    cmd.Parameters.AddWithValue("@OrderDescription", OrderDescriptionTbox.Text);
                    cmd.Parameters.AddWithValue("@DataSheet", DataSheetTbox.Text);
                    //A
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Entered Succesfully");

                    IDTbox.Text = String.Empty;
                    MetroPartNoTbox.Text = String.Empty;

                    conn.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter some Data");
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }

        protected void FillCombobox()
        {
            conn.Open();  //UOM
            SqlCommand sqlCmd1 = new SqlCommand("SELECT Unit_Of_Measurement FROM UOM", conn);

            SqlDataReader sqlReader1 = sqlCmd1.ExecuteReader();

            while (sqlReader1.Read())
            {
                UOMComboBox.Items.Add(sqlReader1[0].ToString());
            }

            conn.Close();

            conn.Open(); // Category
            SqlCommand sqlCmd2 = new SqlCommand("SELECT Category FROM Category", conn);

            SqlDataReader sqlReader2 = sqlCmd2.ExecuteReader();

            while (sqlReader2.Read())
            {
                CategoryComboBox.Items.Add(sqlReader2[0].ToString());
            }

            conn.Close();

            conn.Open();// VendorName
            SqlCommand sqlCmd3 = new SqlCommand("SELECT VendorName FROM Vendor", conn);

            SqlDataReader sqlReader3 = sqlCmd3.ExecuteReader();

            while (sqlReader3.Read())
            {
                VendorNameComboBox.Items.Add(sqlReader3[0].ToString());
            }

            conn.Close();

            conn.Open(); // TaxCode
            SqlCommand sqlCmd4 = new SqlCommand("SELECT TaxCodeName FROM TaxCode", conn);

            SqlDataReader sqlReader4 = sqlCmd4.ExecuteReader();

            while (sqlReader4.Read())
            {
                TaxCodeComboBox.Items.Add(sqlReader4[0].ToString());
            }

            conn.Close();
        }

    }
}
