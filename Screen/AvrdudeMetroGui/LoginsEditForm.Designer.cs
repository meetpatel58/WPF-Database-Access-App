namespace Screen
{
    partial class LoginsEditForm
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PasswordTbox = new MetroFramework.Controls.MetroTextBox();
            this.UserTbox = new MetroFramework.Controls.MetroTextBox();
            this.UpdateBtn = new MetroFramework.Controls.MetroButton();
            this.test = new MetroFramework.Controls.MetroTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PrivComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(39, 207);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "Privileges";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 161);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 116);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "Username";
            // 
            // PasswordTbox
            // 
            this.PasswordTbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTbox.Lines = new string[0];
            this.PasswordTbox.Location = new System.Drawing.Point(133, 157);
            this.PasswordTbox.MaxLength = 32767;
            this.PasswordTbox.Name = "PasswordTbox";
            this.PasswordTbox.PasswordChar = '\0';
            this.PasswordTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTbox.SelectedText = "";
            this.PasswordTbox.Size = new System.Drawing.Size(179, 23);
            this.PasswordTbox.TabIndex = 36;
            this.PasswordTbox.UseSelectable = true;
            // 
            // UserTbox
            // 
            this.UserTbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserTbox.Lines = new string[0];
            this.UserTbox.Location = new System.Drawing.Point(133, 112);
            this.UserTbox.MaxLength = 32767;
            this.UserTbox.Name = "UserTbox";
            this.UserTbox.PasswordChar = '\0';
            this.UserTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserTbox.SelectedText = "";
            this.UserTbox.Size = new System.Drawing.Size(179, 23);
            this.UserTbox.TabIndex = 35;
            this.UserTbox.UseSelectable = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpdateBtn.AutoSize = true;
            this.UpdateBtn.DisplayFocus = true;
            this.UpdateBtn.Highlight = true;
            this.UpdateBtn.Location = new System.Drawing.Point(133, 283);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(117, 39);
            this.UpdateBtn.TabIndex = 42;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseSelectable = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // test
            // 
            this.test.Lines = new string[0];
            this.test.Location = new System.Drawing.Point(39, 269);
            this.test.MaxLength = 32767;
            this.test.Name = "test";
            this.test.PasswordChar = '\0';
            this.test.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.test.SelectedText = "";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 45;
            this.test.UseSelectable = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-15, -15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 46;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // PrivComboBox
            // 
            this.PrivComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PrivComboBox.FormattingEnabled = true;
            this.PrivComboBox.ItemHeight = 23;
            this.PrivComboBox.Location = new System.Drawing.Point(133, 207);
            this.PrivComboBox.Name = "PrivComboBox";
            this.PrivComboBox.Size = new System.Drawing.Size(179, 29);
            this.PrivComboBox.TabIndex = 47;
            this.PrivComboBox.UseSelectable = true;
            // 
            // LoginsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 345);
            this.Controls.Add(this.PrivComboBox);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.test);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PasswordTbox);
            this.Controls.Add(this.UserTbox);
            this.Name = "LoginsEditForm";
            this.Text = "Login Details";
            this.Load += new System.EventHandler(this.LoginsEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox PasswordTbox;
        private MetroFramework.Controls.MetroTextBox UserTbox;
        private MetroFramework.Controls.MetroButton UpdateBtn;
        private MetroFramework.Controls.MetroTextBox test;
        private System.Windows.Forms.RadioButton radioButton1;
        private MetroFramework.Controls.MetroComboBox PrivComboBox;
    }
}