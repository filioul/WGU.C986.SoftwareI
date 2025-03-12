
namespace WGU.C986
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
            this.labelMin = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelInventory = new System.Windows.Forms.Label();
            this.textBoxInventory = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.lblAddProductHeader = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.labelCandidateParts = new System.Windows.Forms.Label();
            this.listBoxCandidate = new System.Windows.Forms.ListBox();
            this.searchButtonProducts = new System.Windows.Forms.Button();
            this.searchBoxProducts = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.labelAssociatedParts = new System.Windows.Forms.Label();
            this.listBoxAssociated = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMin.Location = new System.Drawing.Point(202, 408);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(33, 19);
            this.labelMin.TabIndex = 26;
            this.labelMin.Text = "Min";
            // 
            // textBoxMin
            // 
            this.textBoxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxMin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMin.Location = new System.Drawing.Point(255, 405);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(69, 25);
            this.textBoxMin.TabIndex = 25;
            this.textBoxMin.TextChanged += new System.EventHandler(this.textBoxMin_TextChanged);
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMax.Location = new System.Drawing.Point(51, 408);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(35, 19);
            this.labelMax.TabIndex = 24;
            this.labelMax.Text = "Max";
            // 
            // textBoxMax
            // 
            this.textBoxMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxMax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMax.Location = new System.Drawing.Point(106, 405);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(69, 25);
            this.textBoxMax.TabIndex = 23;
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBoxMax_TextChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(51, 362);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(38, 19);
            this.labelPrice.TabIndex = 22;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrice.Location = new System.Drawing.Point(143, 359);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(138, 25);
            this.textBoxPrice.TabIndex = 21;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInventory.Location = new System.Drawing.Point(51, 317);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(68, 19);
            this.labelInventory.TabIndex = 20;
            this.labelInventory.Text = "Inventory";
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInventory.Location = new System.Drawing.Point(143, 314);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(138, 25);
            this.textBoxInventory.TabIndex = 19;
            this.textBoxInventory.TextChanged += new System.EventHandler(this.textBoxInventory_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(51, 271);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 19);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(144, 267);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(138, 25);
            this.textBoxName.TabIndex = 17;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(51, 223);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 19);
            this.labelID.TabIndex = 16;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(143, 220);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(138, 25);
            this.textBoxID.TabIndex = 15;
            // 
            // lblAddProductHeader
            // 
            this.lblAddProductHeader.AutoSize = true;
            this.lblAddProductHeader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddProductHeader.Location = new System.Drawing.Point(40, 46);
            this.lblAddProductHeader.Name = "lblAddProductHeader";
            this.lblAddProductHeader.Size = new System.Drawing.Size(113, 25);
            this.lblAddProductHeader.TabIndex = 27;
            this.lblAddProductHeader.Text = "Add Product";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(822, 270);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(62, 31);
            this.addButton.TabIndex = 33;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // labelCandidateParts
            // 
            this.labelCandidateParts.AutoSize = true;
            this.labelCandidateParts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCandidateParts.Location = new System.Drawing.Point(418, 86);
            this.labelCandidateParts.Name = "labelCandidateParts";
            this.labelCandidateParts.Size = new System.Drawing.Size(122, 19);
            this.labelCandidateParts.TabIndex = 31;
            this.labelCandidateParts.Text = "All candidate Parts";
            // 
            // listBoxCandidate
            // 
            this.listBoxCandidate.FormattingEnabled = true;
            this.listBoxCandidate.ItemHeight = 15;
            this.listBoxCandidate.Location = new System.Drawing.Point(418, 108);
            this.listBoxCandidate.Name = "listBoxCandidate";
            this.listBoxCandidate.Size = new System.Drawing.Size(487, 139);
            this.listBoxCandidate.TabIndex = 30;
            // 
            // searchButtonProducts
            // 
            this.searchButtonProducts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButtonProducts.Location = new System.Drawing.Point(599, 50);
            this.searchButtonProducts.Name = "searchButtonProducts";
            this.searchButtonProducts.Size = new System.Drawing.Size(58, 23);
            this.searchButtonProducts.TabIndex = 29;
            this.searchButtonProducts.Text = "Search";
            this.searchButtonProducts.UseVisualStyleBackColor = true;
            // 
            // searchBoxProducts
            // 
            this.searchBoxProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBoxProducts.Location = new System.Drawing.Point(663, 49);
            this.searchBoxProducts.Name = "searchBoxProducts";
            this.searchBoxProducts.Size = new System.Drawing.Size(242, 25);
            this.searchBoxProducts.TabIndex = 28;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(822, 496);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(62, 31);
            this.deleteButton.TabIndex = 36;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // labelAssociatedParts
            // 
            this.labelAssociatedParts.AutoSize = true;
            this.labelAssociatedParts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAssociatedParts.Location = new System.Drawing.Point(418, 306);
            this.labelAssociatedParts.Name = "labelAssociatedParts";
            this.labelAssociatedParts.Size = new System.Drawing.Size(215, 19);
            this.labelAssociatedParts.TabIndex = 35;
            this.labelAssociatedParts.Text = "Parts associated with this Product";
            // 
            // listBoxAssociated
            // 
            this.listBoxAssociated.FormattingEnabled = true;
            this.listBoxAssociated.ItemHeight = 15;
            this.listBoxAssociated.Location = new System.Drawing.Point(418, 328);
            this.listBoxAssociated.Name = "listBoxAssociated";
            this.listBoxAssociated.Size = new System.Drawing.Size(487, 139);
            this.listBoxAssociated.TabIndex = 34;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(822, 568);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(62, 31);
            this.cancelButton.TabIndex = 37;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(722, 568);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(62, 31);
            this.buttonSave.TabIndex = 38;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1014, 637);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.labelAssociatedParts);
            this.Controls.Add(this.listBoxAssociated);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.labelCandidateParts);
            this.Controls.Add(this.listBoxCandidate);
            this.Controls.Add(this.searchButtonProducts);
            this.Controls.Add(this.searchBoxProducts);
            this.Controls.Add(this.lblAddProductHeader);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.textBoxInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Name = "AddProduct";
            this.Text = "Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.TextBox textBoxInventory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label lblAddProductHeader;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label labelCandidateParts;
        private System.Windows.Forms.ListBox listBoxCandidate;
        private System.Windows.Forms.Button searchButtonProducts;
        private System.Windows.Forms.TextBox searchBoxProducts;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label labelAssociatedParts;
        private System.Windows.Forms.ListBox listBoxAssociated;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button buttonSave;
    }
}