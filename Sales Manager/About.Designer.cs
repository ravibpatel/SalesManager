namespace Sales_Manager
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.labelName = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelLicense = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCredits = new System.Windows.Forms.TabPage();
            this.groupBoxCredits = new System.Windows.Forms.GroupBox();
            this.richTextBoxCredits = new System.Windows.Forms.RichTextBox();
            this.tabPageLicense = new System.Windows.Forms.TabPage();
            this.groupBoxLicense = new System.Windows.Forms.GroupBox();
            this.richTextBoxLicense = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSupport = new System.Windows.Forms.Button();
            this.buttonWebsite = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnvatoAPI = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPageCredits.SuspendLayout();
            this.groupBoxCredits.SuspendLayout();
            this.tabPageLicense.SuspendLayout();
            this.groupBoxLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnvatoAPI)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(115, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Location = new System.Drawing.Point(115, 56);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(174, 15);
            this.labelCopyright.TabIndex = 2;
            this.labelCopyright.Text = "Copyright © 2013-2018 RBSoft";
            // 
            // labelLicense
            // 
            this.labelLicense.AutoSize = true;
            this.labelLicense.Location = new System.Drawing.Point(115, 80);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(111, 15);
            this.labelLicense.TabIndex = 3;
            this.labelLicense.Text = "License : Freeware";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageCredits);
            this.tabControl.Controls.Add(this.tabPageLicense);
            this.tabControl.Location = new System.Drawing.Point(12, 185);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(428, 270);
            this.tabControl.TabIndex = 4;
            // 
            // tabPageCredits
            // 
            this.tabPageCredits.Controls.Add(this.groupBoxCredits);
            this.tabPageCredits.Location = new System.Drawing.Point(4, 24);
            this.tabPageCredits.Name = "tabPageCredits";
            this.tabPageCredits.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCredits.Size = new System.Drawing.Size(420, 242);
            this.tabPageCredits.TabIndex = 0;
            this.tabPageCredits.Text = "Credits";
            this.tabPageCredits.UseVisualStyleBackColor = true;
            // 
            // groupBoxCredits
            // 
            this.groupBoxCredits.Controls.Add(this.richTextBoxCredits);
            this.groupBoxCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCredits.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCredits.Name = "groupBoxCredits";
            this.groupBoxCredits.Size = new System.Drawing.Size(414, 236);
            this.groupBoxCredits.TabIndex = 0;
            this.groupBoxCredits.TabStop = false;
            // 
            // richTextBoxCredits
            // 
            this.richTextBoxCredits.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxCredits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCredits.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxCredits.Name = "richTextBoxCredits";
            this.richTextBoxCredits.ReadOnly = true;
            this.richTextBoxCredits.Size = new System.Drawing.Size(408, 216);
            this.richTextBoxCredits.TabIndex = 0;
            this.richTextBoxCredits.Text = resources.GetString("richTextBoxCredits.Text");
            this.richTextBoxCredits.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxCredits_LinkClicked);
            // 
            // tabPageLicense
            // 
            this.tabPageLicense.Controls.Add(this.groupBoxLicense);
            this.tabPageLicense.Location = new System.Drawing.Point(4, 24);
            this.tabPageLicense.Name = "tabPageLicense";
            this.tabPageLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLicense.Size = new System.Drawing.Size(420, 242);
            this.tabPageLicense.TabIndex = 1;
            this.tabPageLicense.Text = "License";
            this.tabPageLicense.UseVisualStyleBackColor = true;
            // 
            // groupBoxLicense
            // 
            this.groupBoxLicense.Controls.Add(this.richTextBoxLicense);
            this.groupBoxLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLicense.Location = new System.Drawing.Point(3, 3);
            this.groupBoxLicense.Name = "groupBoxLicense";
            this.groupBoxLicense.Size = new System.Drawing.Size(414, 236);
            this.groupBoxLicense.TabIndex = 1;
            this.groupBoxLicense.TabStop = false;
            // 
            // richTextBoxLicense
            // 
            this.richTextBoxLicense.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLicense.Location = new System.Drawing.Point(3, 17);
            this.richTextBoxLicense.Name = "richTextBoxLicense";
            this.richTextBoxLicense.ReadOnly = true;
            this.richTextBoxLicense.Size = new System.Drawing.Size(408, 216);
            this.richTextBoxLicense.TabIndex = 1;
            this.richTextBoxLicense.Text = resources.GetString("richTextBoxLicense.Text");
            this.richTextBoxLicense.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxCredits_LinkClicked);
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Image = global::Sales_Manager.Properties.Resources.cross;
            this.buttonClose.Location = new System.Drawing.Point(352, 461);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(88, 30);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonSupport
            // 
            this.buttonSupport.Image = global::Sales_Manager.Properties.Resources.comment_box;
            this.buttonSupport.Location = new System.Drawing.Point(106, 461);
            this.buttonSupport.Name = "buttonSupport";
            this.buttonSupport.Size = new System.Drawing.Size(88, 30);
            this.buttonSupport.TabIndex = 6;
            this.buttonSupport.Text = "Support";
            this.buttonSupport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSupport.UseVisualStyleBackColor = true;
            this.buttonSupport.Click += new System.EventHandler(this.buttonForum_Click);
            // 
            // buttonWebsite
            // 
            this.buttonWebsite.Image = global::Sales_Manager.Properties.Resources.home_page;
            this.buttonWebsite.Location = new System.Drawing.Point(12, 461);
            this.buttonWebsite.Name = "buttonWebsite";
            this.buttonWebsite.Size = new System.Drawing.Size(88, 30);
            this.buttonWebsite.TabIndex = 5;
            this.buttonWebsite.Text = "Website";
            this.buttonWebsite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonWebsite.UseVisualStyleBackColor = true;
            this.buttonWebsite.Click += new System.EventHandler(this.buttonWebsite_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::Sales_Manager.Properties.Resources.Sales_Manager_Icon;
            this.pictureBoxIcon.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(96, 96);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // pictureBoxEnvatoAPI
            // 
            this.pictureBoxEnvatoAPI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEnvatoAPI.Image = global::Sales_Manager.Properties.Resources.envato_market_api;
            this.pictureBoxEnvatoAPI.Location = new System.Drawing.Point(12, 114);
            this.pictureBoxEnvatoAPI.Name = "pictureBoxEnvatoAPI";
            this.pictureBoxEnvatoAPI.Size = new System.Drawing.Size(428, 65);
            this.pictureBoxEnvatoAPI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxEnvatoAPI.TabIndex = 8;
            this.pictureBoxEnvatoAPI.TabStop = false;
            this.pictureBoxEnvatoAPI.Click += new System.EventHandler(this.pictureBoxEnvatoAPI_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(452, 503);
            this.Controls.Add(this.pictureBoxEnvatoAPI);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSupport);
            this.Controls.Add(this.buttonWebsite);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxIcon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageCredits.ResumeLayout(false);
            this.groupBoxCredits.ResumeLayout(false);
            this.tabPageLicense.ResumeLayout(false);
            this.groupBoxLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnvatoAPI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TabPage tabPageCredits;
        public System.Windows.Forms.TabPage tabPageLicense;
        private System.Windows.Forms.GroupBox groupBoxCredits;
        private System.Windows.Forms.GroupBox groupBoxLicense;
        private System.Windows.Forms.RichTextBox richTextBoxCredits;
        private System.Windows.Forms.RichTextBox richTextBoxLicense;
        public System.Windows.Forms.Button buttonWebsite;
        public System.Windows.Forms.Button buttonSupport;
        public System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBoxEnvatoAPI;
    }
}
