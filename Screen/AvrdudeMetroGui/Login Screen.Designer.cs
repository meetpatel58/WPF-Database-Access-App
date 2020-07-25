namespace Screen
{
    partial class Login_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Screen));
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PasswordTbox = new MetroFramework.Controls.MetroTextBox();
            this.LoginBtn = new MetroFramework.Controls.MetroButton();
            this.SQLstatus = new MetroFramework.Controls.MetroTile();
            this.UserLabel = new MetroFramework.Controls.MetroLabel();
            this.UserTbox = new MetroFramework.Controls.MetroTextBox();
            this.purchaseDataSet = new Screen.PurchaseDataSet();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginsTableAdapter = new Screen.PurchaseDataSetTableAdapters.LoginsTableAdapter();
            this.loginsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.LoginEditBtn = new MetroFramework.Controls.MetroButton();
            this.TableComboBox = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(27, 226);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Password";
            // 
            // PasswordTbox
            // 
            this.PasswordTbox.Lines = new string[0];
            this.PasswordTbox.Location = new System.Drawing.Point(125, 228);
            this.PasswordTbox.MaxLength = 32767;
            this.PasswordTbox.Name = "PasswordTbox";
            this.PasswordTbox.PasswordChar = '●';
            this.PasswordTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTbox.SelectedText = "";
            this.PasswordTbox.Size = new System.Drawing.Size(176, 23);
            this.PasswordTbox.TabIndex = 1;
            this.PasswordTbox.UseSelectable = true;
            this.PasswordTbox.UseSystemPasswordChar = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.DisplayFocus = true;
            this.LoginBtn.Highlight = true;
            this.LoginBtn.Location = new System.Drawing.Point(27, 279);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(117, 39);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Login as View";
            this.LoginBtn.UseSelectable = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // SQLstatus
            // 
            this.SQLstatus.ActiveControl = null;
            this.SQLstatus.BackColor = System.Drawing.Color.Black;
            this.SQLstatus.Location = new System.Drawing.Point(184, 345);
            this.SQLstatus.Name = "SQLstatus";
            this.SQLstatus.Size = new System.Drawing.Size(117, 39);
            this.SQLstatus.TabIndex = 5;
            this.SQLstatus.Text = "DB Disconnected";
            this.SQLstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SQLstatus.UseCustomBackColor = true;
            this.SQLstatus.UseSelectable = true;
            this.SQLstatus.Click += new System.EventHandler(this.SQLstatus_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UserLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.UserLabel.Location = new System.Drawing.Point(27, 178);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(91, 25);
            this.UserLabel.TabIndex = 4;
            this.UserLabel.Text = "Username";
            // 
            // UserTbox
            // 
            this.UserTbox.Lines = new string[0];
            this.UserTbox.Location = new System.Drawing.Point(125, 180);
            this.UserTbox.MaxLength = 32767;
            this.UserTbox.Name = "UserTbox";
            this.UserTbox.PasswordChar = '\0';
            this.UserTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserTbox.SelectedText = "";
            this.UserTbox.Size = new System.Drawing.Size(176, 23);
            this.UserTbox.TabIndex = 0;
            this.UserTbox.UseSelectable = true;
            // 
            // purchaseDataSet
            // 
            this.purchaseDataSet.DataSetName = "PurchaseDataSet";
            this.purchaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "Logins";
            this.loginsBindingSource.DataSource = this.purchaseDataSet;
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // loginsBindingSource1
            // 
            this.loginsBindingSource1.DataMember = "Logins";
            this.loginsBindingSource1.DataSource = this.purchaseDataSet;
            // 
            // loginsBindingSource2
            // 
            this.loginsBindingSource2.DataMember = "Logins";
            this.loginsBindingSource2.DataSource = this.purchaseDataSet;
            // 
            // LoginEditBtn
            // 
            this.LoginEditBtn.DisplayFocus = true;
            this.LoginEditBtn.Highlight = true;
            this.LoginEditBtn.Location = new System.Drawing.Point(27, 345);
            this.LoginEditBtn.Name = "LoginEditBtn";
            this.LoginEditBtn.Size = new System.Drawing.Size(117, 39);
            this.LoginEditBtn.TabIndex = 6;
            this.LoginEditBtn.Text = "Login as Edit";
            this.LoginEditBtn.UseSelectable = true;
            this.LoginEditBtn.Click += new System.EventHandler(this.LoginEditBtn_Click);
            // 
            // TableComboBox
            // 
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.ItemHeight = 23;
            this.TableComboBox.Items.AddRange(new object[] {
            "Part Details",
            "Vendor Details",
            "Category"});
            this.TableComboBox.Location = new System.Drawing.Point(180, 279);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(121, 29);
            this.TableComboBox.TabIndex = 7;
            this.TableComboBox.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Screen.Properties.Resources.LOGO1;
            this.pictureBox1.Location = new System.Drawing.Point(15, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Screen
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(324, 422);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.LoginEditBtn);
            this.Controls.Add(this.UserTbox);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SQLstatus);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTbox);
            this.Controls.Add(this.metroLabel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginsBindingSource2, "Loginuser", true));
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login_Screen";
            this.Resizable = false;
            this.Text = "Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Login_Screen_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_Screen_FormClosing);
            this.Load += new System.EventHandler(this.Login_Screen_Load);
            this.Enter += new System.EventHandler(this.Login_Screen_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox PasswordTbox;
        private MetroFramework.Controls.MetroButton LoginBtn;
        private MetroFramework.Controls.MetroTile SQLstatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel UserLabel;
        private MetroFramework.Controls.MetroTextBox UserTbox;
        private PurchaseDataSet purchaseDataSet;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private PurchaseDataSetTableAdapters.LoginsTableAdapter loginsTableAdapter;
        private System.Windows.Forms.BindingSource loginsBindingSource1;
        private System.Windows.Forms.BindingSource loginsBindingSource2;
        private MetroFramework.Controls.MetroButton LoginEditBtn;
        private MetroFramework.Controls.MetroComboBox TableComboBox;
    }
}