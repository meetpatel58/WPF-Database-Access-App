namespace Screen
{
    partial class CategoryForm
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
            this.SaveBtn = new MetroFramework.Controls.MetroButton();
            this.LogoutBtn = new MetroFramework.Controls.MetroButton();
            this.CatagoryGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catagoryDataSet = new Screen.CategoryDataSet();
            this.categoryTableAdapter = new Screen.CatagoryDataSetTableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CatagoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.DisplayFocus = true;
            this.SaveBtn.Highlight = true;
            this.SaveBtn.Location = new System.Drawing.Point(311, 50);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(117, 39);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseSelectable = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.DisplayFocus = true;
            this.LogoutBtn.Highlight = true;
            this.LogoutBtn.Location = new System.Drawing.Point(451, 50);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(117, 39);
            this.LogoutBtn.TabIndex = 9;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseSelectable = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // CatagoryGridView
            // 
            this.CatagoryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CatagoryGridView.AutoGenerateColumns = false;
            this.CatagoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatagoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn});
            this.CatagoryGridView.DataSource = this.categoryBindingSource;
            this.CatagoryGridView.Location = new System.Drawing.Point(37, 112);
            this.CatagoryGridView.Name = "CatagoryGridView";
            this.CatagoryGridView.Size = new System.Drawing.Size(531, 307);
            this.CatagoryGridView.TabIndex = 11;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.catagoryDataSet;
            // 
            // catagoryDataSet
            // 
            this.catagoryDataSet.DataSetName = "CatagoryDataSet";
            this.catagoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 455);
            this.Controls.Add(this.CatagoryGridView);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Name = "CategoryForm";
            this.Text = "Catagories";
            this.Load += new System.EventHandler(this.CatagoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CatagoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton SaveBtn;
        private MetroFramework.Controls.MetroButton LogoutBtn;
        private System.Windows.Forms.DataGridView CatagoryGridView;
        private CategoryDataSet catagoryDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private CatagoryDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
    }
}