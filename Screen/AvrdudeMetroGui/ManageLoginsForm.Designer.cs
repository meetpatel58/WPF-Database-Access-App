namespace Screen
{
    partial class ManageLoginsForm
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
            this.LoginsGridView = new System.Windows.Forms.DataGridView();
            this.loginuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginsDataSet = new Screen.LoginsDataSet();
            this.loginsTableAdapter = new Screen.LoginsDataSetTableAdapters.LoginsTableAdapter();
            this.LogoutBtn = new MetroFramework.Controls.MetroButton();
            this.CreateBtn = new MetroFramework.Controls.MetroButton();
            this.DeleteBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.LoginsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginsGridView
            // 
            this.LoginsGridView.AllowUserToAddRows = false;
            this.LoginsGridView.AllowUserToDeleteRows = false;
            this.LoginsGridView.AutoGenerateColumns = false;
            this.LoginsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoginsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginuserDataGridViewTextBoxColumn,
            this.loginpassDataGridViewTextBoxColumn,
            this.privilagesDataGridViewTextBoxColumn});
            this.LoginsGridView.DataSource = this.loginsBindingSource;
            this.LoginsGridView.Location = new System.Drawing.Point(37, 126);
            this.LoginsGridView.Name = "LoginsGridView";
            this.LoginsGridView.ReadOnly = true;
            this.LoginsGridView.Size = new System.Drawing.Size(344, 224);
            this.LoginsGridView.TabIndex = 0;
            this.LoginsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoginsGridView_CellClick);
            this.LoginsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LoginsGridView_CellDoubleClick);
            this.LoginsGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LoginsGridView_RowHeaderMouseClick);
            // 
            // loginuserDataGridViewTextBoxColumn
            // 
            this.loginuserDataGridViewTextBoxColumn.DataPropertyName = "Loginuser";
            this.loginuserDataGridViewTextBoxColumn.HeaderText = "Loginuser";
            this.loginuserDataGridViewTextBoxColumn.Name = "loginuserDataGridViewTextBoxColumn";
            this.loginuserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginpassDataGridViewTextBoxColumn
            // 
            this.loginpassDataGridViewTextBoxColumn.DataPropertyName = "Loginpass";
            this.loginpassDataGridViewTextBoxColumn.HeaderText = "Loginpass";
            this.loginpassDataGridViewTextBoxColumn.Name = "loginpassDataGridViewTextBoxColumn";
            this.loginpassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // privilagesDataGridViewTextBoxColumn
            // 
            this.privilagesDataGridViewTextBoxColumn.DataPropertyName = "Privilages";
            this.privilagesDataGridViewTextBoxColumn.HeaderText = "Privilages";
            this.privilagesDataGridViewTextBoxColumn.Name = "privilagesDataGridViewTextBoxColumn";
            this.privilagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "Logins";
            this.loginsBindingSource.DataSource = this.loginsDataSet;
            // 
            // loginsDataSet
            // 
            this.loginsDataSet.DataSetName = "LoginsDataSet";
            this.loginsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.AutoSize = true;
            this.LogoutBtn.DisplayFocus = true;
            this.LogoutBtn.Highlight = true;
            this.LogoutBtn.Location = new System.Drawing.Point(280, 67);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(101, 39);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseSelectable = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.AutoSize = true;
            this.CreateBtn.DisplayFocus = true;
            this.CreateBtn.Highlight = true;
            this.CreateBtn.Location = new System.Drawing.Point(37, 67);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(101, 39);
            this.CreateBtn.TabIndex = 5;
            this.CreateBtn.Text = "Create New User";
            this.CreateBtn.UseSelectable = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSize = true;
            this.DeleteBtn.DisplayFocus = true;
            this.DeleteBtn.Highlight = true;
            this.DeleteBtn.Location = new System.Drawing.Point(159, 67);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(101, 39);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Delete User";
            this.DeleteBtn.UseSelectable = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ManageLoginsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 390);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.LoginsGridView);
            this.Name = "ManageLoginsForm";
            this.Text = "Manage Logins";
            this.Load += new System.EventHandler(this.ManageLoginsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LoginsGridView;
        private LoginsDataSet loginsDataSet;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private LoginsDataSetTableAdapters.LoginsTableAdapter loginsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilagesDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton LogoutBtn;
        private MetroFramework.Controls.MetroButton CreateBtn;
        private MetroFramework.Controls.MetroButton DeleteBtn;
    }
}