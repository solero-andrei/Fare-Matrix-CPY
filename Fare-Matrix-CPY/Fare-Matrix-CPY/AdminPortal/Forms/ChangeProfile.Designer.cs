namespace Fare_Matrix_CPY.AdminPortal
{
    partial class ChangeProfile
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.lnkUpdatePhoto = new System.Windows.Forms.LinkLabel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditProfilePhoto = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDeactivate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditProfile = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbxProfilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditProfilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Browse Profile Image";
            this.openFileDialog1.Filter = "Jpeg Files(*.jpg)|*.jpg|Png Files(*.png)|*.png";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.lblAccountID);
            this.bodyPanel.Controls.Add(this.label4);
            this.bodyPanel.Controls.Add(this.lnkUpdatePhoto);
            this.bodyPanel.Controls.Add(this.lblUserID);
            this.bodyPanel.Controls.Add(this.label7);
            this.bodyPanel.Controls.Add(this.btnEditProfilePhoto);
            this.bodyPanel.Controls.Add(this.btnClose);
            this.bodyPanel.Controls.Add(this.btnDeactivate);
            this.bodyPanel.Controls.Add(this.lblEmail);
            this.bodyPanel.Controls.Add(this.label5);
            this.bodyPanel.Controls.Add(this.lblUsername);
            this.bodyPanel.Controls.Add(this.label2);
            this.bodyPanel.Controls.Add(this.label1);
            this.bodyPanel.Controls.Add(this.btnEditProfile);
            this.bodyPanel.Controls.Add(this.pbxProfilePicture);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(715, 636);
            this.bodyPanel.TabIndex = 0;
            // 
            // lnkUpdatePhoto
            // 
            this.lnkUpdatePhoto.AutoSize = true;
            this.lnkUpdatePhoto.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUpdatePhoto.Location = new System.Drawing.Point(435, 276);
            this.lnkUpdatePhoto.Name = "lnkUpdatePhoto";
            this.lnkUpdatePhoto.Size = new System.Drawing.Size(72, 15);
            this.lnkUpdatePhoto.TabIndex = 28;
            this.lnkUpdatePhoto.TabStop = true;
            this.lnkUpdatePhoto.Text = "Save Photo";
            this.lnkUpdatePhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdatePhoto_LinkClicked);
            // 
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(176, 310);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(363, 15);
            this.lblUserID.TabIndex = 27;
            this.lblUserID.Text = "--";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "User ID:";
            // 
            // btnEditProfilePhoto
            // 
            this.btnEditProfilePhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnEditProfilePhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProfilePhoto.Image = global::Fare_Matrix_CPY.Properties.Resources.Action_edit_add_icon;
            this.btnEditProfilePhoto.ImageActive = null;
            this.btnEditProfilePhoto.Location = new System.Drawing.Point(399, 264);
            this.btnEditProfilePhoto.Name = "btnEditProfilePhoto";
            this.btnEditProfilePhoto.Size = new System.Drawing.Size(30, 25);
            this.btnEditProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEditProfilePhoto.TabIndex = 24;
            this.btnEditProfilePhoto.TabStop = false;
            this.btnEditProfilePhoto.Zoom = 10;
            this.btnEditProfilePhoto.Click += new System.EventHandler(this.btnEditProfilePhoto_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Fare_Matrix_CPY.Properties.Resources.cancel;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(652, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 25;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Activecolor = System.Drawing.Color.Teal;
            this.btnDeactivate.BackColor = System.Drawing.Color.Teal;
            this.btnDeactivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeactivate.BorderRadius = 7;
            this.btnDeactivate.ButtonText = "Deactivate";
            this.btnDeactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeactivate.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeactivate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeactivate.Iconimage = null;
            this.btnDeactivate.Iconimage_right = null;
            this.btnDeactivate.Iconimage_right_Selected = null;
            this.btnDeactivate.Iconimage_Selected = null;
            this.btnDeactivate.IconRightVisible = true;
            this.btnDeactivate.IconRightZoom = 0D;
            this.btnDeactivate.IconVisible = true;
            this.btnDeactivate.IconZoom = 90D;
            this.btnDeactivate.IsTab = false;
            this.btnDeactivate.Location = new System.Drawing.Point(244, 513);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Normalcolor = System.Drawing.Color.Teal;
            this.btnDeactivate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnDeactivate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeactivate.selected = false;
            this.btnDeactivate.Size = new System.Drawing.Size(227, 50);
            this.btnDeactivate.TabIndex = 23;
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeactivate.Textcolor = System.Drawing.Color.White;
            this.btnDeactivate.TextFont = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click_1);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(176, 426);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(363, 16);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "--";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email:";
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(176, 383);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(363, 15);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "--";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Change your profile";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Activecolor = System.Drawing.Color.Teal;
            this.btnEditProfile.BackColor = System.Drawing.Color.Teal;
            this.btnEditProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditProfile.BorderRadius = 7;
            this.btnEditProfile.ButtonText = "Edit Profile";
            this.btnEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProfile.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditProfile.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditProfile.Iconimage = null;
            this.btnEditProfile.Iconimage_right = null;
            this.btnEditProfile.Iconimage_right_Selected = null;
            this.btnEditProfile.Iconimage_Selected = null;
            this.btnEditProfile.IconRightVisible = true;
            this.btnEditProfile.IconRightZoom = 0D;
            this.btnEditProfile.IconVisible = true;
            this.btnEditProfile.IconZoom = 90D;
            this.btnEditProfile.IsTab = false;
            this.btnEditProfile.Location = new System.Drawing.Point(244, 457);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Normalcolor = System.Drawing.Color.Teal;
            this.btnEditProfile.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnEditProfile.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditProfile.selected = false;
            this.btnEditProfile.Size = new System.Drawing.Size(227, 50);
            this.btnEditProfile.TabIndex = 17;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditProfile.Textcolor = System.Drawing.Color.White;
            this.btnEditProfile.TextFont = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click_1);
            // 
            // pbxProfilePicture
            // 
            this.pbxProfilePicture.Image = global::Fare_Matrix_CPY.Properties.Resources.account;
            this.pbxProfilePicture.Location = new System.Drawing.Point(286, 158);
            this.pbxProfilePicture.Name = "pbxProfilePicture";
            this.pbxProfilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxProfilePicture.ShadowDecoration.Parent = this.pbxProfilePicture;
            this.pbxProfilePicture.Size = new System.Drawing.Size(143, 131);
            this.pbxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProfilePicture.TabIndex = 16;
            this.pbxProfilePicture.TabStop = false;
            // 
            // lblAccountID
            // 
            this.lblAccountID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountID.Location = new System.Drawing.Point(176, 346);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(363, 15);
            this.lblAccountID.TabIndex = 30;
            this.lblAccountID.Text = "--";
            this.lblAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Account ID:";
            // 
            // ChangeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bodyPanel);
            this.Name = "ChangeProfile";
            this.Size = new System.Drawing.Size(715, 636);
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditProfilePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel bodyPanel;
        private Bunifu.Framework.UI.BunifuImageButton btnEditProfilePhoto;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeactivate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditProfile;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxProfilePicture;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lnkUpdatePhoto;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label label4;
    }
}
