namespace Screen
{
    partial class NewForm
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
            this.EnterBtn = new MetroFramework.Controls.MetroButton();
            this.LogoutBtn = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPartNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorPartNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitOfMeasureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minOrderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hSNCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSheetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDataSet5 = new Screen.PurchaseDataSet5();
            this.partDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDataSet3 = new Screen.PurchaseDataSet3();
            this.partDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDataSet2 = new Screen.PurchaseDataSet2();
            this.partsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDataSet1 = new Screen.PurchaseDataSet1();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editDataSet = new Screen.EditDataSet();
            this.partsTableAdapter = new Screen.EditDataSetTableAdapters.PartsTableAdapter();
            this.partsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter1 = new Screen.PurchaseDataSet1TableAdapters.PartsTableAdapter();
            this.SearchTbox = new MetroFramework.Controls.MetroTextBox();
            this.SearchLabel = new MetroFramework.Controls.MetroLabel();
            this.UpdateBtn = new MetroFramework.Controls.MetroButton();
            this.Deletebtn = new MetroFramework.Controls.MetroButton();
            this.ComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.partDetailsTableAdapter = new Screen.PurchaseDataSet2TableAdapters.PartDetailsTableAdapter();
            this.partDetailsTableAdapter1 = new Screen.PurchaseDataSet3TableAdapters.PartDetailsTableAdapter();
            this.purchaseDataSet4 = new Screen.PurchaseDataSet4();
            this.partDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.partDetailsTableAdapter2 = new Screen.PurchaseDataSet4TableAdapters.PartDetailsTableAdapter();
            this.partDetailsTableAdapter3 = new Screen.PurchaseDataSet5TableAdapters.PartDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDetailsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterBtn
            // 
            this.EnterBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EnterBtn.DisplayFocus = true;
            this.EnterBtn.Highlight = true;
            this.EnterBtn.Location = new System.Drawing.Point(23, 360);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(117, 39);
            this.EnterBtn.TabIndex = 2;
            this.EnterBtn.Text = "New";
            this.EnterBtn.UseSelectable = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LogoutBtn.AutoSize = true;
            this.LogoutBtn.DisplayFocus = true;
            this.LogoutBtn.Highlight = true;
            this.LogoutBtn.Location = new System.Drawing.Point(479, 360);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(117, 39);
            this.LogoutBtn.TabIndex = 3;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseSelectable = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.metroPartNoDataGridViewTextBoxColumn,
            this.vendorPartNoDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.partDescriptionDataGridViewTextBoxColumn,
            this.applicationDataGridViewTextBoxColumn,
            this.unitOfMeasureDataGridViewTextBoxColumn,
            this.minOrderQuantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.hSNCodeDataGridViewTextBoxColumn,
            this.taxCodeDataGridViewTextBoxColumn,
            this.vendorNameDataGridViewTextBoxColumn,
            this.orderDescriptionDataGridViewTextBoxColumn,
            this.dataSheetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partDetailsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(23, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(592, 258);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metroPartNoDataGridViewTextBoxColumn
            // 
            this.metroPartNoDataGridViewTextBoxColumn.DataPropertyName = "MetroPartNo";
            this.metroPartNoDataGridViewTextBoxColumn.HeaderText = "MetroPartNo";
            this.metroPartNoDataGridViewTextBoxColumn.Name = "metroPartNoDataGridViewTextBoxColumn";
            this.metroPartNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendorPartNoDataGridViewTextBoxColumn
            // 
            this.vendorPartNoDataGridViewTextBoxColumn.DataPropertyName = "VendorPartNo";
            this.vendorPartNoDataGridViewTextBoxColumn.HeaderText = "VendorPartNo";
            this.vendorPartNoDataGridViewTextBoxColumn.Name = "vendorPartNoDataGridViewTextBoxColumn";
            this.vendorPartNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partDescriptionDataGridViewTextBoxColumn
            // 
            this.partDescriptionDataGridViewTextBoxColumn.DataPropertyName = "PartDescription";
            this.partDescriptionDataGridViewTextBoxColumn.HeaderText = "PartDescription";
            this.partDescriptionDataGridViewTextBoxColumn.Name = "partDescriptionDataGridViewTextBoxColumn";
            this.partDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applicationDataGridViewTextBoxColumn
            // 
            this.applicationDataGridViewTextBoxColumn.DataPropertyName = "Application";
            this.applicationDataGridViewTextBoxColumn.HeaderText = "Application";
            this.applicationDataGridViewTextBoxColumn.Name = "applicationDataGridViewTextBoxColumn";
            this.applicationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitOfMeasureDataGridViewTextBoxColumn
            // 
            this.unitOfMeasureDataGridViewTextBoxColumn.DataPropertyName = "UnitOfMeasure";
            this.unitOfMeasureDataGridViewTextBoxColumn.HeaderText = "UnitOfMeasure";
            this.unitOfMeasureDataGridViewTextBoxColumn.Name = "unitOfMeasureDataGridViewTextBoxColumn";
            this.unitOfMeasureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minOrderQuantityDataGridViewTextBoxColumn
            // 
            this.minOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "MinOrderQuantity";
            this.minOrderQuantityDataGridViewTextBoxColumn.HeaderText = "MinOrderQuantity";
            this.minOrderQuantityDataGridViewTextBoxColumn.Name = "minOrderQuantityDataGridViewTextBoxColumn";
            this.minOrderQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hSNCodeDataGridViewTextBoxColumn
            // 
            this.hSNCodeDataGridViewTextBoxColumn.DataPropertyName = "HSNCode";
            this.hSNCodeDataGridViewTextBoxColumn.HeaderText = "HSNCode";
            this.hSNCodeDataGridViewTextBoxColumn.Name = "hSNCodeDataGridViewTextBoxColumn";
            this.hSNCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxCodeDataGridViewTextBoxColumn
            // 
            this.taxCodeDataGridViewTextBoxColumn.DataPropertyName = "TaxCode";
            this.taxCodeDataGridViewTextBoxColumn.HeaderText = "TaxCode";
            this.taxCodeDataGridViewTextBoxColumn.Name = "taxCodeDataGridViewTextBoxColumn";
            this.taxCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vendorNameDataGridViewTextBoxColumn
            // 
            this.vendorNameDataGridViewTextBoxColumn.DataPropertyName = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.HeaderText = "VendorName";
            this.vendorNameDataGridViewTextBoxColumn.Name = "vendorNameDataGridViewTextBoxColumn";
            this.vendorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDescriptionDataGridViewTextBoxColumn
            // 
            this.orderDescriptionDataGridViewTextBoxColumn.DataPropertyName = "OrderDescription";
            this.orderDescriptionDataGridViewTextBoxColumn.HeaderText = "OrderDescription";
            this.orderDescriptionDataGridViewTextBoxColumn.Name = "orderDescriptionDataGridViewTextBoxColumn";
            this.orderDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSheetDataGridViewTextBoxColumn
            // 
            this.dataSheetDataGridViewTextBoxColumn.DataPropertyName = "DataSheet";
            this.dataSheetDataGridViewTextBoxColumn.HeaderText = "DataSheet";
            this.dataSheetDataGridViewTextBoxColumn.Name = "dataSheetDataGridViewTextBoxColumn";
            this.dataSheetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partDetailsBindingSource3
            // 
            this.partDetailsBindingSource3.DataMember = "PartDetails";
            this.partDetailsBindingSource3.DataSource = this.purchaseDataSet5;
            // 
            // purchaseDataSet5
            // 
            this.purchaseDataSet5.DataSetName = "PurchaseDataSet5";
            this.purchaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partDetailsBindingSource1
            // 
            this.partDetailsBindingSource1.DataMember = "PartDetails";
            this.partDetailsBindingSource1.DataSource = this.purchaseDataSet3;
            // 
            // purchaseDataSet3
            // 
            this.purchaseDataSet3.DataSetName = "PurchaseDataSet3";
            this.purchaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partDetailsBindingSource
            // 
            this.partDetailsBindingSource.DataMember = "PartDetails";
            this.partDetailsBindingSource.DataSource = this.purchaseDataSet2;
            // 
            // purchaseDataSet2
            // 
            this.purchaseDataSet2.DataSetName = "PurchaseDataSet2";
            this.purchaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsBindingSource2
            // 
            this.partsBindingSource2.DataMember = "Parts";
            this.partsBindingSource2.DataSource = this.purchaseDataSet1;
            // 
            // purchaseDataSet1
            // 
            this.purchaseDataSet1.DataSetName = "PurchaseDataSet1";
            this.purchaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "Parts";
            this.partsBindingSource.DataSource = this.editDataSet;
            // 
            // editDataSet
            // 
            this.editDataSet.DataSetName = "EditDataSet";
            this.editDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // partsBindingSource1
            // 
            this.partsBindingSource1.DataMember = "Parts";
            this.partsBindingSource1.DataSource = this.purchaseDataSet1;
            // 
            // partsTableAdapter1
            // 
            this.partsTableAdapter1.ClearBeforeFill = true;
            // 
            // SearchTbox
            // 
            this.SearchTbox.Lines = new string[0];
            this.SearchTbox.Location = new System.Drawing.Point(330, 25);
            this.SearchTbox.MaxLength = 32767;
            this.SearchTbox.Name = "SearchTbox";
            this.SearchTbox.PasswordChar = '\0';
            this.SearchTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTbox.SelectedText = "";
            this.SearchTbox.Size = new System.Drawing.Size(198, 23);
            this.SearchTbox.TabIndex = 5;
            this.SearchTbox.TabStop = false;
            this.SearchTbox.UseSelectable = true;
            this.SearchTbox.TextChanged += new System.EventHandler(this.SearchTbox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SearchLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SearchLabel.Location = new System.Drawing.Point(26, 25);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(88, 25);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Search By";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateBtn.DisplayFocus = true;
            this.UpdateBtn.Highlight = true;
            this.UpdateBtn.Location = new System.Drawing.Point(169, 360);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(117, 39);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Edit";
            this.UpdateBtn.UseSelectable = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Deletebtn.DisplayFocus = true;
            this.Deletebtn.Highlight = true;
            this.Deletebtn.Location = new System.Drawing.Point(318, 360);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(117, 39);
            this.Deletebtn.TabIndex = 8;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseSelectable = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.ItemHeight = 23;
            this.ComboBox1.Items.AddRange(new object[] {
            "Product_ID",
            "Description"});
            this.ComboBox1.Location = new System.Drawing.Point(120, 21);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(193, 29);
            this.ComboBox1.TabIndex = 9;
            this.ComboBox1.UseSelectable = true;
            // 
            // partDetailsTableAdapter
            // 
            this.partDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // partDetailsTableAdapter1
            // 
            this.partDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // purchaseDataSet4
            // 
            this.purchaseDataSet4.DataSetName = "PurchaseDataSet4";
            this.purchaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partDetailsBindingSource2
            // 
            this.partDetailsBindingSource2.DataMember = "PartDetails";
            this.partDetailsBindingSource2.DataSource = this.purchaseDataSet4;
            // 
            // partDetailsTableAdapter2
            // 
            this.partDetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // partDetailsTableAdapter3
            // 
            this.partDetailsTableAdapter3.ClearBeforeFill = true;
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 422);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchTbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.EnterBtn);
            this.Name = "NewForm";
            this.Load += new System.EventHandler(this.NewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDetailsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton EnterBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EditDataSet editDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private EditDataSetTableAdapters.PartsTableAdapter partsTableAdapter;
        private PurchaseDataSet1 purchaseDataSet1;
        private System.Windows.Forms.BindingSource partsBindingSource1;
        private PurchaseDataSet1TableAdapters.PartsTableAdapter partsTableAdapter1;
        private System.Windows.Forms.BindingSource partsBindingSource2;
        private MetroFramework.Controls.MetroTextBox SearchTbox;
        private MetroFramework.Controls.MetroLabel SearchLabel;
        private MetroFramework.Controls.MetroButton UpdateBtn;
        private MetroFramework.Controls.MetroButton Deletebtn;
        private MetroFramework.Controls.MetroComboBox ComboBox1;
        private MetroFramework.Controls.MetroButton LogoutBtn;
        private PurchaseDataSet2 purchaseDataSet2;
        private System.Windows.Forms.BindingSource partDetailsBindingSource;
        private PurchaseDataSet2TableAdapters.PartDetailsTableAdapter partDetailsTableAdapter;
        private PurchaseDataSet3 purchaseDataSet3;
        private System.Windows.Forms.BindingSource partDetailsBindingSource1;
        private PurchaseDataSet3TableAdapters.PartDetailsTableAdapter partDetailsTableAdapter1;
        private PurchaseDataSet4 purchaseDataSet4;
        private System.Windows.Forms.BindingSource partDetailsBindingSource2;
        private PurchaseDataSet4TableAdapters.PartDetailsTableAdapter partDetailsTableAdapter2;
        private PurchaseDataSet5 purchaseDataSet5;
        private System.Windows.Forms.BindingSource partDetailsBindingSource3;
        private PurchaseDataSet5TableAdapters.PartDetailsTableAdapter partDetailsTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metroPartNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorPartNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitOfMeasureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minOrderQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hSNCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSheetDataGridViewTextBoxColumn;
    }
}