namespace Screen
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ServerLable = new MetroFramework.Controls.MetroLabel();
            this.ServerTbox = new MetroFramework.Controls.MetroTextBox();
            this.DatabaseTbox = new MetroFramework.Controls.MetroTextBox();
            this.DatabaseLable = new MetroFramework.Controls.MetroLabel();
            this.UserTbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.PasswordTbox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SaveBtn = new MetroFramework.Controls.MetroButton();
            this.Logoutbtn = new MetroFramework.Controls.MetroButton();
            this.SQLstatus = new MetroFramework.Controls.MetroTile();
            this.LoginsBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // ServerLable
            // 
            this.ServerLable.AutoSize = true;
            this.ServerLable.Location = new System.Drawing.Point(25, 80);
            this.ServerLable.Name = "ServerLable";
            this.ServerLable.Size = new System.Drawing.Size(47, 19);
            this.ServerLable.TabIndex = 0;
            this.ServerLable.Text = "Server";
            // 
            // ServerTbox
            // 
            this.ServerTbox.Lines = new string[0];
            this.ServerTbox.Location = new System.Drawing.Point(120, 80);
            this.ServerTbox.MaxLength = 32767;
            this.ServerTbox.Name = "ServerTbox";
            this.ServerTbox.PasswordChar = '\0';
            this.ServerTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ServerTbox.SelectedText = "";
            this.ServerTbox.Size = new System.Drawing.Size(228, 23);
            this.ServerTbox.TabIndex = 1;
            this.ServerTbox.UseSelectable = true;
            // 
            // DatabaseTbox
            // 
            this.DatabaseTbox.Lines = new string[0];
            this.DatabaseTbox.Location = new System.Drawing.Point(120, 120);
            this.DatabaseTbox.MaxLength = 32767;
            this.DatabaseTbox.Name = "DatabaseTbox";
            this.DatabaseTbox.PasswordChar = '\0';
            this.DatabaseTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DatabaseTbox.SelectedText = "";
            this.DatabaseTbox.Size = new System.Drawing.Size(228, 23);
            this.DatabaseTbox.TabIndex = 3;
            this.DatabaseTbox.UseSelectable = true;
            // 
            // DatabaseLable
            // 
            this.DatabaseLable.AutoSize = true;
            this.DatabaseLable.Location = new System.Drawing.Point(25, 120);
            this.DatabaseLable.Name = "DatabaseLable";
            this.DatabaseLable.Size = new System.Drawing.Size(63, 19);
            this.DatabaseLable.TabIndex = 2;
            this.DatabaseLable.Text = "Database";
            // 
            // UserTbox
            // 
            this.UserTbox.Lines = new string[0];
            this.UserTbox.Location = new System.Drawing.Point(120, 160);
            this.UserTbox.MaxLength = 32767;
            this.UserTbox.Name = "UserTbox";
            this.UserTbox.PasswordChar = '\0';
            this.UserTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserTbox.SelectedText = "";
            this.UserTbox.Size = new System.Drawing.Size(228, 23);
            this.UserTbox.TabIndex = 5;
            this.UserTbox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 160);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(35, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "User";
            // 
            // PasswordTbox
            // 
            this.PasswordTbox.Lines = new string[0];
            this.PasswordTbox.Location = new System.Drawing.Point(121, 200);
            this.PasswordTbox.MaxLength = 32767;
            this.PasswordTbox.Name = "PasswordTbox";
            this.PasswordTbox.PasswordChar = '\0';
            this.PasswordTbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTbox.SelectedText = "";
            this.PasswordTbox.Size = new System.Drawing.Size(228, 23);
            this.PasswordTbox.TabIndex = 7;
            this.PasswordTbox.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 200);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Password";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Highlight = true;
            this.SaveBtn.Location = new System.Drawing.Point(25, 250);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(96, 33);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save Settings";
            this.SaveBtn.UseSelectable = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Highlight = true;
            this.Logoutbtn.Location = new System.Drawing.Point(251, 250);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(96, 33);
            this.Logoutbtn.TabIndex = 11;
            this.Logoutbtn.Text = "Logout";
            this.Logoutbtn.UseSelectable = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // SQLstatus
            // 
            this.SQLstatus.ActiveControl = null;
            this.SQLstatus.BackColor = System.Drawing.Color.Silver;
            this.SQLstatus.Location = new System.Drawing.Point(25, 302);
            this.SQLstatus.Name = "SQLstatus";
            this.SQLstatus.Size = new System.Drawing.Size(324, 47);
            this.SQLstatus.TabIndex = 12;
            this.SQLstatus.Text = "DB Disconnected";
            this.SQLstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SQLstatus.UseCustomBackColor = true;
            this.SQLstatus.UseSelectable = true;
            this.SQLstatus.Click += new System.EventHandler(this.SQLStatus_Click);
            // 
            // LoginsBtn
            // 
            this.LoginsBtn.Highlight = true;
            this.LoginsBtn.Location = new System.Drawing.Point(138, 250);
            this.LoginsBtn.Name = "LoginsBtn";
            this.LoginsBtn.Size = new System.Drawing.Size(96, 33);
            this.LoginsBtn.TabIndex = 13;
            this.LoginsBtn.Text = "Manage Logins";
            this.LoginsBtn.UseSelectable = true;
            this.LoginsBtn.Click += new System.EventHandler(this.LoginsBtn_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 362);
            this.Controls.Add(this.LoginsBtn);
            this.Controls.Add(this.SQLstatus);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.PasswordTbox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.UserTbox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.DatabaseTbox);
            this.Controls.Add(this.DatabaseLable);
            this.Controls.Add(this.ServerTbox);
            this.Controls.Add(this.ServerLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin_Form";
            this.Resizable = false;
            this.Text = "Database_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel ServerLable;
        private MetroFramework.Controls.MetroTextBox ServerTbox;
        private MetroFramework.Controls.MetroTextBox DatabaseTbox;
        private MetroFramework.Controls.MetroLabel DatabaseLable;
        private MetroFramework.Controls.MetroTextBox UserTbox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox PasswordTbox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton SaveBtn;
        private MetroFramework.Controls.MetroButton Logoutbtn;
        private MetroFramework.Controls.MetroTile SQLstatus;
        private MetroFramework.Controls.MetroButton LoginsBtn;
    }
}