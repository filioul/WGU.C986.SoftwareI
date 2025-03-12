
namespace WGU.C986
{
    partial class AddPart
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
            this.lblAddPartHeader = new System.Windows.Forms.Label();
            this.radioButtonInHouse = new System.Windows.Forms.RadioButton();
            this.radioButtonOutsourced = new System.Windows.Forms.RadioButton();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelInventory = new System.Windows.Forms.Label();
            this.textBoxInventory = new System.Windows.Forms.TextBox();
            this.labelPriceCost = new System.Windows.Forms.Label();
            this.textBoxPriceCost = new System.Windows.Forms.TextBox();
            this.labelMax = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.labelMachineID = new System.Windows.Forms.Label();
            this.textBoxMachineID = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.groupBoxRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddPartHeader
            // 
            this.lblAddPartHeader.AutoSize = true;
            this.lblAddPartHeader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddPartHeader.Location = new System.Drawing.Point(12, 9);
            this.lblAddPartHeader.Name = "lblAddPartHeader";
            this.lblAddPartHeader.Size = new System.Drawing.Size(81, 25);
            this.lblAddPartHeader.TabIndex = 0;
            this.lblAddPartHeader.Text = "Add Part";
            // 
            // radioButtonInHouse
            // 
            this.radioButtonInHouse.AutoSize = true;
            this.radioButtonInHouse.Checked = true;
            this.radioButtonInHouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonInHouse.Location = new System.Drawing.Point(6, 6);
            this.radioButtonInHouse.Name = "radioButtonInHouse";
            this.radioButtonInHouse.Size = new System.Drawing.Size(74, 19);
            this.radioButtonInHouse.TabIndex = 1;
            this.radioButtonInHouse.TabStop = true;
            this.radioButtonInHouse.Text = "In-House";
            this.radioButtonInHouse.UseVisualStyleBackColor = true;
            this.radioButtonInHouse.CheckedChanged += new System.EventHandler(this.radioButtonInHouse_CheckedChanged);
            // 
            // radioButtonOutsourced
            // 
            this.radioButtonOutsourced.AutoSize = true;
            this.radioButtonOutsourced.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonOutsourced.Location = new System.Drawing.Point(109, 6);
            this.radioButtonOutsourced.Name = "radioButtonOutsourced";
            this.radioButtonOutsourced.Size = new System.Drawing.Size(87, 19);
            this.radioButtonOutsourced.TabIndex = 2;
            this.radioButtonOutsourced.Text = "Oursourced";
            this.radioButtonOutsourced.UseVisualStyleBackColor = true;
            this.radioButtonOutsourced.CheckedChanged += new System.EventHandler(this.radioButtonOutsourced_CheckedChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.White;
            this.textBoxID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxID.Location = new System.Drawing.Point(167, 70);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(138, 25);
            this.textBoxID.TabIndex = 3;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.Location = new System.Drawing.Point(119, 73);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 19);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(97, 120);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 19);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(168, 117);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(138, 25);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInventory.Location = new System.Drawing.Point(75, 167);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(68, 19);
            this.labelInventory.TabIndex = 8;
            this.labelInventory.Text = "Inventory";
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInventory.Location = new System.Drawing.Point(167, 164);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(138, 25);
            this.textBoxInventory.TabIndex = 7;
            this.textBoxInventory.TextChanged += new System.EventHandler(this.textBoxInventory_TextChanged);
            // 
            // labelPriceCost
            // 
            this.labelPriceCost.AutoSize = true;
            this.labelPriceCost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceCost.Location = new System.Drawing.Point(64, 212);
            this.labelPriceCost.Name = "labelPriceCost";
            this.labelPriceCost.Size = new System.Drawing.Size(79, 19);
            this.labelPriceCost.TabIndex = 10;
            this.labelPriceCost.Text = "Price / Cost";
            // 
            // textBoxPriceCost
            // 
            this.textBoxPriceCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxPriceCost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPriceCost.Location = new System.Drawing.Point(167, 209);
            this.textBoxPriceCost.Name = "textBoxPriceCost";
            this.textBoxPriceCost.Size = new System.Drawing.Size(138, 25);
            this.textBoxPriceCost.TabIndex = 9;
            this.textBoxPriceCost.TextChanged += new System.EventHandler(this.textBoxPriceCost_TextChanged);
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMax.Location = new System.Drawing.Point(107, 258);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(35, 19);
            this.labelMax.TabIndex = 12;
            this.labelMax.Text = "Max";
            // 
            // textBoxMax
            // 
            this.textBoxMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxMax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMax.Location = new System.Drawing.Point(167, 255);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(69, 25);
            this.textBoxMax.TabIndex = 11;
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBoxMax_TextChanged);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMin.Location = new System.Drawing.Point(259, 258);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(33, 19);
            this.labelMin.TabIndex = 14;
            this.labelMin.Text = "Min";
            // 
            // textBoxMin
            // 
            this.textBoxMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxMin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMin.Location = new System.Drawing.Point(312, 255);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(69, 25);
            this.textBoxMin.TabIndex = 13;
            this.textBoxMin.TextChanged += new System.EventHandler(this.textBoxMin_TextChanged);
            // 
            // labelMachineID
            // 
            this.labelMachineID.AutoSize = true;
            this.labelMachineID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMachineID.Location = new System.Drawing.Point(45, 302);
            this.labelMachineID.Name = "labelMachineID";
            this.labelMachineID.Size = new System.Drawing.Size(79, 19);
            this.labelMachineID.TabIndex = 16;
            this.labelMachineID.Text = "Machine ID";
            // 
            // textBoxMachineID
            // 
            this.textBoxMachineID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxMachineID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMachineID.Location = new System.Drawing.Point(168, 299);
            this.textBoxMachineID.Name = "textBoxMachineID";
            this.textBoxMachineID.Size = new System.Drawing.Size(138, 25);
            this.textBoxMachineID.TabIndex = 15;
            this.textBoxMachineID.TextChanged += new System.EventHandler(this.textBoxMachineID_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(257, 352);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 40);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(351, 352);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 40);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonInHouse);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonOutsourced);
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(119, 9);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(285, 55);
            this.groupBoxRadioButtons.TabIndex = 19;
            this.groupBoxRadioButtons.TabStop = false;
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.groupBoxRadioButtons);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelMachineID);
            this.Controls.Add(this.textBoxMachineID);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.labelPriceCost);
            this.Controls.Add(this.textBoxPriceCost);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.textBoxInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.lblAddPartHeader);
            this.Name = "AddPart";
            this.Text = "Part";
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddPartHeader;
        private System.Windows.Forms.RadioButton radioButtonInHouse;
        private System.Windows.Forms.RadioButton radioButtonOutsourced;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.TextBox textBoxInventory;
        private System.Windows.Forms.Label labelPriceCost;
        private System.Windows.Forms.TextBox textBoxPriceCost;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label labelMachineID;
        private System.Windows.Forms.TextBox textBoxMachineID;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
    }
}