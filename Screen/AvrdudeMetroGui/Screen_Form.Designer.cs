namespace Screen
{
    partial class Screen_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Screen_Form));
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.SQLstatus = new MetroFramework.Controls.MetroTile();
            this.LogoutBtn = new MetroFramework.Controls.MetroButton();
            this.KGB_995 = new MetroFramework.Controls.MetroTextBox();
            this.KGB_995_Label = new MetroFramework.Controls.MetroLabel();
            this.TTB = new MetroFramework.Controls.MetroTextBox();
            this.TTB_Label = new MetroFramework.Controls.MetroLabel();
            this.T5_Gbox = new System.Windows.Forms.GroupBox();
            this.T5_995 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.T5_999 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.T10_Gbox = new System.Windows.Forms.GroupBox();
            this.T10_995 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.T10_999 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.AED_PG = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.XAU_BID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.XAU_ASK = new MetroFramework.Controls.MetroTextBox();
            this.GoldShiftGb = new System.Windows.Forms.GroupBox();
            this.S_XAU = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MB_XAU = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.MA_XAU = new MetroFramework.Controls.MetroTextBox();
            this.MG_XAU_Gbox = new System.Windows.Forms.GroupBox();
            this.SilverShift = new System.Windows.Forms.GroupBox();
            this.XAG_ASK = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.XAG_BID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.S_XAG = new MetroFramework.Controls.MetroTextBox();
            this.S_XAG_Label = new MetroFramework.Controls.MetroLabel();
            this.MasterSliverXAG = new System.Windows.Forms.GroupBox();
            this.MA_XAG = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.MB_XAG = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.S_XAU_Label = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.hiddenTb = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AED_PG_Label = new MetroFramework.Controls.MetroLabel();
            this.TTB_Sign = new MetroFramework.Controls.MetroLabel();
            this.KGB_995_Sign = new MetroFramework.Controls.MetroLabel();
            this.S_XAU_Sign = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.T5_Gbox.SuspendLayout();
            this.T10_Gbox.SuspendLayout();
            this.GoldShiftGb.SuspendLayout();
            this.MG_XAU_Gbox.SuspendLayout();
            this.SilverShift.SuspendLayout();
            this.MasterSliverXAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // SQLstatus
            // 
            this.SQLstatus.ActiveControl = null;
            this.SQLstatus.BackColor = System.Drawing.Color.Black;
            this.SQLstatus.Location = new System.Drawing.Point(112, 24);
            this.SQLstatus.Name = "SQLstatus";
            this.SQLstatus.Size = new System.Drawing.Size(145, 34);
            this.SQLstatus.TabIndex = 0;
            this.SQLstatus.TabStop = false;
            this.SQLstatus.Text = "DB Connected";
            this.SQLstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SQLstatus.UseCustomBackColor = true;
            this.SQLstatus.UseSelectable = true;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Highlight = true;
            this.LogoutBtn.Location = new System.Drawing.Point(241, 707);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(113, 38);
            this.LogoutBtn.TabIndex = 0;
            this.LogoutBtn.TabStop = false;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseSelectable = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // KGB_995
            // 
            this.KGB_995.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.KGB_995.Lines = new string[0];
            this.KGB_995.Location = new System.Drawing.Point(188, 253);
            this.KGB_995.MaxLength = 32767;
            this.KGB_995.Name = "KGB_995";
            this.KGB_995.PasswordChar = '\0';
            this.KGB_995.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.KGB_995.SelectedText = "";
            this.KGB_995.Size = new System.Drawing.Size(144, 30);
            this.KGB_995.TabIndex = 3;
            this.KGB_995.UseSelectable = true;
            this.KGB_995.Click += new System.EventHandler(this.Common_Enter);
            this.KGB_995.Enter += new System.EventHandler(this.Common_Enter);
            this.KGB_995.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.KGB_995.Leave += new System.EventHandler(this.Common_Leave);
            this.KGB_995.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CommonMouse_Enter);
            this.KGB_995.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommonMouse_Enter);
            // 
            // KGB_995_Label
            // 
            this.KGB_995_Label.AutoSize = true;
            this.KGB_995_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.KGB_995_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.KGB_995_Label.Location = new System.Drawing.Point(4, 253);
            this.KGB_995_Label.Name = "KGB_995_Label";
            this.KGB_995_Label.Size = new System.Drawing.Size(175, 25);
            this.KGB_995_Label.TabIndex = 0;
            this.KGB_995_Label.Text = "KG bar 995 Premium";
            this.KGB_995_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KGB_995_Label.UseCustomBackColor = true;
            // 
            // TTB
            // 
            this.TTB.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TTB.Lines = new string[0];
            this.TTB.Location = new System.Drawing.Point(188, 289);
            this.TTB.MaxLength = 32767;
            this.TTB.Name = "TTB";
            this.TTB.PasswordChar = '\0';
            this.TTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TTB.SelectedText = "";
            this.TTB.Size = new System.Drawing.Size(144, 30);
            this.TTB.TabIndex = 4;
            this.TTB.UseSelectable = true;
            this.TTB.Click += new System.EventHandler(this.Common_Enter);
            this.TTB.Enter += new System.EventHandler(this.Common_Enter);
            this.TTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.TTB.Leave += new System.EventHandler(this.Common_Leave);
            this.TTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CommonMouse_Enter);
            this.TTB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommonMouse_Enter);
            // 
            // TTB_Label
            // 
            this.TTB_Label.AutoSize = true;
            this.TTB_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TTB_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TTB_Label.Location = new System.Drawing.Point(8, 289);
            this.TTB_Label.Name = "TTB_Label";
            this.TTB_Label.Size = new System.Drawing.Size(172, 25);
            this.TTB_Label.TabIndex = 0;
            this.TTB_Label.Text = "TT bar 999 Premium";
            this.TTB_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TTB_Label.UseCustomBackColor = true;
            // 
            // T5_Gbox
            // 
            this.T5_Gbox.BackColor = System.Drawing.Color.Plum;
            this.T5_Gbox.Controls.Add(this.T5_995);
            this.T5_Gbox.Controls.Add(this.metroLabel8);
            this.T5_Gbox.Controls.Add(this.T5_999);
            this.T5_Gbox.Controls.Add(this.metroLabel9);
            this.T5_Gbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T5_Gbox.Location = new System.Drawing.Point(9, 367);
            this.T5_Gbox.Name = "T5_Gbox";
            this.T5_Gbox.Size = new System.Drawing.Size(355, 66);
            this.T5_Gbox.TabIndex = 6;
            this.T5_Gbox.TabStop = false;
            this.T5_Gbox.Text = "5 Tola Chain";
            // 
            // T5_995
            // 
            this.T5_995.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.T5_995.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.T5_995.Lines = new string[0];
            this.T5_995.Location = new System.Drawing.Point(226, 24);
            this.T5_995.MaxLength = 32767;
            this.T5_995.Name = "T5_995";
            this.T5_995.PasswordChar = '\0';
            this.T5_995.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.T5_995.SelectedText = "";
            this.T5_995.Size = new System.Drawing.Size(100, 30);
            this.T5_995.TabIndex = 1;
            this.T5_995.UseSelectable = true;
            this.T5_995.Click += new System.EventHandler(this.Common_Enter);
            this.T5_995.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.T5_995.Leave += new System.EventHandler(this.Common_Enter);
            this.T5_995.Validated += new System.EventHandler(this.Common_Leave);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(182, 27);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(33, 19);
            this.metroLabel8.TabIndex = 0;
            this.metroLabel8.Text = "995";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // T5_999
            // 
            this.T5_999.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.T5_999.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.T5_999.Lines = new string[0];
            this.T5_999.Location = new System.Drawing.Point(64, 24);
            this.T5_999.MaxLength = 32767;
            this.T5_999.Name = "T5_999";
            this.T5_999.PasswordChar = '\0';
            this.T5_999.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.T5_999.SelectedText = "";
            this.T5_999.Size = new System.Drawing.Size(100, 30);
            this.T5_999.TabIndex = 0;
            this.T5_999.UseSelectable = true;
            this.T5_999.Click += new System.EventHandler(this.Common_Enter);
            this.T5_999.Enter += new System.EventHandler(this.Common_Enter);
            this.T5_999.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.T5_999.Leave += new System.EventHandler(this.Common_Leave);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(11, 27);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(40, 19);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Pure";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // T10_Gbox
            // 
            this.T10_Gbox.BackColor = System.Drawing.Color.Plum;
            this.T10_Gbox.Controls.Add(this.T10_995);
            this.T10_Gbox.Controls.Add(this.metroLabel10);
            this.T10_Gbox.Controls.Add(this.T10_999);
            this.T10_Gbox.Controls.Add(this.metroLabel11);
            this.T10_Gbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T10_Gbox.Location = new System.Drawing.Point(9, 433);
            this.T10_Gbox.Name = "T10_Gbox";
            this.T10_Gbox.Size = new System.Drawing.Size(355, 66);
            this.T10_Gbox.TabIndex = 7;
            this.T10_Gbox.TabStop = false;
            this.T10_Gbox.Text = "10 Tola Chain";
            // 
            // T10_995
            // 
            this.T10_995.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.T10_995.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.T10_995.Lines = new string[0];
            this.T10_995.Location = new System.Drawing.Point(226, 24);
            this.T10_995.MaxLength = 32767;
            this.T10_995.Name = "T10_995";
            this.T10_995.PasswordChar = '\0';
            this.T10_995.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.T10_995.SelectedText = "";
            this.T10_995.Size = new System.Drawing.Size(100, 30);
            this.T10_995.TabIndex = 1;
            this.T10_995.UseSelectable = true;
            this.T10_995.Click += new System.EventHandler(this.Common_Enter);
            this.T10_995.Enter += new System.EventHandler(this.Common_Enter);
            this.T10_995.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.T10_995.Leave += new System.EventHandler(this.Common_Leave);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(182, 27);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(33, 19);
            this.metroLabel10.TabIndex = 0;
            this.metroLabel10.Text = "995";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // T10_999
            // 
            this.T10_999.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.T10_999.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.T10_999.Lines = new string[0];
            this.T10_999.Location = new System.Drawing.Point(64, 24);
            this.T10_999.MaxLength = 32767;
            this.T10_999.Name = "T10_999";
            this.T10_999.PasswordChar = '\0';
            this.T10_999.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.T10_999.SelectedText = "";
            this.T10_999.Size = new System.Drawing.Size(100, 30);
            this.T10_999.TabIndex = 0;
            this.T10_999.UseSelectable = true;
            this.T10_999.Click += new System.EventHandler(this.Common_Enter);
            this.T10_999.Enter += new System.EventHandler(this.Common_Enter);
            this.T10_999.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.T10_999.Leave += new System.EventHandler(this.Common_Leave);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(11, 27);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(40, 19);
            this.metroLabel11.TabIndex = 0;
            this.metroLabel11.Text = "Pure";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // AED_PG
            // 
            this.AED_PG.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.AED_PG.Lines = new string[0];
            this.AED_PG.Location = new System.Drawing.Point(188, 325);
            this.AED_PG.MaxLength = 32767;
            this.AED_PG.Name = "AED_PG";
            this.AED_PG.PasswordChar = '\0';
            this.AED_PG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AED_PG.SelectedText = "";
            this.AED_PG.Size = new System.Drawing.Size(143, 30);
            this.AED_PG.TabIndex = 5;
            this.AED_PG.UseSelectable = true;
            this.AED_PG.Click += new System.EventHandler(this.Common_Enter);
            this.AED_PG.Enter += new System.EventHandler(this.Common_Enter);
            this.AED_PG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.AED_PG.Leave += new System.EventHandler(this.Common_Leave);
            this.AED_PG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CommonMouse_Enter);
            this.AED_PG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CommonMouse_Enter);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(20, 29);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(32, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "BID";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // XAU_BID
            // 
            this.XAU_BID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.XAU_BID.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.XAU_BID.Lines = new string[0];
            this.XAU_BID.Location = new System.Drawing.Point(65, 23);
            this.XAU_BID.MaxLength = 30;
            this.XAU_BID.Name = "XAU_BID";
            this.XAU_BID.PasswordChar = '\0';
            this.XAU_BID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.XAU_BID.SelectedText = "";
            this.XAU_BID.Size = new System.Drawing.Size(100, 30);
            this.XAU_BID.TabIndex = 0;
            this.XAU_BID.UseSelectable = true;
            this.XAU_BID.Click += new System.EventHandler(this.Common_Enter);
            this.XAU_BID.Enter += new System.EventHandler(this.Common_Enter);
            this.XAU_BID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.XAU_BID.Leave += new System.EventHandler(this.Common_Leave);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(178, 29);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "ASK";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.WrapToLine = true;
            // 
            // XAU_ASK
            // 
            this.XAU_ASK.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.XAU_ASK.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.XAU_ASK.Lines = new string[0];
            this.XAU_ASK.Location = new System.Drawing.Point(224, 23);
            this.XAU_ASK.MaxLength = 32767;
            this.XAU_ASK.Name = "XAU_ASK";
            this.XAU_ASK.PasswordChar = '\0';
            this.XAU_ASK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.XAU_ASK.SelectedText = "";
            this.XAU_ASK.Size = new System.Drawing.Size(100, 30);
            this.XAU_ASK.TabIndex = 1;
            this.XAU_ASK.UseSelectable = true;
            this.XAU_ASK.Click += new System.EventHandler(this.Common_Enter);
            this.XAU_ASK.Enter += new System.EventHandler(this.Common_Enter);
            this.XAU_ASK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.XAU_ASK.Leave += new System.EventHandler(this.Common_Leave);
            // 
            // GoldShiftGb
            // 
            this.GoldShiftGb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GoldShiftGb.Controls.Add(this.XAU_ASK);
            this.GoldShiftGb.Controls.Add(this.metroLabel3);
            this.GoldShiftGb.Controls.Add(this.XAU_BID);
            this.GoldShiftGb.Controls.Add(this.metroLabel4);
            this.GoldShiftGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldShiftGb.Location = new System.Drawing.Point(8, 181);
            this.GoldShiftGb.Name = "GoldShiftGb";
            this.GoldShiftGb.Size = new System.Drawing.Size(355, 66);
            this.GoldShiftGb.TabIndex = 2;
            this.GoldShiftGb.TabStop = false;
            this.GoldShiftGb.Text = "Gold Shift";
            // 
            // S_XAU
            // 
            this.S_XAU.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.S_XAU.Lines = new string[0];
            this.S_XAU.Location = new System.Drawing.Point(188, 140);
            this.S_XAU.MaxLength = 32767;
            this.S_XAU.Name = "S_XAU";
            this.S_XAU.PasswordChar = '\0';
            this.S_XAU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.S_XAU.SelectedText = "";
            this.S_XAU.Size = new System.Drawing.Size(144, 30);
            this.S_XAU.TabIndex = 1;
            this.S_XAU.UseSelectable = true;
            this.S_XAU.Click += new System.EventHandler(this.Common_Enter);
            this.S_XAU.Enter += new System.EventHandler(this.Common_Enter);
            this.S_XAU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.S_XAU.Leave += new System.EventHandler(this.Common_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(19, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(32, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "BID";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // MB_XAU
            // 
            this.MB_XAU.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.MB_XAU.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.MB_XAU.Lines = new string[0];
            this.MB_XAU.Location = new System.Drawing.Point(64, 25);
            this.MB_XAU.MaxLength = 30;
            this.MB_XAU.Name = "MB_XAU";
            this.MB_XAU.PasswordChar = '\0';
            this.MB_XAU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MB_XAU.SelectedText = "";
            this.MB_XAU.Size = new System.Drawing.Size(100, 30);
            this.MB_XAU.TabIndex = 0;
            this.MB_XAU.UseSelectable = true;
            this.MB_XAU.Click += new System.EventHandler(this.Common_Enter);
            this.MB_XAU.Enter += new System.EventHandler(this.Common_Enter);
            this.MB_XAU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.MB_XAU.Leave += new System.EventHandler(this.Common_Leave);
            this.MB_XAU.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Common_Enter);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(177, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "ASK";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.WrapToLine = true;
            // 
            // MA_XAU
            // 
            this.MA_XAU.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.MA_XAU.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.MA_XAU.Lines = new string[0];
            this.MA_XAU.Location = new System.Drawing.Point(226, 25);
            this.MA_XAU.MaxLength = 32767;
            this.MA_XAU.Name = "MA_XAU";
            this.MA_XAU.PasswordChar = '\0';
            this.MA_XAU.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MA_XAU.SelectedText = "";
            this.MA_XAU.Size = new System.Drawing.Size(100, 30);
            this.MA_XAU.TabIndex = 1;
            this.MA_XAU.UseSelectable = true;
            this.MA_XAU.Click += new System.EventHandler(this.Common_Enter);
            this.MA_XAU.Enter += new System.EventHandler(this.Common_Enter);
            this.MA_XAU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.MA_XAU.Leave += new System.EventHandler(this.Common_Leave);
            this.MA_XAU.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CommonMouse_Enter);
            // 
            // MG_XAU_Gbox
            // 
            this.MG_XAU_Gbox.BackColor = System.Drawing.Color.MediumTurquoise;
            this.MG_XAU_Gbox.Controls.Add(this.MA_XAU);
            this.MG_XAU_Gbox.Controls.Add(this.metroLabel2);
            this.MG_XAU_Gbox.Controls.Add(this.MB_XAU);
            this.MG_XAU_Gbox.Controls.Add(this.metroLabel1);
            this.MG_XAU_Gbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MG_XAU_Gbox.Location = new System.Drawing.Point(9, 64);
            this.MG_XAU_Gbox.Name = "MG_XAU_Gbox";
            this.MG_XAU_Gbox.Size = new System.Drawing.Size(355, 66);
            this.MG_XAU_Gbox.TabIndex = 0;
            this.MG_XAU_Gbox.TabStop = false;
            this.MG_XAU_Gbox.Text = "Master Gold XAU";
            // 
            // SilverShift
            // 
            this.SilverShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SilverShift.Controls.Add(this.XAG_ASK);
            this.SilverShift.Controls.Add(this.metroLabel13);
            this.SilverShift.Controls.Add(this.XAG_BID);
            this.SilverShift.Controls.Add(this.metroLabel14);
            this.SilverShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SilverShift.Location = new System.Drawing.Point(7, 623);
            this.SilverShift.Name = "SilverShift";
            this.SilverShift.Size = new System.Drawing.Size(355, 66);
            this.SilverShift.TabIndex = 10;
            this.SilverShift.TabStop = false;
            this.SilverShift.Text = "Silver Shift";
            // 
            // XAG_ASK
            // 
            this.XAG_ASK.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.XAG_ASK.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.XAG_ASK.Lines = new string[0];
            this.XAG_ASK.Location = new System.Drawing.Point(228, 24);
            this.XAG_ASK.MaxLength = 32767;
            this.XAG_ASK.Name = "XAG_ASK";
            this.XAG_ASK.PasswordChar = '\0';
            this.XAG_ASK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.XAG_ASK.SelectedText = "";
            this.XAG_ASK.Size = new System.Drawing.Size(100, 30);
            this.XAG_ASK.TabIndex = 1;
            this.XAG_ASK.UseSelectable = true;
            this.XAG_ASK.Click += new System.EventHandler(this.Common_Enter);
            this.XAG_ASK.Enter += new System.EventHandler(this.Common_Enter);
            this.XAG_ASK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.XAG_ASK.Leave += new System.EventHandler(this.Common_Leave);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(179, 28);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(36, 19);
            this.metroLabel13.TabIndex = 0;
            this.metroLabel13.Text = "ASK";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.WrapToLine = true;
            // 
            // XAG_BID
            // 
            this.XAG_BID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.XAG_BID.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.XAG_BID.Lines = new string[0];
            this.XAG_BID.Location = new System.Drawing.Point(66, 24);
            this.XAG_BID.MaxLength = 30;
            this.XAG_BID.Name = "XAG_BID";
            this.XAG_BID.PasswordChar = '\0';
            this.XAG_BID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.XAG_BID.SelectedText = "";
            this.XAG_BID.Size = new System.Drawing.Size(100, 30);
            this.XAG_BID.TabIndex = 0;
            this.XAG_BID.UseSelectable = true;
            this.XAG_BID.Click += new System.EventHandler(this.Common_Enter);
            this.XAG_BID.Enter += new System.EventHandler(this.Common_Enter);
            this.XAG_BID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.XAG_BID.Leave += new System.EventHandler(this.Common_Leave);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(21, 28);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(32, 19);
            this.metroLabel14.TabIndex = 0;
            this.metroLabel14.Text = "BID";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel14.UseCustomBackColor = true;
            // 
            // S_XAG
            // 
            this.S_XAG.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.S_XAG.Lines = new string[0];
            this.S_XAG.Location = new System.Drawing.Point(192, 580);
            this.S_XAG.MaxLength = 32767;
            this.S_XAG.Name = "S_XAG";
            this.S_XAG.PasswordChar = '\0';
            this.S_XAG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.S_XAG.SelectedText = "";
            this.S_XAG.Size = new System.Drawing.Size(143, 30);
            this.S_XAG.TabIndex = 9;
            this.S_XAG.UseSelectable = true;
            this.S_XAG.Click += new System.EventHandler(this.Common_Enter);
            this.S_XAG.Enter += new System.EventHandler(this.Common_Enter);
            this.S_XAG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.S_XAG.Leave += new System.EventHandler(this.Common_Leave);
            // 
            // S_XAG_Label
            // 
            this.S_XAG_Label.AutoSize = true;
            this.S_XAG_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.S_XAG_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.S_XAG_Label.Location = new System.Drawing.Point(20, 580);
            this.S_XAG_Label.Name = "S_XAG_Label";
            this.S_XAG_Label.Size = new System.Drawing.Size(156, 25);
            this.S_XAG_Label.TabIndex = 0;
            this.S_XAG_Label.Text = "Silver Spread Shift";
            this.S_XAG_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.S_XAG_Label.UseCustomBackColor = true;
            // 
            // MasterSliverXAG
            // 
            this.MasterSliverXAG.BackColor = System.Drawing.Color.MediumTurquoise;
            this.MasterSliverXAG.Controls.Add(this.MA_XAG);
            this.MasterSliverXAG.Controls.Add(this.metroLabel16);
            this.MasterSliverXAG.Controls.Add(this.MB_XAG);
            this.MasterSliverXAG.Controls.Add(this.metroLabel17);
            this.MasterSliverXAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterSliverXAG.Location = new System.Drawing.Point(8, 504);
            this.MasterSliverXAG.Name = "MasterSliverXAG";
            this.MasterSliverXAG.Size = new System.Drawing.Size(355, 66);
            this.MasterSliverXAG.TabIndex = 8;
            this.MasterSliverXAG.TabStop = false;
            this.MasterSliverXAG.Text = "Master Silver XAG";
            // 
            // MA_XAG
            // 
            this.MA_XAG.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.MA_XAG.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.MA_XAG.Lines = new string[0];
            this.MA_XAG.Location = new System.Drawing.Point(227, 25);
            this.MA_XAG.MaxLength = 32767;
            this.MA_XAG.Name = "MA_XAG";
            this.MA_XAG.PasswordChar = '\0';
            this.MA_XAG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MA_XAG.SelectedText = "";
            this.MA_XAG.Size = new System.Drawing.Size(100, 30);
            this.MA_XAG.TabIndex = 1;
            this.MA_XAG.UseSelectable = true;
            this.MA_XAG.Click += new System.EventHandler(this.Common_Enter);
            this.MA_XAG.Enter += new System.EventHandler(this.Common_Enter);
            this.MA_XAG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.MA_XAG.Leave += new System.EventHandler(this.Common_Leave);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.Location = new System.Drawing.Point(178, 28);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(36, 19);
            this.metroLabel16.TabIndex = 0;
            this.metroLabel16.Text = "ASK";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel16.UseCustomBackColor = true;
            this.metroLabel16.WrapToLine = true;
            // 
            // MB_XAG
            // 
            this.MB_XAG.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.MB_XAG.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.MB_XAG.Lines = new string[0];
            this.MB_XAG.Location = new System.Drawing.Point(65, 25);
            this.MB_XAG.MaxLength = 30;
            this.MB_XAG.Name = "MB_XAG";
            this.MB_XAG.PasswordChar = '\0';
            this.MB_XAG.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MB_XAG.SelectedText = "";
            this.MB_XAG.Size = new System.Drawing.Size(100, 30);
            this.MB_XAG.TabIndex = 0;
            this.MB_XAG.UseSelectable = true;
            this.MB_XAG.Click += new System.EventHandler(this.Common_Enter);
            this.MB_XAG.Enter += new System.EventHandler(this.Common_Enter);
            this.MB_XAG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Common_KeyPress);
            this.MB_XAG.Leave += new System.EventHandler(this.Common_Leave);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.Location = new System.Drawing.Point(20, 28);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(32, 19);
            this.metroLabel17.TabIndex = 0;
            this.metroLabel17.Text = "BID";
            this.metroLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel17.UseCustomBackColor = true;
            // 
            // S_XAU_Label
            // 
            this.S_XAU_Label.AutoSize = true;
            this.S_XAU_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.S_XAU_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.S_XAU_Label.Location = new System.Drawing.Point(24, 140);
            this.S_XAU_Label.Name = "S_XAU_Label";
            this.S_XAU_Label.Size = new System.Drawing.Size(152, 25);
            this.S_XAU_Label.TabIndex = 0;
            this.S_XAU_Label.Text = "Gold Spread Shift";
            this.S_XAU_Label.UseCustomBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 7000;
            this.timer2.Tick += new System.EventHandler(this.Common_Leave);
            // 
            // hiddenTb
            // 
            this.hiddenTb.Lines = new string[] {
        "metroTextBox1"};
            this.hiddenTb.Location = new System.Drawing.Point(11, 721);
            this.hiddenTb.MaxLength = 32767;
            this.hiddenTb.Name = "hiddenTb";
            this.hiddenTb.PasswordChar = '\0';
            this.hiddenTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hiddenTb.SelectedText = "";
            this.hiddenTb.Size = new System.Drawing.Size(75, 23);
            this.hiddenTb.TabIndex = 0;
            this.hiddenTb.TabStop = false;
            this.hiddenTb.Text = "metroTextBox1";
            this.hiddenTb.UseSelectable = true;
            this.hiddenTb.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Screen.Properties.Resources.MG_Logo_PNG;
            this.pictureBox1.Location = new System.Drawing.Point(7, 695);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // AED_PG_Label
            // 
            this.AED_PG_Label.AutoSize = true;
            this.AED_PG_Label.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AED_PG_Label.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.AED_PG_Label.Location = new System.Drawing.Point(54, 325);
            this.AED_PG_Label.Name = "AED_PG_Label";
            this.AED_PG_Label.Size = new System.Drawing.Size(123, 25);
            this.AED_PG_Label.TabIndex = 0;
            this.AED_PG_Label.Text = "AED Per Gram";
            this.AED_PG_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AED_PG_Label.UseCustomBackColor = true;
            // 
            // TTB_Sign
            // 
            this.TTB_Sign.AutoSize = true;
            this.TTB_Sign.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TTB_Sign.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.TTB_Sign.Location = new System.Drawing.Point(338, 289);
            this.TTB_Sign.Name = "TTB_Sign";
            this.TTB_Sign.Size = new System.Drawing.Size(22, 25);
            this.TTB_Sign.TabIndex = 26;
            this.TTB_Sign.Text = "$";
            this.TTB_Sign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TTB_Sign.UseCustomBackColor = true;
            // 
            // KGB_995_Sign
            // 
            this.KGB_995_Sign.AutoSize = true;
            this.KGB_995_Sign.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.KGB_995_Sign.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.KGB_995_Sign.Location = new System.Drawing.Point(338, 253);
            this.KGB_995_Sign.Name = "KGB_995_Sign";
            this.KGB_995_Sign.Size = new System.Drawing.Size(22, 25);
            this.KGB_995_Sign.TabIndex = 27;
            this.KGB_995_Sign.Text = "$";
            this.KGB_995_Sign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KGB_995_Sign.UseCustomBackColor = true;
            // 
            // S_XAU_Sign
            // 
            this.S_XAU_Sign.AutoSize = true;
            this.S_XAU_Sign.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.S_XAU_Sign.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.S_XAU_Sign.Location = new System.Drawing.Point(338, 140);
            this.S_XAU_Sign.Name = "S_XAU_Sign";
            this.S_XAU_Sign.Size = new System.Drawing.Size(22, 25);
            this.S_XAU_Sign.TabIndex = 28;
            this.S_XAU_Sign.Text = "$";
            this.S_XAU_Sign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.S_XAU_Sign.UseCustomBackColor = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(338, 580);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(22, 25);
            this.metroLabel12.TabIndex = 29;
            this.metroLabel12.Text = "$";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // Screen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 768);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.S_XAU_Sign);
            this.Controls.Add(this.KGB_995_Sign);
            this.Controls.Add(this.TTB_Sign);
            this.Controls.Add(this.hiddenTb);
            this.Controls.Add(this.SilverShift);
            this.Controls.Add(this.GoldShiftGb);
            this.Controls.Add(this.S_XAG);
            this.Controls.Add(this.AED_PG);
            this.Controls.Add(this.S_XAG_Label);
            this.Controls.Add(this.AED_PG_Label);
            this.Controls.Add(this.MasterSliverXAG);
            this.Controls.Add(this.T10_Gbox);
            this.Controls.Add(this.T5_Gbox);
            this.Controls.Add(this.TTB);
            this.Controls.Add(this.TTB_Label);
            this.Controls.Add(this.KGB_995);
            this.Controls.Add(this.KGB_995_Label);
            this.Controls.Add(this.S_XAU);
            this.Controls.Add(this.S_XAU_Label);
            this.Controls.Add(this.MG_XAU_Gbox);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.SQLstatus);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Screen_Form";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StyleManager = this.metroStyleManager1;
            this.Text = "Screen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Screen_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.T5_Gbox.ResumeLayout(false);
            this.T5_Gbox.PerformLayout();
            this.T10_Gbox.ResumeLayout(false);
            this.T10_Gbox.PerformLayout();
            this.GoldShiftGb.ResumeLayout(false);
            this.GoldShiftGb.PerformLayout();
            this.MG_XAU_Gbox.ResumeLayout(false);
            this.MG_XAU_Gbox.PerformLayout();
            this.SilverShift.ResumeLayout(false);
            this.SilverShift.PerformLayout();
            this.MasterSliverXAG.ResumeLayout(false);
            this.MasterSliverXAG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTile SQLstatus;
        private MetroFramework.Controls.MetroButton LogoutBtn;
        private MetroFramework.Controls.MetroTextBox AED_PG;
        private System.Windows.Forms.GroupBox T10_Gbox;
        private MetroFramework.Controls.MetroTextBox T10_995;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox T10_999;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.GroupBox T5_Gbox;
        private MetroFramework.Controls.MetroTextBox T5_995;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox T5_999;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox TTB;
        private MetroFramework.Controls.MetroLabel TTB_Label;
        private MetroFramework.Controls.MetroTextBox KGB_995;
        private MetroFramework.Controls.MetroLabel KGB_995_Label;
        private System.Windows.Forms.GroupBox SilverShift;
        private MetroFramework.Controls.MetroTextBox XAG_ASK;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox XAG_BID;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.GroupBox GoldShiftGb;
        private MetroFramework.Controls.MetroTextBox XAU_ASK;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox XAU_BID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox S_XAG;
        private MetroFramework.Controls.MetroLabel S_XAG_Label;
        private System.Windows.Forms.GroupBox MasterSliverXAG;
        private MetroFramework.Controls.MetroTextBox MA_XAG;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox MB_XAG;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox S_XAU;
        private System.Windows.Forms.GroupBox MG_XAU_Gbox;
        private MetroFramework.Controls.MetroTextBox MA_XAU;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox MB_XAU;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel S_XAU_Label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroTextBox hiddenTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel TTB_Sign;
        private MetroFramework.Controls.MetroLabel AED_PG_Label;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel S_XAU_Sign;
        private MetroFramework.Controls.MetroLabel KGB_995_Sign;
    }
}

