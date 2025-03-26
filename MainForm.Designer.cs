
namespace WGU.C986
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPageHeader = new System.Windows.Forms.Label();
            searchBoxParts = new System.Windows.Forms.TextBox();
            searchButtonParts = new System.Windows.Forms.Button();
            labelParts = new System.Windows.Forms.Label();
            deleteButtonParts = new System.Windows.Forms.Button();
            modifyButtonParts = new System.Windows.Forms.Button();
            addButtonParts = new System.Windows.Forms.Button();
            addButtonProducts = new System.Windows.Forms.Button();
            modifyButtonProducts = new System.Windows.Forms.Button();
            deleteButtonProducts = new System.Windows.Forms.Button();
            labelProducts = new System.Windows.Forms.Label();
            searchButtonProducts = new System.Windows.Forms.Button();
            searchBoxProducts = new System.Windows.Forms.TextBox();
            exitButton = new System.Windows.Forms.Button();
            productGridView = new System.Windows.Forms.DataGridView();
            partGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)productGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partGridView).BeginInit();
            SuspendLayout();
            // 
            // lblPageHeader
            // 
            lblPageHeader.AutoSize = true;
            lblPageHeader.Font = new System.Drawing.Font("Segoe UI", 15F);
            lblPageHeader.Location = new System.Drawing.Point(12, 9);
            lblPageHeader.Name = "lblPageHeader";
            lblPageHeader.Size = new System.Drawing.Size(283, 28);
            lblPageHeader.TabIndex = 0;
            lblPageHeader.Text = "Inventory Management System";
            // 
            // searchBoxParts
            // 
            searchBoxParts.Font = new System.Drawing.Font("Segoe UI", 10F);
            searchBoxParts.Location = new System.Drawing.Point(314, 72);
            searchBoxParts.Name = "searchBoxParts";
            searchBoxParts.Size = new System.Drawing.Size(242, 25);
            searchBoxParts.TabIndex = 1;
            // 
            // searchButtonParts
            // 
            searchButtonParts.Font = new System.Drawing.Font("Segoe UI", 9F);
            searchButtonParts.Location = new System.Drawing.Point(250, 73);
            searchButtonParts.Name = "searchButtonParts";
            searchButtonParts.Size = new System.Drawing.Size(58, 23);
            searchButtonParts.TabIndex = 2;
            searchButtonParts.Text = "Search";
            searchButtonParts.UseVisualStyleBackColor = true;
            searchButtonParts.Click += searchButtonParts_Click;
            // 
            // labelParts
            // 
            labelParts.AutoSize = true;
            labelParts.Font = new System.Drawing.Font("Segoe UI", 15F);
            labelParts.Location = new System.Drawing.Point(31, 94);
            labelParts.Name = "labelParts";
            labelParts.Size = new System.Drawing.Size(54, 28);
            labelParts.TabIndex = 4;
            labelParts.Text = "Parts";
            // 
            // deleteButtonParts
            // 
            deleteButtonParts.Font = new System.Drawing.Font("Segoe UI", 9F);
            deleteButtonParts.Location = new System.Drawing.Point(494, 356);
            deleteButtonParts.Name = "deleteButtonParts";
            deleteButtonParts.Size = new System.Drawing.Size(62, 31);
            deleteButtonParts.TabIndex = 5;
            deleteButtonParts.Text = "Delete";
            deleteButtonParts.UseVisualStyleBackColor = true;
            deleteButtonParts.Click += deleteButtonParts_Click;
            // 
            // modifyButtonParts
            // 
            modifyButtonParts.Font = new System.Drawing.Font("Segoe UI", 9F);
            modifyButtonParts.Location = new System.Drawing.Point(426, 356);
            modifyButtonParts.Name = "modifyButtonParts";
            modifyButtonParts.Size = new System.Drawing.Size(62, 31);
            modifyButtonParts.TabIndex = 6;
            modifyButtonParts.Text = "Modify";
            modifyButtonParts.UseVisualStyleBackColor = true;
            modifyButtonParts.Click += modifyButtonParts_Click;
            // 
            // addButtonParts
            // 
            addButtonParts.Font = new System.Drawing.Font("Segoe UI", 9F);
            addButtonParts.Location = new System.Drawing.Point(358, 356);
            addButtonParts.Name = "addButtonParts";
            addButtonParts.Size = new System.Drawing.Size(62, 31);
            addButtonParts.TabIndex = 7;
            addButtonParts.Text = "Add";
            addButtonParts.UseVisualStyleBackColor = true;
            addButtonParts.Click += addButtonParts_Click;
            // 
            // addButtonProducts
            // 
            addButtonProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            addButtonProducts.Location = new System.Drawing.Point(915, 356);
            addButtonProducts.Name = "addButtonProducts";
            addButtonProducts.Size = new System.Drawing.Size(62, 31);
            addButtonProducts.TabIndex = 14;
            addButtonProducts.Text = "Add";
            addButtonProducts.UseVisualStyleBackColor = true;
            addButtonProducts.Click += addButtonProducts_Click;
            // 
            // modifyButtonProducts
            // 
            modifyButtonProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            modifyButtonProducts.Location = new System.Drawing.Point(983, 356);
            modifyButtonProducts.Name = "modifyButtonProducts";
            modifyButtonProducts.Size = new System.Drawing.Size(62, 31);
            modifyButtonProducts.TabIndex = 13;
            modifyButtonProducts.Text = "Modify";
            modifyButtonProducts.UseVisualStyleBackColor = true;
            modifyButtonProducts.Click += modifyButtonProducts_Click;
            // 
            // deleteButtonProducts
            // 
            deleteButtonProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            deleteButtonProducts.Location = new System.Drawing.Point(1051, 356);
            deleteButtonProducts.Name = "deleteButtonProducts";
            deleteButtonProducts.Size = new System.Drawing.Size(62, 31);
            deleteButtonProducts.TabIndex = 12;
            deleteButtonProducts.Text = "Delete";
            deleteButtonProducts.UseVisualStyleBackColor = true;
            deleteButtonProducts.Click += deleteButtonProducts_Click;
            // 
            // labelProducts
            // 
            labelProducts.AutoSize = true;
            labelProducts.Font = new System.Drawing.Font("Segoe UI", 15F);
            labelProducts.Location = new System.Drawing.Point(588, 94);
            labelProducts.Name = "labelProducts";
            labelProducts.Size = new System.Drawing.Size(89, 28);
            labelProducts.TabIndex = 11;
            labelProducts.Text = "Products";
            // 
            // searchButtonProducts
            // 
            searchButtonProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            searchButtonProducts.Location = new System.Drawing.Point(807, 73);
            searchButtonProducts.Name = "searchButtonProducts";
            searchButtonProducts.Size = new System.Drawing.Size(58, 23);
            searchButtonProducts.TabIndex = 9;
            searchButtonProducts.Text = "Search";
            searchButtonProducts.UseVisualStyleBackColor = true;
            searchButtonProducts.Click += searchButtonProducts_Click;
            // 
            // searchBoxProducts
            // 
            searchBoxProducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            searchBoxProducts.Location = new System.Drawing.Point(871, 72);
            searchBoxProducts.Name = "searchBoxProducts";
            searchBoxProducts.Size = new System.Drawing.Size(242, 25);
            searchBoxProducts.TabIndex = 8;
            // 
            // exitButton
            // 
            exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            exitButton.Location = new System.Drawing.Point(1051, 410);
            exitButton.Name = "exitButton";
            exitButton.Size = new System.Drawing.Size(62, 31);
            exitButton.TabIndex = 15;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // productGridView
            // 
            productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGridView.Location = new System.Drawing.Point(588, 125);
            productGridView.Name = "productGridView";
            productGridView.Size = new System.Drawing.Size(505, 214);
            productGridView.TabIndex = 17;
            // 
            // partGridView
            // 
            partGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partGridView.Location = new System.Drawing.Point(31, 125);
            partGridView.Name = "partGridView";
            partGridView.Size = new System.Drawing.Size(505, 214);
            partGridView.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(1150, 465);
            Controls.Add(productGridView);
            Controls.Add(partGridView);
            Controls.Add(exitButton);
            Controls.Add(addButtonProducts);
            Controls.Add(modifyButtonProducts);
            Controls.Add(deleteButtonProducts);
            Controls.Add(labelProducts);
            Controls.Add(searchButtonProducts);
            Controls.Add(searchBoxProducts);
            Controls.Add(addButtonParts);
            Controls.Add(modifyButtonParts);
            Controls.Add(deleteButtonParts);
            Controls.Add(labelParts);
            Controls.Add(searchButtonParts);
            Controls.Add(searchBoxParts);
            Controls.Add(lblPageHeader);
            Name = "MainForm";
            Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)productGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)partGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPageHeader;
        private System.Windows.Forms.TextBox searchBoxParts;
        private System.Windows.Forms.Button searchButtonParts;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Button deleteButtonParts;
        private System.Windows.Forms.Button modifyButtonParts;
        private System.Windows.Forms.Button addButtonParts;
        private System.Windows.Forms.Button addButtonProducts;
        private System.Windows.Forms.Button modifyButtonProducts;
        private System.Windows.Forms.Button deleteButtonProducts;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Button searchButtonProducts;
        private System.Windows.Forms.TextBox searchBoxProducts;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.DataGridView partGridView;
    }
}

