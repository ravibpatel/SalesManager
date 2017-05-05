namespace Sales_Manager
{
    partial class AddProduct
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
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAuthorFee = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBuyerFee = new System.Windows.Forms.NumericUpDown();
            this.labelAuthorFee = new System.Windows.Forms.Label();
            this.labelBuyerFee = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelPartnerShare = new System.Windows.Forms.Label();
            this.numericUpDownPartnerShare = new System.Windows.Forms.NumericUpDown();
            this.labelID = new System.Windows.Forms.Label();
            this.numericUpDownID = new System.Windows.Forms.NumericUpDown();
            this.textBoxPartnerName = new System.Windows.Forms.TextBox();
            this.labelPartnerName = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAuthorFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuyerFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPartnerShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(90, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(296, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 55);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(90, 53);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(296, 20);
            this.numericUpDownPrice.TabIndex = 1;
            // 
            // numericUpDownAuthorFee
            // 
            this.numericUpDownAuthorFee.DecimalPlaces = 2;
            this.numericUpDownAuthorFee.Location = new System.Drawing.Point(90, 79);
            this.numericUpDownAuthorFee.Name = "numericUpDownAuthorFee";
            this.numericUpDownAuthorFee.Size = new System.Drawing.Size(296, 20);
            this.numericUpDownAuthorFee.TabIndex = 2;
            // 
            // numericUpDownBuyerFee
            // 
            this.numericUpDownBuyerFee.DecimalPlaces = 2;
            this.numericUpDownBuyerFee.Location = new System.Drawing.Point(90, 105);
            this.numericUpDownBuyerFee.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numericUpDownBuyerFee.Name = "numericUpDownBuyerFee";
            this.numericUpDownBuyerFee.Size = new System.Drawing.Size(296, 20);
            this.numericUpDownBuyerFee.TabIndex = 3;
            // 
            // labelAuthorFee
            // 
            this.labelAuthorFee.AutoSize = true;
            this.labelAuthorFee.Location = new System.Drawing.Point(12, 81);
            this.labelAuthorFee.Name = "labelAuthorFee";
            this.labelAuthorFee.Size = new System.Drawing.Size(59, 13);
            this.labelAuthorFee.TabIndex = 6;
            this.labelAuthorFee.Text = "Author Fee";
            // 
            // labelBuyerFee
            // 
            this.labelBuyerFee.AutoSize = true;
            this.labelBuyerFee.Location = new System.Drawing.Point(12, 107);
            this.labelBuyerFee.Name = "labelBuyerFee";
            this.labelBuyerFee.Size = new System.Drawing.Size(55, 13);
            this.labelBuyerFee.TabIndex = 7;
            this.labelBuyerFee.Text = "Buyer Fee";
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(230, 209);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Add";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(311, 209);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelPartnerShare
            // 
            this.labelPartnerShare.AutoSize = true;
            this.labelPartnerShare.Location = new System.Drawing.Point(12, 133);
            this.labelPartnerShare.Name = "labelPartnerShare";
            this.labelPartnerShare.Size = new System.Drawing.Size(72, 13);
            this.labelPartnerShare.TabIndex = 10;
            this.labelPartnerShare.Text = "Partner Share";
            // 
            // numericUpDownPartnerShare
            // 
            this.numericUpDownPartnerShare.DecimalPlaces = 2;
            this.numericUpDownPartnerShare.Location = new System.Drawing.Point(90, 131);
            this.numericUpDownPartnerShare.Name = "numericUpDownPartnerShare";
            this.numericUpDownPartnerShare.Size = new System.Drawing.Size(296, 20);
            this.numericUpDownPartnerShare.TabIndex = 4;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 159);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 12;
            this.labelID.Text = "ID";
            // 
            // numericUpDownID
            // 
            this.numericUpDownID.Location = new System.Drawing.Point(90, 157);
            this.numericUpDownID.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.numericUpDownID.Name = "numericUpDownID";
            this.numericUpDownID.Size = new System.Drawing.Size(296, 20);
            this.numericUpDownID.TabIndex = 5;
            // 
            // textBoxPartnerName
            // 
            this.textBoxPartnerName.Location = new System.Drawing.Point(90, 183);
            this.textBoxPartnerName.Name = "textBoxPartnerName";
            this.textBoxPartnerName.Size = new System.Drawing.Size(296, 20);
            this.textBoxPartnerName.TabIndex = 13;
            // 
            // labelPartnerName
            // 
            this.labelPartnerName.AutoSize = true;
            this.labelPartnerName.Location = new System.Drawing.Point(12, 186);
            this.labelPartnerName.Name = "labelPartnerName";
            this.labelPartnerName.Size = new System.Drawing.Size(72, 13);
            this.labelPartnerName.TabIndex = 14;
            this.labelPartnerName.Text = "Partner Name";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(412, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.Image = global::Sales_Manager.Properties.Resources.book;
            this.helpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // AddProduct
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(412, 244);
            this.Controls.Add(this.labelPartnerName);
            this.Controls.Add(this.textBoxPartnerName);
            this.Controls.Add(this.numericUpDownID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.numericUpDownPartnerShare);
            this.Controls.Add(this.labelPartnerShare);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelBuyerFee);
            this.Controls.Add(this.labelAuthorFee);
            this.Controls.Add(this.numericUpDownBuyerFee);
            this.Controls.Add(this.numericUpDownAuthorFee);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAuthorFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuyerFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPartnerShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownAuthorFee;
        private System.Windows.Forms.NumericUpDown numericUpDownBuyerFee;
        private System.Windows.Forms.Label labelAuthorFee;
        private System.Windows.Forms.Label labelBuyerFee;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown numericUpDownPartnerShare;
        private System.Windows.Forms.Label labelPartnerShare;
        private System.Windows.Forms.NumericUpDown numericUpDownID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPartnerName;
        private System.Windows.Forms.TextBox textBoxPartnerName;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}