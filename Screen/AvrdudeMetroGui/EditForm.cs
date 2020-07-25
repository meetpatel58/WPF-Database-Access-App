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
    public partial class EditForm : MetroForm
    {
        public SqlConnection conn = new SqlConnection();
        String Textbox1, Textbox2, Textbox3, Textbox4, Textbox5, Textbox6, Textbox7, Textbox8, Textbox9, Textbox10, Textbox11, Textbox12, Textbox13, Textbox14, Textbox15, Identity; //A
        public EditForm(string ID)
        {
            InitializeComponent();
            Textbox1 = NewForm.Tbox1;
            Textbox2 = NewForm.Tbox2;
            Textbox3 = NewForm.Tbox3;
            Textbox4 = NewForm.Tbox4;
            Textbox5 = NewForm.Tbox5;
            Textbox6 = NewForm.Tbox6;
            Textbox7 = NewForm.Tbox7;
            Textbox8 = NewForm.Tbox8;
            Textbox9 = NewForm.Tbox9;
            Textbox10 = NewForm.Tbox10;
            Textbox11 = NewForm.Tbox11;
            Textbox12 = NewForm.Tbox12;
            Textbox13 = NewForm.Tbox13;
            Textbox14 = NewForm.Tbox14;
            Textbox15 = NewForm.Tbox15;
            //A

            Identity = ID;
            string Server = Properties.Settings.Default.Server;
            string Database = Properties.Settings.Default.Database;
            string User = Properties.Settings.Default.User;
            string Password = Properties.Settings.Default.Password;
            string conn_string = "Data Source=" + Server + ";Database=" + Database + ";user=" + User + ";Password=" + Password + ";" + "connection timeout=10;";
            conn.ConnectionString = conn_string;
            if (Login_Screen.Pflag == 1)
            {
                UpdateBtn.Visible = false;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to Update?", "Confirm Update", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update PartDetails set ID=@ID1, MetroPartNo=@MetroPartNo, VendorPartNo=@VendorPartNo, Category=@Category, PartDescription=@PartDescription, Application=@Application, UnitOfMeasure=@UnitOfMeasure, MinOrderQuantity=@MinOrderQuantity, UnitPrice=@UnitPrice, SalePrice=@SalePrice, HSNCode=@HSNCode, TaxCode=@TaxCode, VendorName=@VendorName, OrderDescription=@OrderDescription, DataSheet=@DataSheet where ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", Identity);
                cmd.Parameters.AddWithValue("@ID1", IDTbox.Text);
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
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                conn.Close();
                this.Close();
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            IDTbox.Text = Textbox1;
            MetroPartNoTbox.Text = Textbox2;
            VendorPartNoTbox.Text = Textbox3;

            CategoryComboBox.Text = Textbox4;

            PartDescriptionTbox.Text = Textbox5;
            ApplicationTbox.Text = Textbox6;

            UOMComboBox.Text = Textbox7;

            MinOrderQuantityTbox.Text = Textbox8;
            UnitPriceTbox.Text = Textbox9;
            SalePriceTbox.Text = Textbox10;
            HSNCodeTbox.Text = Textbox11;

            TaxCodeComboBox.Text = Textbox12;

            VendorNameComboBox.Text = Textbox13;

            OrderDescriptionTbox.Text = Textbox14;
            DataSheetTbox.Text = Textbox15;
            //A

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

            //Search the combobox for the selected value
            int index1 = UOMComboBox.Items.IndexOf(Textbox7);
            UOMComboBox.SelectedIndex = index1;

            conn.Close();

            conn.Open(); // Category
            SqlCommand sqlCmd2 = new SqlCommand("SELECT Category FROM Category", conn);

            SqlDataReader sqlReader2 = sqlCmd2.ExecuteReader();

            while (sqlReader2.Read())
            {
                CategoryComboBox.Items.Add(sqlReader2[0].ToString());
            }

            //Search the combobox for the selected value
            int index2 = CategoryComboBox.Items.IndexOf(Textbox4);
            CategoryComboBox.SelectedIndex = index2;

            conn.Close();

            conn.Open();// VendorName
            SqlCommand sqlCmd3 = new SqlCommand("SELECT VendorName FROM Vendor", conn);

            SqlDataReader sqlReader3 = sqlCmd3.ExecuteReader();

            while (sqlReader3.Read())
            {
                VendorNameComboBox.Items.Add(sqlReader3[0].ToString());
            }

            //Search the combobox for the selected value
            int index3 = VendorNameComboBox.Items.IndexOf(Textbox13);
            VendorNameComboBox.SelectedIndex = index3;

            conn.Close();

            conn.Open(); // TaxCode
            SqlCommand sqlCmd4 = new SqlCommand("SELECT TaxCodeName FROM TaxCode", conn);

            SqlDataReader sqlReader4 = sqlCmd4.ExecuteReader();

            while (sqlReader4.Read())
            {
                TaxCodeComboBox.Items.Add(sqlReader4[0].ToString());
            }

            //Search the combobox for the selected value
            int index4 = TaxCodeComboBox.Items.IndexOf(Textbox12);
            TaxCodeComboBox.SelectedIndex = index4;

            conn.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
