
namespace WGU.C986
{
    partial class ModifyPart
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
            buttonCancel = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            labelMachineID = new System.Windows.Forms.Label();
            textBoxMachineID = new System.Windows.Forms.TextBox();
            labelMin = new System.Windows.Forms.Label();
            textBoxMin = new System.Windows.Forms.TextBox();
            labelMax = new System.Windows.Forms.Label();
            textBoxMax = new System.Windows.Forms.TextBox();
            labelPriceCost = new System.Windows.Forms.Label();
            textBoxPriceCost = new System.Windows.Forms.TextBox();
            labelInventory = new System.Windows.Forms.Label();
            textBoxInventory = new System.Windows.Forms.TextBox();
            labelName = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            labelID = new System.Windows.Forms.Label();
            textBoxID = new System.Windows.Forms.TextBox();
            radioButtonOutsourced = new System.Windows.Forms.RadioButton();
            radioButtonInHouse = new System.Windows.Forms.RadioButton();
            lblModifyPartHeader = new System.Windows.Forms.Label();
            groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            groupBoxRadioButtons.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            buttonCancel.Location = new System.Drawing.Point(349, 351);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 40);
            buttonCancel.TabIndex = 37;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            buttonSave.Location = new System.Drawing.Point(255, 351);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(75, 40);
            buttonSave.TabIndex = 36;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelMachineID
            // 
            labelMachineID.AutoSize = true;
            labelMachineID.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelMachineID.Location = new System.Drawing.Point(43, 301);
            labelMachineID.Name = "labelMachineID";
            labelMachineID.Size = new System.Drawing.Size(79, 19);
            labelMachineID.TabIndex = 35;
            labelMachineID.Text = "Machine ID";
            // 
            // textBoxMachineID
            // 
            textBoxMachineID.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxMachineID.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxMachineID.Location = new System.Drawing.Point(166, 298);
            textBoxMachineID.Name = "textBoxMachineID";
            textBoxMachineID.Size = new System.Drawing.Size(138, 25);
            textBoxMachineID.TabIndex = 34;
            textBoxMachineID.TextChanged += textBoxMachineID_TextChanged;
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelMin.Location = new System.Drawing.Point(257, 257);
            labelMin.Name = "labelMin";
            labelMin.Size = new System.Drawing.Size(33, 19);
            labelMin.TabIndex = 33;
            labelMin.Text = "Min";
            // 
            // textBoxMin
            // 
            textBoxMin.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxMin.Location = new System.Drawing.Point(310, 254);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new System.Drawing.Size(69, 25);
            textBoxMin.TabIndex = 32;
            textBoxMin.TextChanged += textBoxMin_TextChanged;
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelMax.Location = new System.Drawing.Point(105, 257);
            labelMax.Name = "labelMax";
            labelMax.Size = new System.Drawing.Size(35, 19);
            labelMax.TabIndex = 31;
            labelMax.Text = "Max";
            // 
            // textBoxMax
            // 
            textBoxMax.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxMax.Location = new System.Drawing.Point(165, 254);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new System.Drawing.Size(69, 25);
            textBoxMax.TabIndex = 30;
            textBoxMax.TextChanged += textBoxMax_TextChanged;
            // 
            // labelPriceCost
            // 
            labelPriceCost.AutoSize = true;
            labelPriceCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelPriceCost.Location = new System.Drawing.Point(62, 211);
            labelPriceCost.Name = "labelPriceCost";
            labelPriceCost.Size = new System.Drawing.Size(79, 19);
            labelPriceCost.TabIndex = 29;
            labelPriceCost.Text = "Price / Cost";
            // 
            // textBoxPriceCost
            // 
            textBoxPriceCost.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxPriceCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxPriceCost.Location = new System.Drawing.Point(165, 208);
            textBoxPriceCost.Name = "textBoxPriceCost";
            textBoxPriceCost.Size = new System.Drawing.Size(138, 25);
            textBoxPriceCost.TabIndex = 28;
            textBoxPriceCost.TextChanged += textBoxPriceCost_TextChanged;
            // 
            // labelInventory
            // 
            labelInventory.AutoSize = true;
            labelInventory.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelInventory.Location = new System.Drawing.Point(73, 166);
            labelInventory.Name = "labelInventory";
            labelInventory.Size = new System.Drawing.Size(68, 19);
            labelInventory.TabIndex = 27;
            labelInventory.Text = "Inventory";
            // 
            // textBoxInventory
            // 
            textBoxInventory.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxInventory.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxInventory.Location = new System.Drawing.Point(165, 163);
            textBoxInventory.Name = "textBoxInventory";
            textBoxInventory.Size = new System.Drawing.Size(138, 25);
            textBoxInventory.TabIndex = 26;
            textBoxInventory.TextChanged += textBoxInventory_TextChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelName.Location = new System.Drawing.Point(95, 119);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(45, 19);
            labelName.TabIndex = 25;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            textBoxName.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxName.Location = new System.Drawing.Point(166, 116);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(138, 25);
            textBoxName.TabIndex = 24;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new System.Drawing.Font("Segoe UI", 10F);
            labelID.Location = new System.Drawing.Point(117, 72);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(23, 19);
            labelID.TabIndex = 23;
            labelID.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.Font = new System.Drawing.Font("Segoe UI", 10F);
            textBoxID.Location = new System.Drawing.Point(165, 69);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new System.Drawing.Size(138, 25);
            textBoxID.TabIndex = 22;
            // 
            // radioButtonOutsourced
            // 
            radioButtonOutsourced.AutoSize = true;
            radioButtonOutsourced.Font = new System.Drawing.Font("Segoe UI", 9F);
            radioButtonOutsourced.Location = new System.Drawing.Point(97, 4);
            radioButtonOutsourced.Name = "radioButtonOutsourced";
            radioButtonOutsourced.Size = new System.Drawing.Size(87, 19);
            radioButtonOutsourced.TabIndex = 21;
            radioButtonOutsourced.Text = "Oursourced";
            radioButtonOutsourced.UseVisualStyleBackColor = true;
            radioButtonOutsourced.CheckedChanged += radioButtonOutsourced_CheckedChanged;
            // 
            // radioButtonInHouse
            // 
            radioButtonInHouse.AutoSize = true;
            radioButtonInHouse.Checked = true;
            radioButtonInHouse.Font = new System.Drawing.Font("Segoe UI", 9F);
            radioButtonInHouse.Location = new System.Drawing.Point(6, 4);
            radioButtonInHouse.Name = "radioButtonInHouse";
            radioButtonInHouse.Size = new System.Drawing.Size(74, 19);
            radioButtonInHouse.TabIndex = 20;
            radioButtonInHouse.TabStop = true;
            radioButtonInHouse.Text = "In-House";
            radioButtonInHouse.UseVisualStyleBackColor = true;
            radioButtonInHouse.CheckedChanged += radioButtonInHouse_CheckedChanged;
            // 
            // lblModifyPartHeader
            // 
            lblModifyPartHeader.AutoSize = true;
            lblModifyPartHeader.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblModifyPartHeader.Location = new System.Drawing.Point(10, 8);
            lblModifyPartHeader.Name = "lblModifyPartHeader";
            lblModifyPartHeader.Size = new System.Drawing.Size(104, 25);
            lblModifyPartHeader.TabIndex = 19;
            lblModifyPartHeader.Text = "Modify Part";
            // 
            // groupBoxRadioButtons
            // 
            groupBoxRadioButtons.Controls.Add(radioButtonInHouse);
            groupBoxRadioButtons.Controls.Add(radioButtonOutsourced);
            groupBoxRadioButtons.Location = new System.Drawing.Point(120, 10);
            groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            groupBoxRadioButtons.Size = new System.Drawing.Size(200, 53);
            groupBoxRadioButtons.TabIndex = 38;
            groupBoxRadioButtons.TabStop = false;
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(495, 450);
            Controls.Add(groupBoxRadioButtons);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelMachineID);
            Controls.Add(textBoxMachineID);
            Controls.Add(labelMin);
            Controls.Add(textBoxMin);
            Controls.Add(labelMax);
            Controls.Add(textBoxMax);
            Controls.Add(labelPriceCost);
            Controls.Add(textBoxPriceCost);
            Controls.Add(labelInventory);
            Controls.Add(textBoxInventory);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelID);
            Controls.Add(textBoxID);
            Controls.Add(lblModifyPartHeader);
            Name = "ModifyPart";
            Text = "Form1";
            groupBoxRadioButtons.ResumeLayout(false);
            groupBoxRadioButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelMachineID;
        private System.Windows.Forms.TextBox textBoxMachineID;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label labelPriceCost;
        private System.Windows.Forms.TextBox textBoxPriceCost;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.TextBox textBoxInventory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.RadioButton radioButtonOutsourced;
        private System.Windows.Forms.RadioButton radioButtonInHouse;
        private System.Windows.Forms.Label lblModifyPartHeader;
        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
    }
}