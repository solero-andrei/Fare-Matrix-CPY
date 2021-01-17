namespace Fare_Matrix_CPY.AdminPortal
{
    partial class Verification
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verification));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVerify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtVerificationCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWatermark = new System.Windows.Forms.Label();
            this.lblUserGmail = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.transition = new Guna.UI2.WinForms.Guna2Transition();
            this.createAccountPassword1 = new Fare_Matrix_CPY.AdminPortal.CreateAccountPassword();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.createAccountPassword1);
            this.mainPanel.Controls.Add(this.btnBack);
            this.mainPanel.Controls.Add(this.btnVerify);
            this.mainPanel.Controls.Add(this.txtVerificationCode);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.lblWatermark);
            this.mainPanel.Controls.Add(this.lblUserGmail);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.transition.SetDecoration(this.mainPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(572, 331);
            this.mainPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Activecolor = System.Drawing.Color.Teal;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.BorderRadius = 0;
            this.btnBack.ButtonText = "Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.btnBack, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBack.DisabledColor = System.Drawing.Color.Gray;
            this.btnBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBack.Iconimage = null;
            this.btnBack.Iconimage_right = null;
            this.btnBack.Iconimage_right_Selected = null;
            this.btnBack.Iconimage_Selected = null;
            this.btnBack.IconRightVisible = true;
            this.btnBack.IconRightZoom = 0D;
            this.btnBack.IconVisible = true;
            this.btnBack.IconZoom = 90D;
            this.btnBack.IsTab = false;
            this.btnBack.Location = new System.Drawing.Point(65, 196);
            this.btnBack.Name = "btnBack";
            this.btnBack.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBack.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnBack.OnHoverTextColor = System.Drawing.Color.Teal;
            this.btnBack.selected = false;
            this.btnBack.Size = new System.Drawing.Size(127, 48);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Textcolor = System.Drawing.Color.Teal;
            this.btnBack.TextFont = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Activecolor = System.Drawing.Color.Teal;
            this.btnVerify.BackColor = System.Drawing.Color.Teal;
            this.btnVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerify.BorderRadius = 0;
            this.btnVerify.ButtonText = "Verify";
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.btnVerify, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnVerify.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerify.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerify.Iconimage = null;
            this.btnVerify.Iconimage_right = null;
            this.btnVerify.Iconimage_right_Selected = null;
            this.btnVerify.Iconimage_Selected = null;
            this.btnVerify.IconRightVisible = true;
            this.btnVerify.IconRightZoom = 0D;
            this.btnVerify.IconVisible = true;
            this.btnVerify.IconZoom = 90D;
            this.btnVerify.IsTab = false;
            this.btnVerify.Location = new System.Drawing.Point(380, 196);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Normalcolor = System.Drawing.Color.Teal;
            this.btnVerify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnVerify.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerify.selected = false;
            this.btnVerify.Size = new System.Drawing.Size(127, 48);
            this.btnVerify.TabIndex = 21;
            this.btnVerify.Text = "Verify";
            this.btnVerify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerify.Textcolor = System.Drawing.Color.White;
            this.btnVerify.TextFont = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transition.SetDecoration(this.txtVerificationCode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtVerificationCode.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificationCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVerificationCode.isPassword = false;
            this.txtVerificationCode.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtVerificationCode.LineIdleColor = System.Drawing.Color.Gray;
            this.txtVerificationCode.LineMouseHoverColor = System.Drawing.Color.CadetBlue;
            this.txtVerificationCode.LineThickness = 2;
            this.txtVerificationCode.Location = new System.Drawing.Point(81, 144);
            this.txtVerificationCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.Size = new System.Drawing.Size(410, 44);
            this.txtVerificationCode.TabIndex = 20;
            this.txtVerificationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.transition.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(124, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Verify your email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.transition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(210, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "We send a 6 digit code to";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWatermark
            // 
            this.lblWatermark.AutoSize = true;
            this.transition.SetDecoration(this.lblWatermark, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblWatermark.Font = new System.Drawing.Font("MS Reference Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatermark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.lblWatermark.Location = new System.Drawing.Point(-9, 215);
            this.lblWatermark.Name = "lblWatermark";
            this.lblWatermark.Size = new System.Drawing.Size(390, 118);
            this.lblWatermark.TabIndex = 18;
            this.lblWatermark.Text = "Google";
            // 
            // lblUserGmail
            // 
            this.transition.SetDecoration(this.lblUserGmail, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblUserGmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserGmail.ForeColor = System.Drawing.Color.Black;
            this.lblUserGmail.Location = new System.Drawing.Point(91, 125);
            this.lblUserGmail.Name = "lblUserGmail";
            this.lblUserGmail.Size = new System.Drawing.Size(390, 17);
            this.lblUserGmail.TabIndex = 25;
            this.lblUserGmail.Text = "- - -";
            this.lblUserGmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.transition.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Fare_Matrix_CPY.Properties.Resources.google;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 4;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 6;
            this.bunifuElipse2.TargetControl = this.btnVerify;
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
            this.transition.Interval = 3;
            // 
            // createAccountPassword1
            // 
            this.createAccountPassword1.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.createAccountPassword1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.createAccountPassword1.Location = new System.Drawing.Point(0, 0);
            this.createAccountPassword1.Name = "createAccountPassword1";
            this.createAccountPassword1.Size = new System.Drawing.Size(572, 331);
            this.createAccountPassword1.TabIndex = 26;
            this.createAccountPassword1.Visible = false;
            // 
            // Verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name = "Verification";
            this.Size = new System.Drawing.Size(572, 331);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnBack;
        private Guna.UI2.WinForms.Guna2Transition transition;
        private Bunifu.Framework.UI.BunifuFlatButton btnVerify;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtVerificationCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWatermark;
        private System.Windows.Forms.Label lblUserGmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private CreateAccountPassword createAccountPassword1;
    }
}
