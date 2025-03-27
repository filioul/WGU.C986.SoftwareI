
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
            buttonSave = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            deleteButton = new System.Windows.Forms.Button();
            labelAssociatedParts = new System.Windows.Forms.Label();
            addButtonProducts = new System.Windows.Forms.Button();
            labelCandidateParts = new System.Windows.Forms.Label();
            searchButtonProducts = new System.Windows.Forms.Button();
            searchBoxProducts = new System.Windows.Forms.TextBox();
            lblModifyProductHeader = new System.Windows.Forms.Label();
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
            allGridView = new System.Windows.Forms.DataGridView();
            associatedGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)allGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedGridView).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            buttonSave.Location = new System.Drawing.Point(717, 569);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(62, 31);
            buttonSave.TabIndex = 61;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // cancelButton
            // 
            cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            cancelButton.Location = new System.Drawing.Point(817, 569);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(62, 31);
            cancelButton.TabIndex = 60;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            deleteButton.Location = new System.Drawing.Point(817, 497);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(62, 31);
            deleteButton.TabIndex = 59;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // labelAssociatedParts
            // 
            labelAssociatedParts.AutoSize = true;
            labelAssociatedParts.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelAssociatedParts.Location = new System.Drawing.Point(413, 313);
            labelAssociatedParts.Name = "labelAssociatedParts";
            labelAssociatedParts.Size = new System.Drawing.Size(215, 19);
            labelAssociatedParts.TabIndex = 58;
            labelAssociatedParts.Text = "Parts associated with this Product";
            // 
            // addButtonProducts
            // 
            addButtonProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            addButtonProducts.Location = new System.Drawing.Point(817, 271);
            addButtonProducts.Name = "addButtonProducts";
            addButtonProducts.Size = new System.Drawing.Size(62, 31);
            addButtonProducts.TabIndex = 56;
            addButtonProducts.Text = "Add";
            addButtonProducts.UseVisualStyleBackColor = true;
            addButtonProducts.Click += addButtonProducts_Click;
            // 
            // labelCandidateParts
            // 
            labelCandidateParts.AutoSize = true;
            labelCandidateParts.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelCandidateParts.Location = new System.Drawing.Point(413, 87);
            labelCandidateParts.Name = "labelCandidateParts";
            labelCandidateParts.Size = new System.Drawing.Size(122, 19);
            labelCandidateParts.TabIndex = 55;
            labelCandidateParts.Text = "All candidate Parts";
            // 
            // searchButtonProducts
            // 
            searchButtonProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            searchButtonProducts.Location = new System.Drawing.Point(594, 51);
            searchButtonProducts.Name = "searchButtonProducts";
            searchButtonProducts.Size = new System.Drawing.Size(58, 23);
            searchButtonProducts.TabIndex = 53;
            searchButtonProducts.Text = "Search";
            searchButtonProducts.UseVisualStyleBackColor = true;
            searchButtonProducts.Click += searchButtonProducts_Click;
            // 
            // searchBoxProducts
            // 
            searchBoxProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            searchBoxProducts.Location = new System.Drawing.Point(658, 50);
            searchBoxProducts.Name = "searchBoxProducts";
            searchBoxProducts.Size = new System.Drawing.Size(242, 25);
            searchBoxProducts.TabIndex = 52;
            // 
            // lblModifyProductHeader
            // 
            lblModifyProductHeader.AutoSize = true;
            lblModifyProductHeader.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblModifyProductHeader.Location = new System.Drawing.Point(35, 47);
            lblModifyProductHeader.Name = "lblModifyProductHeader";
            lblModifyProductHeader.Size = new System.Drawing.Size(136, 25);
            lblModifyProductHeader.TabIndex = 51;
            lblModifyProductHeader.Text = "Modify Product";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelMin.Location = new System.Drawing.Point(197, 409);
            labelMin.Name = "labelMin";
            labelMin.Size = new System.Drawing.Size(33, 19);
            labelMin.TabIndex = 50;
            labelMin.Text = "Min";
            // 
            // textBoxMin
            // 
            textBoxMin.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxMin.Location = new System.Drawing.Point(250, 406);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new System.Drawing.Size(69, 25);
            textBoxMin.TabIndex = 49;
            textBoxMin.TextChanged += textBoxMin_TextChanged;
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelMax.Location = new System.Drawing.Point(46, 409);
            labelMax.Name = "labelMax";
            labelMax.Size = new System.Drawing.Size(35, 19);
            labelMax.TabIndex = 48;
            labelMax.Text = "Max";
            // 
            // textBoxMax
            // 
            textBoxMax.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxMax.Location = new System.Drawing.Point(101, 406);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new System.Drawing.Size(69, 25);
            textBoxMax.TabIndex = 47;
            textBoxMax.TextChanged += textBoxMax_TextChanged;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelPrice.Location = new System.Drawing.Point(46, 363);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(38, 19);
            labelPrice.TabIndex = 46;
            labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxPrice.Location = new System.Drawing.Point(138, 360);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(138, 25);
            textBoxPrice.TabIndex = 45;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // labelInventory
            // 
            labelInventory.AutoSize = true;
            labelInventory.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelInventory.Location = new System.Drawing.Point(46, 318);
            labelInventory.Name = "labelInventory";
            labelInventory.Size = new System.Drawing.Size(68, 19);
            labelInventory.TabIndex = 44;
            labelInventory.Text = "Inventory";
            // 
            // textBoxInventory
            // 
            textBoxInventory.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxInventory.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxInventory.Location = new System.Drawing.Point(138, 315);
            textBoxInventory.Name = "textBoxInventory";
            textBoxInventory.Size = new System.Drawing.Size(138, 25);
            textBoxInventory.TabIndex = 43;
            textBoxInventory.TextChanged += textBoxInventory_TextChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelName.Location = new System.Drawing.Point(46, 271);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(45, 19);
            labelName.TabIndex = 42;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxName.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxName.Location = new System.Drawing.Point(139, 268);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(138, 25);
            textBoxName.TabIndex = 41;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelID.Location = new System.Drawing.Point(46, 224);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(23, 19);
            labelID.TabIndex = 40;
            labelID.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxID.Location = new System.Drawing.Point(138, 221);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new System.Drawing.Size(138, 25);
            textBoxID.TabIndex = 39;
            // 
            // allGridView
            // 
            allGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allGridView.Location = new System.Drawing.Point(413, 109);
            allGridView.Name = "allGridView";
            allGridView.Size = new System.Drawing.Size(505, 156);
            allGridView.TabIndex = 62;
            // 
            // associatedGridView
            // 
            associatedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedGridView.Location = new System.Drawing.Point(413, 335);
            associatedGridView.Name = "associatedGridView";
            associatedGridView.Size = new System.Drawing.Size(505, 156);
            associatedGridView.TabIndex = 63;
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1003, 627);
            Controls.Add(associatedGridView);
            Controls.Add(allGridView);
            Controls.Add(buttonSave);
            Controls.Add(cancelButton);
            Controls.Add(deleteButton);
            Controls.Add(labelAssociatedParts);
            Controls.Add(addButtonProducts);
            Controls.Add(labelCandidateParts);
            Controls.Add(searchButtonProducts);
            Controls.Add(searchBoxProducts);
            Controls.Add(lblModifyProductHeader);
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
            Name = "ModifyProduct";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)allGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label labelAssociatedParts;
        private System.Windows.Forms.Button addButtonProducts;
        private System.Windows.Forms.Label labelCandidateParts;
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
        private System.Windows.Forms.DataGridView allGridView;
        private System.Windows.Forms.DataGridView associatedGridView;
    }
}