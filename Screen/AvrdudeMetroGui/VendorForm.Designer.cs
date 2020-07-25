namespace Screen
{
    partial class VendorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VendorGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zIPPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webPageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yourReferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTermsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingTermsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorGSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankIFSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodOfPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorDataSet = new Screen.VendorDataSet();
            this.LogoutBtn = new MetroFramework.Controls.MetroButton();
            this.vendorTableAdapter = new Screen.VendorDataSetTableAdapters.VendorTableAdapter();
            this.SaveBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.VendorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VendorGridView
            // 
            this.VendorGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VendorGridView.AutoGenerateColumns = false;
            this.VendorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.vendorNameDataGridViewTextBoxColumn,
            this.contactPersonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateProvinceDataGridViewTextBoxColumn,
            this.zIPPostalCodeDataGridViewTextBoxColumn,
            this.countryRegionDataGridViewTextBoxColumn,
            this.webPageDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.orderCurrencyDataGridViewTextBoxColumn,
            this.yourReferenceDataGridViewTextBoxColumn,
            this.paymentTermsDataGridViewTextBoxColumn,
            this.shippingTermsDataGridViewTextBoxColumn,
            this.vendorGSTDataGridViewTextBoxColumn,
            this.attachmentsDataGridViewTextBoxColumn,
            this.bankNameDataGridViewTextBoxColumn,
            this.bankAccDataGridViewTextBoxColumn,
            this.bankIFSCDataGridViewTextBoxColumn,
            this.methodOfPaymentDataGridViewTextBoxColumn});
            this.VendorGridView.DataSource = this.vendorBindingSource;
            this.VendorGridView.Location = new System.Drawing.Point(23, 81);
            this.VendorGridView.Name = "VendorGridView";
            this.VendorGridView.Size = new System.Drawing.Size(551, 316);
            this.VendorGridView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            this.contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.HeaderText = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateProvinceDataGridViewTextBoxColumn
            // 
            this.stateProvinceDataGridViewTextBoxColumn.DataPropertyName = "State/Province";
            this.stateProvinceDataGridViewTextBoxColumn.HeaderText = "State/Province";
            this.stateProvinceDataGridViewTextBoxColumn.Name = "stateProvinceDataGridViewTextBoxColumn";
            // 
            // zIPPostalCodeDataGridViewTextBoxColumn
            // 
            this.zIPPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "ZIP/Postal Code";
            this.zIPPostalCodeDataGridViewTextBoxColumn.HeaderText = "ZIP/Postal Code";
            this.zIPPostalCodeDataGridViewTextBoxColumn.Name = "zIPPostalCodeDataGridViewTextBoxColumn";
            // 
            // countryRegionDataGridViewTextBoxColumn
            // 
            this.countryRegionDataGridViewTextBoxColumn.DataPropertyName = "Country/Region";
            this.countryRegionDataGridViewTextBoxColumn.HeaderText = "Country/Region";
            this.countryRegionDataGridViewTextBoxColumn.Name = "countryRegionDataGridViewTextBoxColumn";
            // 
            // webPageDataGridViewTextBoxColumn
            // 
            this.webPageDataGridViewTextBoxColumn.DataPropertyName = "Web Page";
            this.webPageDataGridViewTextBoxColumn.HeaderText = "Web Page";
            this.webPageDataGridViewTextBoxColumn.Name = "webPageDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // orderCurrencyDataGridViewTextBoxColumn
            // 
            this.orderCurrencyDataGridViewTextBoxColumn.DataPropertyName = "OrderCurrency";
            this.orderCurrencyDataGridViewTextBoxColumn.HeaderText = "OrderCurrency";
            this.orderCurrencyDataGridViewTextBoxColumn.Name = "orderCurrencyDataGridViewTextBoxColumn";
            // 
            // yourReferenceDataGridViewTextBoxColumn
            // 
            this.yourReferenceDataGridViewTextBoxColumn.DataPropertyName = "YourReference";
            this.yourReferenceDataGridViewTextBoxColumn.HeaderText = "YourReference";
            this.yourReferenceDataGridViewTextBoxColumn.Name = "yourReferenceDataGridViewTextBoxColumn";
            // 
            // paymentTermsDataGridViewTextBoxColumn
            // 
            this.paymentTermsDataGridViewTextBoxColumn.DataPropertyName = "PaymentTerms";
            this.paymentTermsDataGridViewTextBoxColumn.HeaderText = "PaymentTerms";
            this.paymentTermsDataGridViewTextBoxColumn.Name = "paymentTermsDataGridViewTextBoxColumn";
            // 
            // shippingTermsDataGridViewTextBoxColumn
            // 
            this.shippingTermsDataGridViewTextBoxColumn.DataPropertyName = "ShippingTerms";
            this.shippingTermsDataGridViewTextBoxColumn.HeaderText = "ShippingTerms";
            this.shippingTermsDataGridViewTextBoxColumn.Name = "shippingTermsDataGridViewTextBoxColumn";
            // 
            // vendorGSTDataGridViewTextBoxColumn
            // 
            this.vendorGSTDataGridViewTextBoxColumn.DataPropertyName = "VendorGST";
            this.vendorGSTDataGridViewTextBoxColumn.HeaderText = "VendorGST";
            this.vendorGSTDataGridViewTextBoxColumn.Name = "vendorGSTDataGridViewTextBoxColumn";
            // 
            // attachmentsDataGridViewTextBoxColumn
            // 
            this.attachmentsDataGridViewTextBoxColumn.DataPropertyName = "Attachments";
            this.attachmentsDataGridViewTextBoxColumn.HeaderText = "Attachments";
            this.attachmentsDataGridViewTextBoxColumn.Name = "attachmentsDataGridViewTextBoxColumn";
            // 
            // bankNameDataGridViewTextBoxColumn
            // 
            this.bankNameDataGridViewTextBoxColumn.DataPropertyName = "BankName";
            this.bankNameDataGridViewTextBoxColumn.HeaderText = "BankName";
            this.bankNameDataGridViewTextBoxColumn.Name = "bankNameDataGridViewTextBoxColumn";
            // 
            // bankAccDataGridViewTextBoxColumn
            // 
            this.bankAccDataGridViewTextBoxColumn.DataPropertyName = "BankAcc";
            this.bankAccDataGridViewTextBoxColumn.HeaderText = "BankAcc";
            this.bankAccDataGridViewTextBoxColumn.Name = "bankAccDataGridViewTextBoxColumn";
            // 
            // bankIFSCDataGridViewTextBoxColumn
            // 
            this.bankIFSCDataGridViewTextBoxColumn.DataPropertyName = "BankIFSC";
            this.bankIFSCDataGridViewTextBoxColumn.HeaderText = "BankIFSC";
            this.bankIFSCDataGridViewTextBoxColumn.Name = "bankIFSCDataGridViewTextBoxColumn";
            // 
            // methodOfPaymentDataGridViewTextBoxColumn
            // 
            this.methodOfPaymentDataGridViewTextBoxColumn.DataPropertyName = "MethodOfPayment";
            this.methodOfPaymentDataGridViewTextBoxColumn.HeaderText = "MethodOfPayment";
            this.methodOfPaymentDataGridViewTextBoxColumn.Name = "methodOfPaymentDataGridViewTextBoxColumn";
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataMember = "Vendor";
            this.vendorBindingSource.DataSource = this.vendorDataSet;
            // 
            // vendorDataSet
            // 
            this.vendorDataSet.DataSetName = "VendorDataSet";
            this.vendorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.DisplayFocus = true;
            this.LogoutBtn.Highlight = true;
            this.LogoutBtn.Location = new System.Drawing.Point(457, 23);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(117, 39);
            this.LogoutBtn.TabIndex = 7;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseSelectable = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // vendorTableAdapter
            // 
            this.vendorTableAdapter.ClearBeforeFill = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.DisplayFocus = true;
            this.SaveBtn.Highlight = true;
            this.SaveBtn.Location = new System.Drawing.Point(321, 23);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(117, 39);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseSelectable = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // VendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 431);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.VendorGridView);
            this.Name = "VendorForm";
            this.Text = "Vendor Details";
            this.Load += new System.EventHandler(this.VendorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VendorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VendorGridView;
        private MetroFramework.Controls.MetroButton LogoutBtn;
        private VendorDataSet vendorDataSet;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private VendorDataSetTableAdapters.VendorTableAdapter vendorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zIPPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webPageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yourReferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTermsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingTermsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorGSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attachmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAccDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankIFSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodOfPaymentDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton SaveBtn;
    }
}