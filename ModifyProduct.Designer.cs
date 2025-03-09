
namespace WGU.C986
{
    partial class ModifyProduct
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.labelAssociatedParts = new System.Windows.Forms.Label();
            this.listBoxAssociated = new System.Windows.Forms.ListBox();
            this.addButtonProducts = new System.Windows.Forms.Button();
            this.labelCandidateParts = new System.Windows.Forms.Label();
            this.listBoxCandidate = new System.Windows.Forms.ListBox();
            this.searchButtonProducts = new System.Windows.Forms.Button();
            this.searchBoxProducts = new System.Windows.Forms.TextBox();
            this.lblModifyProductHeader = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(717, 569);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(62, 31);
            this.saveButton.TabIndex = 61;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(817, 569);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(62, 31);
            this.cancelButton.TabIndex = 60;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(817, 497);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(62, 31);
            this.deleteButton.TabIndex = 59;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // labelAssociatedParts
            // 
            this.labelAssociatedParts.AutoSize = true;
            this.labelAssociatedParts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAssociatedParts.Location = new System.Drawing.Point(413, 307);
            this.labelAssociatedParts.Name = "labelAssociatedParts";
            this.labelAssociatedParts.Size = new System.Drawing.Size(215, 19);
            this.labelAssociatedParts.TabIndex = 58;
            this.labelAssociatedParts.Text = "Parts associated with this Product";
            // 
            // listBoxAssociated
            // 
            this.listBoxAssociated.FormattingEnabled = true;
            this.listBoxAssociated.ItemHeight = 15;
            this.listBoxAssociated.Location = new System.Drawing.Point(413, 329);
            this.listBoxAssociated.Name = "listBoxAssociated";
            this.listBoxAssociated.Size = new System.Drawing.Size(487, 139);
            this.listBoxAssociated.TabIndex = 57;
            // 
            // addButtonProducts
            // 
            this.addButtonProducts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButtonProducts.Location = new System.Drawing.Point(817, 271);
            this.addButtonProducts.Name = "addButtonProducts";
            this.addButtonProducts.Size = new System.Drawing.Size(62, 31);
            this.addButtonProducts.TabIndex = 56;
            this.addButtonProducts.Text = "Add";
            this.addButtonProducts.UseVisualStyleBackColor = true;
            // 
            // labelCandidateParts
            // 
            this.labelCandidateParts.AutoSize = true;
            this.labelCandidateParts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCandidateParts.Location = new System.Drawing.Point(413, 87);
            this.labelCandidateParts.Name = "labelCandidateParts";
            this.labelCandidateParts.Size = new System.Drawing.Size(122, 19);
            this.labelCandidateParts.TabIndex = 55;
            this.labelCandidateParts.Text = "All candidate Parts";
            // 
            // listBoxCandidate
            // 
            this.listBoxCandidate.FormattingEnabled = true;
            this.listBoxCandidate.ItemHeight = 15;
            this.listBoxCandidate.Location = new System.Drawing.Point(413, 109);
            this.listBoxCandidate.Name = "listBoxCandidate";
            this.listBoxCandidate.Size = new System.Drawing.Size(487, 139);
            this.listBoxCandidate.TabIndex = 54;
            // 
            // searchButtonProducts
            // 
            this.searchButtonProducts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButtonProducts.Location = new System.Drawing.Point(594, 51);
            this.searchButtonProducts.Name = "searchButtonProducts";
            this.searchButtonProducts.Size = new System.Drawing.Size(58, 23);
            this.searchButtonProducts.TabIndex = 53;
            this.searchButtonProducts.Text = "Search";
            this.searchButtonProducts.UseVisualStyleBackColor = true;
            // 
            // searchBoxProducts
            // 
            this.searchBoxProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBoxProducts.Location = new System.Drawing.Point(658, 50);
            this.searchBoxProducts.Name = "searchBoxProducts";
            this.searchBoxProducts.Size = new System.Drawing.Size(242, 25);
            this.searchBoxProducts.TabIndex = 52;
            // 
            // lblModifyProductHeader
            // 
            this.lblModifyProductHeader.AutoSize = true;
            this.lblModifyProductHeader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModifyProductHeader.Location = new System.Drawing.Point(35, 47);
            this.lblModifyProductHeader.Name = "lblModifyProductHeader";
            this.lblModifyProductHeader.Size = new System.Drawing.Size(136, 25);
            this.lblModifyProductHeader.TabIndex = 51;
            this.lblModifyProductHeader.Text = "Modify Product";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMin.Location = new System.Drawing.Point(197, 409);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(33, 19);
            this.labelMin.TabIndex = 50;
            this.labelMin.Text = "Min";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMin.Location = new System.Drawing.Point(250, 406);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(69, 25);
            this.textBoxMin.TabIndex = 49;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMax.Location = new System.Drawing.Point(46, 409);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(35, 19);
            this.labelMax.TabIndex = 48;
            this.labelMax.Text = "Max";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMax.Location = new System.Drawing.Point(101, 406);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(69, 25);
            this.textBoxMax.TabIndex = 47;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(46, 363);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(38, 19);
            this.labelPrice.TabIndex = 46;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrice.Location = new System.Drawing.Point(138, 360);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(138, 25);
            this.textBoxPrice.TabIndex = 45;
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInventory.Location = new System.Drawing.Point(46, 318);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(68, 19);
            this.labelInventory.TabIndex = 44;
            this.labelInventory.Text = "Inventory";
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInventory.Location = new System.Drawing.Point(138, 315);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(138, 25);
            this.textBoxInventory.TabIndex = 43;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(46, 271);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 19);
            this.labelName.TabIndex = 42;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(139, 268);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(138, 25);
            this.textBoxName.TabIndex = 41;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(46, 224);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 19);
            this.labelID.TabIndex = 40;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(138, 221);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(138, 25);
            this.textBoxID.TabIndex = 39;
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 627);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.labelAssociatedParts);
            this.Controls.Add(this.listBoxAssociated);
            this.Controls.Add(this.addButtonProducts);
            this.Controls.Add(this.labelCandidateParts);
            this.Controls.Add(this.listBoxCandidate);
            this.Controls.Add(this.searchButtonProducts);
            this.Controls.Add(this.searchBoxProducts);
            this.Controls.Add(this.lblModifyProductHeader);
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
            this.Name = "ModifyProduct";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label labelAssociatedParts;
        private System.Windows.Forms.ListBox listBoxAssociated;
        private System.Windows.Forms.Button addButtonProducts;
        private System.Windows.Forms.Label labelCandidateParts;
        private System.Windows.Forms.ListBox listBoxCandidate;
        private System.Windows.Forms.Button searchButtonProducts;
        private System.Windows.Forms.TextBox searchBoxProducts;
        private System.Windows.Forms.Label lblModifyProductHeader;
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
    }
}