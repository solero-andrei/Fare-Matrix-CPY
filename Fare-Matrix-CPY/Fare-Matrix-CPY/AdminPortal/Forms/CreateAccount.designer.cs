namespace Fare_Matrix_CPY.AdminPortal
{
    partial class CreateAccount
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblHeader = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMiddleName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrowse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbxUserImage = new System.Windows.Forms.PictureBox();
            this.account = new System.Windows.Forms.GroupBox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserImage)).BeginInit();
            this.account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblInstruction);
            this.panel1.Controls.Add(this.lblHeader);
            this.transition.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 64);
            this.panel1.TabIndex = 0;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.transition.SetDecoration(this.lblInstruction, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblInstruction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.ForeColor = System.Drawing.Color.White;
            this.lblInstruction.Location = new System.Drawing.Point(30, 42);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(249, 13);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "&Use your google account to sign up a new account";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.transition.SetDecoration(this.lblHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblHeader.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(24, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(226, 28);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Create a New Account";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 4;
            this.bunifuElipse1.TargetControl = this;
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPanel.Controls.Add(this.lblProcessor);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.btnBack);
            this.mainPanel.Controls.Add(this.btnNext);
            this.mainPanel.Controls.Add(this.btnBrowse);
            this.mainPanel.Controls.Add(this.pbxUserImage);
            this.mainPanel.Controls.Add(this.account);
            this.transition.SetDecoration(this.mainPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(608, 352);
            this.mainPanel.TabIndex = 1;
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.transition.SetDecoration(this.lblProcessor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblProcessor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessor.Location = new System.Drawing.Point(396, 305);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(197, 13);
            this.lblProcessor.TabIndex = 11;
            this.lblProcessor.Text = "Processing your account. Please wait...";
            this.lblProcessor.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMiddleName);
            this.groupBox1.Controls.Add(this.lblMiddleName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.transition.SetDecoration(this.groupBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 151);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtMiddleName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtMiddleName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMiddleName.isPassword = false;
            this.txtMiddleName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMiddleName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtMiddleName.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtMiddleName.LineThickness = 2;
            this.txtMiddleName.Location = new System.Drawing.Point(122, 63);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(207, 25);
            this.txtMiddleName.TabIndex = 15;
            this.txtMiddleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.transition.SetDecoration(this.lblMiddleName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblMiddleName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.ForeColor = System.Drawing.Color.Black;
            this.lblMiddleName.Location = new System.Drawing.Point(27, 68);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(96, 16);
            this.lblMiddleName.TabIndex = 14;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtFirstName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstName.isPassword = false;
            this.txtFirstName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtFirstName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFirstName.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtFirstName.LineThickness = 2;
            this.txtFirstName.Location = new System.Drawing.Point(122, 29);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(207, 25);
            this.txtFirstName.TabIndex = 13;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.transition.SetDecoration(this.lblFirstName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblFirstName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(39, 34);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 16);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtLastName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.isPassword = false;
            this.txtLastName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtLastName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtLastName.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtLastName.LineThickness = 2;
            this.txtLastName.Location = new System.Drawing.Point(122, 97);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(207, 25);
            this.txtLastName.TabIndex = 17;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.transition.SetDecoration(this.lblLastName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblLastName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(40, 102);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 16);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.transition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(392, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 11);
            this.label2.TabIndex = 9;
            this.label2.Text = "(Optional)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.transition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Note: Password must at least have one uppercase and lowercase and alphanumeric va" +
    "lue.";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 7;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.transition.SetDecoration(this.btnBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBack.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnBack.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(391, 267);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Enabled = true;
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnBack.Size = new System.Drawing.Size(102, 35);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 7;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.transition.SetDecoration(this.btnNext, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNext.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnNext.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(496, 267);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Enabled = true;
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.btnNext.Size = new System.Drawing.Size(102, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Activecolor = System.Drawing.Color.CadetBlue;
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.BorderRadius = 3;
            this.btnBrowse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBrowse.ButtonText = "Browse Image";
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.btnBrowse, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBrowse.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowse.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowse.Iconimage = null;
            this.btnBrowse.Iconimage_right = null;
            this.btnBrowse.Iconimage_right_Selected = null;
            this.btnBrowse.Iconimage_Selected = null;
            this.btnBrowse.IconRightVisible = true;
            this.btnBrowse.IconRightZoom = 0D;
            this.btnBrowse.IconVisible = true;
            this.btnBrowse.IconZoom = 90D;
            this.btnBrowse.IsTab = false;
            this.btnBrowse.Location = new System.Drawing.Point(446, 210);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Normalcolor = System.Drawing.Color.White;
            this.btnBrowse.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnBrowse.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowse.selected = false;
            this.btnBrowse.Size = new System.Drawing.Size(91, 21);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse Image";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBrowse.Textcolor = System.Drawing.Color.Black;
            this.btnBrowse.TextFont = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbxUserImage
            // 
            this.transition.SetDecoration(this.pbxUserImage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pbxUserImage.Image = global::Fare_Matrix_CPY.Properties.Resources.account;
            this.pbxUserImage.Location = new System.Drawing.Point(389, 18);
            this.pbxUserImage.Name = "pbxUserImage";
            this.pbxUserImage.Size = new System.Drawing.Size(207, 181);
            this.pbxUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUserImage.TabIndex = 4;
            this.pbxUserImage.TabStop = false;
            // 
            // account
            // 
            this.account.Controls.Add(this.txtUsername);
            this.account.Controls.Add(this.label3);
            this.account.Controls.Add(this.txtEmail);
            this.account.Controls.Add(this.lblEmail);
            this.account.Controls.Add(this.txtConfirmPassword);
            this.account.Controls.Add(this.lblConfirm);
            this.account.Controls.Add(this.txtPassword);
            this.account.Controls.Add(this.lblPassword);
            this.account.Controls.Add(this.pictureBox1);
            this.transition.SetDecoration(this.account, Guna.UI2.AnimatorNS.DecorationType.None);
            this.account.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(12, 163);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(357, 163);
            this.account.TabIndex = 1;
            this.account.TabStop = false;
            this.account.Text = "Account";
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtUsername, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtUsername.LineThickness = 2;
            this.txtUsername.Location = new System.Drawing.Point(130, 119);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(195, 25);
            this.txtUsername.TabIndex = 61;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.transition.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Username:";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtEmail.LineThickness = 2;
            this.txtEmail.Location = new System.Drawing.Point(130, 26);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(195, 25);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.transition.SetDecoration(this.lblEmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(83, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtConfirmPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.isPassword = true;
            this.txtConfirmPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtConfirmPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtConfirmPassword.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtConfirmPassword.LineThickness = 2;
            this.txtConfirmPassword.Location = new System.Drawing.Point(130, 88);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(195, 25);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.transition.SetDecoration(this.lblConfirm, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblConfirm.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.Black;
            this.lblConfirm.Location = new System.Drawing.Point(14, 95);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(116, 15);
            this.lblConfirm.TabIndex = 6;
            this.lblConfirm.Text = "Confirm Password:";
            this.lblConfirm.Click += new System.EventHandler(this.lblConfirm_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtPassword.LineThickness = 2;
            this.txtPassword.Location = new System.Drawing.Point(130, 57);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(195, 25);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.transition.SetDecoration(this.lblPassword, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(54, 65);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.transition.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Fare_Matrix_CPY.Properties.Resources.google;
            this.pictureBox1.Location = new System.Drawing.Point(38, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // transition
            // 
            this.transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.transition.DefaultAnimation = animation1;
            this.transition.Interval = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Jpeg Files(*.jpg)|*.jpg";
            this.openFileDialog1.Title = "Browse Image";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 416);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserImage)).EndInit();
            this.account.ResumeLayout(false);
            this.account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHeader;
        private System.Windows.Forms.Label lblInstruction;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Transition transition;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowse;
        private System.Windows.Forms.PictureBox pbxUserImage;
        private System.Windows.Forms.GroupBox account;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProcessor;
    }
}