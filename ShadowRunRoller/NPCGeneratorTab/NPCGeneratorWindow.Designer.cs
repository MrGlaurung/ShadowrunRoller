namespace ShadowRunRoller.NPCGeneratorTab
{
    partial class NPCGeneratorWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.PowerComboBox = new System.Windows.Forms.ComboBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.RaceComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseNPC = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ChooseNPC);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.GenerateButton);
            this.groupBox1.Controls.Add(this.PowerLabel);
            this.groupBox1.Controls.Add(this.PowerComboBox);
            this.groupBox1.Controls.Add(this.ClassLabel);
            this.groupBox1.Controls.Add(this.RaceLabel);
            this.groupBox1.Controls.Add(this.ClassComboBox);
            this.groupBox1.Controls.Add(this.RaceComboBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose type";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(281, 89);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(121, 36);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate New NPC";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // PowerLabel
            // 
            this.PowerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(281, 20);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(111, 13);
            this.PowerLabel.TabIndex = 5;
            this.PowerLabel.Text = "NPC Power (Strength)";
            // 
            // PowerComboBox
            // 
            this.PowerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerComboBox.FormattingEnabled = true;
            this.PowerComboBox.Location = new System.Drawing.Point(281, 43);
            this.PowerComboBox.Name = "PowerComboBox";
            this.PowerComboBox.Size = new System.Drawing.Size(121, 21);
            this.PowerComboBox.TabIndex = 4;
            // 
            // ClassLabel
            // 
            this.ClassLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(149, 20);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(65, 13);
            this.ClassLabel.TabIndex = 3;
            this.ClassLabel.Text = "Class (Type)";
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(13, 20);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(33, 13);
            this.RaceLabel.TabIndex = 1;
            this.RaceLabel.Text = "Race";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(149, 43);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassComboBox.TabIndex = 2;
            // 
            // RaceComboBox
            // 
            this.RaceComboBox.FormattingEnabled = true;
            this.RaceComboBox.Location = new System.Drawing.Point(13, 43);
            this.RaceComboBox.Name = "RaceComboBox";
            this.RaceComboBox.Size = new System.Drawing.Size(121, 21);
            this.RaceComboBox.TabIndex = 0;
            // 
            // ChooseNPC
            // 
            this.ChooseNPC.AutoSize = true;
            this.ChooseNPC.Location = new System.Drawing.Point(16, 81);
            this.ChooseNPC.Name = "ChooseNPC";
            this.ChooseNPC.Size = new System.Drawing.Size(103, 13);
            this.ChooseNPC.TabIndex = 8;
            this.ChooseNPC.Text = "Choose loaded NPC";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // NPCGeneratorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(462, 500);
            this.Name = "NPCGeneratorWindow";
            this.Size = new System.Drawing.Size(462, 500);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.ComboBox PowerComboBox;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.ComboBox RaceComboBox;
        private System.Windows.Forms.Label ChooseNPC;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
