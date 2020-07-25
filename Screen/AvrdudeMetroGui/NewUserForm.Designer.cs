namespace Screen
{
    partial class NewUserForm
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
            this.CreateBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PasswordTbox = new MetroFramework.Controls.MetroTextBox();
            this.UserTbox = new MetroFramework.Controls.MetroTextBox();
            this.PComboBox = new MetroFramework.Controls.MetroComboBox();
            this.test = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CreateBtn
            // 
            this.CreateBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateBtn.AutoSize = true;
            this.CreateBtn.DisplayFocus = true;
            this.CreateBtn.Highlight = true;
            this.CreateBtn.Location = new System.Drawing.Point(146, 232);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(117, 39);
            this.CreateBtn.TabIndex = 53;
            this.CreateBtn.Text = "Create User";
            this.CreateBtn.UseSelectable = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(52, 179);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 52;
            this.metroLabel3.Text = "Privileges";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(52, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 51;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 50;
            this.metroLabel1.Text = "Username";
            // 
            // PasswordTbox
            // 
            this.PasswordTbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTbox.Lines = new string[0];
            this.PasswordTbox.Location = new System.Drawing.Point(146, 129);
            this.PasswordTbox.MaxLength = 32767;
            this.PasswordTbox.Name = "PasswordTbox";
            this.PasswordTbox.PasswordChar = '\0';
            this.PasswordTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTbox.SelectedText = "";
            this.PasswordTbox.Size = new System.Drawing.Size(179, 23);
            this.PasswordTbox.TabIndex = 49;
            this.PasswordTbox.UseSelectable = true;
            // 
            // UserTbox
            // 
            this.UserTbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserTbox.Lines = new string[0];
            this.UserTbox.Location = new System.Drawing.Point(146, 84);
            this.UserTbox.MaxLength = 32767;
            this.UserTbox.Name = "UserTbox";
            this.UserTbox.PasswordChar = '\0';
            this.UserTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserTbox.SelectedText = "";
            this.UserTbox.Size = new System.Drawing.Size(179, 23);
            this.UserTbox.TabIndex = 48;
            this.UserTbox.UseSelectable = true;
            // 
            // PComboBox
            // 
            this.PComboBox.FormattingEnabled = true;
            this.PComboBox.ItemHeight = 23;
            this.PComboBox.Location = new System.Drawing.Point(146, 176);
            this.PComboBox.Name = "PComboBox";
            this.PComboBox.Size = new System.Drawing.Size(179, 29);
            this.PComboBox.TabIndex = 54;
            this.PComboBox.UseSelectable = true;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(52, 243);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 55;
            this.test.UseSelectable = true;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 300);
            this.Controls.Add(this.test);
            this.Controls.Add(this.PComboBox);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PasswordTbox);
            this.Controls.Add(this.UserTbox);
            this.Name = "NewUserForm";
            this.Text = "Enter Details";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton CreateBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox PasswordTbox;
        private MetroFramework.Controls.MetroTextBox UserTbox;
        private MetroFramework.Controls.MetroComboBox PComboBox;
        private MetroFramework.Controls.MetroButton test;

    }
}