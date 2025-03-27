
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
            labelMin = new System.Windows.Forms.Label();
            textBoxMin = new System.Windows.Forms.TextBox();
            labelMax = new System.Windows.Forms.Label();
            textBoxMax = new System.Windows.Forms.TextBox();
            labelPrice = new System.Windows.Forms.Label();
            textBoxPrice = new System.Windows.Forms.TextBox();
            labelInventory = new System.Windows.Forms.Label();
            textBoxInventory = new System.Windows.Forms.TextBox();
            labelName = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            labelID = new System.Windows.Forms.Label();
            textBoxID = new System.Windows.Forms.TextBox();
            lblAddProductHeader = new System.Windows.Forms.Label();
            addButton = new System.Windows.Forms.Button();
            labelCandidateParts = new System.Windows.Forms.Label();
            searchButtonProducts = new System.Windows.Forms.Button();
            searchBoxProducts = new System.Windows.Forms.TextBox();
            deleteButton = new System.Windows.Forms.Button();
            labelAssociatedParts = new System.Windows.Forms.Label();
            cancelButton = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            allGridView = new System.Windows.Forms.DataGridView();
            associatedGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)allGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedGridView).BeginInit();
            SuspendLayout();
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelMin.Location = new System.Drawing.Point(202, 408);
            labelMin.Name = "labelMin";
            labelMin.Size = new System.Drawing.Size(33, 19);
            labelMin.TabIndex = 26;
            labelMin.Text = "Min";
            // 
            // textBoxMin
            // 
            textBoxMin.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxMin.Location = new System.Drawing.Point(255, 405);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new System.Drawing.Size(69, 25);
            textBoxMin.TabIndex = 25;
            textBoxMin.TextChanged += textBoxMin_TextChanged;
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelMax.Location = new System.Drawing.Point(51, 408);
            labelMax.Name = "labelMax";
            labelMax.Size = new System.Drawing.Size(35, 19);
            labelMax.TabIndex = 24;
            labelMax.Text = "Max";
            // 
            // textBoxMax
            // 
            textBoxMax.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxMax.Location = new System.Drawing.Point(106, 405);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new System.Drawing.Size(69, 25);
            textBoxMax.TabIndex = 23;
            textBoxMax.TextChanged += textBoxMax_TextChanged;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelPrice.Location = new System.Drawing.Point(51, 362);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(38, 19);
            labelPrice.TabIndex = 22;
            labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxPrice.Location = new System.Drawing.Point(143, 359);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(138, 25);
            textBoxPrice.TabIndex = 21;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // labelInventory
            // 
            labelInventory.AutoSize = true;
            labelInventory.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelInventory.Location = new System.Drawing.Point(51, 317);
            labelInventory.Name = "labelInventory";
            labelInventory.Size = new System.Drawing.Size(68, 19);
            labelInventory.TabIndex = 20;
            labelInventory.Text = "Inventory";
            // 
            // textBoxInventory
            // 
            textBoxInventory.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxInventory.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxInventory.Location = new System.Drawing.Point(143, 314);
            textBoxInventory.Name = "textBoxInventory";
            textBoxInventory.Size = new System.Drawing.Size(138, 25);
            textBoxInventory.TabIndex = 19;
            textBoxInventory.TextChanged += textBoxInventory_TextChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelName.Location = new System.Drawing.Point(51, 271);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(45, 19);
            labelName.TabIndex = 18;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxName.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxName.Location = new System.Drawing.Point(144, 267);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(138, 25);
            textBoxName.TabIndex = 17;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelID.Location = new System.Drawing.Point(51, 223);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(23, 19);
            labelID.TabIndex = 16;
            labelID.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxID.Location = new System.Drawing.Point(143, 220);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new System.Drawing.Size(138, 25);
            textBoxID.TabIndex = 15;
            // 
            // lblAddProductHeader
            // 
            lblAddProductHeader.AutoSize = true;
            lblAddProductHeader.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblAddProductHeader.Location = new System.Drawing.Point(40, 46);
            lblAddProductHeader.Name = "lblAddProductHeader";
            lblAddProductHeader.Size = new System.Drawing.Size(113, 25);
            lblAddProductHeader.TabIndex = 27;
            lblAddProductHeader.Text = "Add Product";
            // 
            // addButton
            // 
            addButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            addButton.Location = new System.Drawing.Point(822, 270);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(62, 31);
            addButton.TabIndex = 33;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // labelCandidateParts
            // 
            labelCandidateParts.AutoSize = true;
            labelCandidateParts.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelCandidateParts.Location = new System.Drawing.Point(418, 86);
            labelCandidateParts.Name = "labelCandidateParts";
            labelCandidateParts.Size = new System.Drawing.Size(122, 19);
            labelCandidateParts.TabIndex = 31;
            labelCandidateParts.Text = "All candidate Parts";
            // 
            // searchButtonProducts
            // 
            searchButtonProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            searchButtonProducts.Location = new System.Drawing.Point(599, 50);
            searchButtonProducts.Name = "searchButtonProducts";
            searchButtonProducts.Size = new System.Drawing.Size(58, 23);
            searchButtonProducts.TabIndex = 29;
            searchButtonProducts.Text = "Search";
            searchButtonProducts.UseVisualStyleBackColor = true;
            searchButtonProducts.Click += searchButtonProducts_Click;
            // 
            // searchBoxProducts
            // 
            searchBoxProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            searchBoxProducts.Location = new System.Drawing.Point(663, 49);
            searchBoxProducts.Name = "searchBoxProducts";
            searchBoxProducts.Size = new System.Drawing.Size(242, 25);
            searchBoxProducts.TabIndex = 28;
            // 
            // deleteButton
            // 
            deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            deleteButton.Location = new System.Drawing.Point(822, 496);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(62, 31);
            deleteButton.TabIndex = 36;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // labelAssociatedParts
            // 
            labelAssociatedParts.AutoSize = true;
            labelAssociatedParts.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelAssociatedParts.Location = new System.Drawing.Point(418, 312);
            labelAssociatedParts.Name = "labelAssociatedParts";
            labelAssociatedParts.Size = new System.Drawing.Size(215, 19);
            labelAssociatedParts.TabIndex = 35;
            labelAssociatedParts.Text = "Parts associated with this Product";
            // 
            // cancelButton
            // 
            cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            cancelButton.Location = new System.Drawing.Point(822, 568);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(62, 31);
            cancelButton.TabIndex = 37;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            buttonSave.Location = new System.Drawing.Point(722, 568);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(62, 31);
            buttonSave.TabIndex = 38;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // allGridView
            // 
            allGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allGridView.Location = new System.Drawing.Point(418, 108);
            allGridView.Name = "allGridView";
            allGridView.Size = new System.Drawing.Size(505, 156);
            allGridView.TabIndex = 39;
            // 
            // associatedGridView
            // 
            associatedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedGridView.Location = new System.Drawing.Point(418, 334);
            associatedGridView.Name = "associatedGridView";
            associatedGridView.Size = new System.Drawing.Size(505, 156);
            associatedGridView.TabIndex = 40;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(1014, 637);
            Controls.Add(associatedGridView);
            Controls.Add(allGridView);
            Controls.Add(buttonSave);
            Controls.Add(cancelButton);
            Controls.Add(deleteButton);
            Controls.Add(labelAssociatedParts);
            Controls.Add(addButton);
            Controls.Add(labelCandidateParts);
            Controls.Add(searchButtonProducts);
            Controls.Add(searchBoxProducts);
            Controls.Add(lblAddProductHeader);
            Controls.Add(labelMin);
            Controls.Add(textBoxMin);
            Controls.Add(labelMax);
            Controls.Add(textBoxMax);
            Controls.Add(labelPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(labelInventory);
            Controls.Add(textBoxInventory);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelID);
            Controls.Add(textBoxID);
            Name = "AddProduct";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)allGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.Button searchButtonProducts;
        private System.Windows.Forms.TextBox searchBoxProducts;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label labelAssociatedParts;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView allGridView;
        private System.Windows.Forms.DataGridView associatedGridView;
    }
}