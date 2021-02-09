namespace Fare_Matrix_CPY.AdminPortal.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pbxStations = new System.Windows.Forms.PictureBox();
            this.pbxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblAdminFullName = new System.Windows.Forms.Label();
            this.lblAdminNumber = new System.Windows.Forms.Label();
            this.btnSetting = new Bunifu.Framework.UI.BunifuImageButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.listCustomers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listCards = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblClock = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // pbxStations
            // 
            this.pbxStations.Image = ((System.Drawing.Image)(resources.GetObject("pbxStations.Image")));
            this.pbxStations.Location = new System.Drawing.Point(47, 102);
            this.pbxStations.Name = "pbxStations";
            this.pbxStations.Size = new System.Drawing.Size(554, 205);
            this.pbxStations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxStations.TabIndex = 0;
            this.pbxStations.TabStop = false;
            // 
            // pbxProfile
            // 
            this.pbxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pbxProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbxProfile.Image")));
            this.pbxProfile.Location = new System.Drawing.Point(636, 0);
            this.pbxProfile.Name = "pbxProfile";
            this.pbxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbxProfile.ShadowDecoration.Parent = this.pbxProfile;
            this.pbxProfile.Size = new System.Drawing.Size(51, 50);
            this.pbxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProfile.TabIndex = 2;
            this.pbxProfile.TabStop = false;
            // 
            // lblAdminFullName
            // 
            this.lblAdminFullName.AutoSize = true;
            this.lblAdminFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminFullName.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminFullName.ForeColor = System.Drawing.Color.White;
            this.lblAdminFullName.Location = new System.Drawing.Point(693, 9);
            this.lblAdminFullName.Name = "lblAdminFullName";
            this.lblAdminFullName.Size = new System.Drawing.Size(77, 15);
            this.lblAdminFullName.TabIndex = 3;
            this.lblAdminFullName.Text = "Admin Name";
            // 
            // lblAdminNumber
            // 
            this.lblAdminNumber.AutoSize = true;
            this.lblAdminNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminNumber.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminNumber.ForeColor = System.Drawing.Color.White;
            this.lblAdminNumber.Location = new System.Drawing.Point(693, 24);
            this.lblAdminNumber.Name = "lblAdminNumber";
            this.lblAdminNumber.Size = new System.Drawing.Size(77, 15);
            this.lblAdminNumber.TabIndex = 4;
            this.lblAdminNumber.Text = "Admin Number";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageActive = null;
            this.btnSetting.Location = new System.Drawing.Point(903, 643);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(46, 43);
            this.btnSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSetting.TabIndex = 5;
            this.btnSetting.TabStop = false;
            this.btnSetting.Zoom = 7;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPanel.Controls.Add(this.bunifuImageButton1);
            this.mainPanel.Controls.Add(this.lblTime);
            this.mainPanel.Controls.Add(this.lblClock);
            this.mainPanel.Controls.Add(this.listCards);
            this.mainPanel.Controls.Add(this.listCustomers);
            this.mainPanel.Controls.Add(this.btnSetting);
            this.mainPanel.Controls.Add(this.lblAdminNumber);
            this.mainPanel.Controls.Add(this.lblAdminFullName);
            this.mainPanel.Controls.Add(this.pbxProfile);
            this.mainPanel.Controls.Add(this.pbxStations);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(990, 693);
            this.mainPanel.TabIndex = 0;
            // 
            // listCustomers
            // 
            this.listCustomers.CheckBoxes = true;
            this.listCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listCustomers.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCustomers.FullRowSelect = true;
            this.listCustomers.GridLines = true;
            this.listCustomers.Location = new System.Drawing.Point(44, 391);
            this.listCustomers.Name = "listCustomers";
            this.listCustomers.Size = new System.Drawing.Size(555, 245);
            this.listCustomers.TabIndex = 6;
            this.listCustomers.UseCompatibleStateImageBehavior = false;
            this.listCustomers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Route";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Card";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // listCards
            // 
            this.listCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listCards.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCards.FullRowSelect = true;
            this.listCards.GridLines = true;
            this.listCards.Location = new System.Drawing.Point(638, 150);
            this.listCards.Name = "listCards";
            this.listCards.Size = new System.Drawing.Size(311, 486);
            this.listCards.TabIndex = 7;
            this.listCards.UseCompatibleStateImageBehavior = false;
            this.listCards.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Owner";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Expiration";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(44, 668);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(46, 16);
            this.lblClock.TabIndex = 8;
            this.lblClock.Text = "label1";
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(44, 652);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 16);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "label1";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(13, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(49, 48);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 693);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pbxStations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetting)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel mainPanel;
        private Bunifu.Framework.UI.BunifuImageButton btnSetting;
        private System.Windows.Forms.Label lblAdminNumber;
        private System.Windows.Forms.Label lblAdminFullName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxProfile;
        private System.Windows.Forms.PictureBox pbxStations;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.ListView listCards;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView listCustomers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lblTime;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}