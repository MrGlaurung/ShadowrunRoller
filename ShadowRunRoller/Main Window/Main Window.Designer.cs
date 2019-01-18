namespace ShadowRunRoller.Main_Window
{
    partial class Main_Window
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diceRollerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWindowTabControl = new System.Windows.Forms.TabControl();
            this.MainWindowTab1 = new System.Windows.Forms.TabPage();
            this.MainWindowTab2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.MainWindowTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "MainWindowStatusStrip";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diceRollerToolStripMenuItem,
            this.nPCGeneratorToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // diceRollerToolStripMenuItem
            // 
            this.diceRollerToolStripMenuItem.Name = "diceRollerToolStripMenuItem";
            this.diceRollerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diceRollerToolStripMenuItem.Text = "DiceRoller";
            this.diceRollerToolStripMenuItem.Click += new System.EventHandler(this.diceRollerToolStripMenuItem_Click);
            // 
            // nPCGeneratorToolStripMenuItem
            // 
            this.nPCGeneratorToolStripMenuItem.Name = "nPCGeneratorToolStripMenuItem";
            this.nPCGeneratorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nPCGeneratorToolStripMenuItem.Text = "NPC Generator";
            this.nPCGeneratorToolStripMenuItem.Click += new System.EventHandler(this.nPCGeneratorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.versionToolStripMenuItem_Click);
            // 
            // MainWindowTabControl
            // 
            this.MainWindowTabControl.AccessibleName = "";
            this.MainWindowTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainWindowTabControl.Controls.Add(this.MainWindowTab1);
            this.MainWindowTabControl.Controls.Add(this.MainWindowTab2);
            this.MainWindowTabControl.Location = new System.Drawing.Point(11, 32);
            this.MainWindowTabControl.Name = "MainWindowTabControl";
            this.MainWindowTabControl.SelectedIndex = 0;
            this.MainWindowTabControl.Size = new System.Drawing.Size(780, 612);
            this.MainWindowTabControl.TabIndex = 3;
            // 
            // MainWindowTab1
            // 
            this.MainWindowTab1.Location = new System.Drawing.Point(4, 22);
            this.MainWindowTab1.Name = "MainWindowTab1";
            this.MainWindowTab1.Padding = new System.Windows.Forms.Padding(3);
            this.MainWindowTab1.Size = new System.Drawing.Size(772, 586);
            this.MainWindowTab1.TabIndex = 0;
            this.MainWindowTab1.Text = "DiceRoller";
            this.MainWindowTab1.UseVisualStyleBackColor = true;
            // 
            // MainWindowTab2
            // 
            this.MainWindowTab2.Location = new System.Drawing.Point(4, 22);
            this.MainWindowTab2.Name = "MainWindowTab2";
            this.MainWindowTab2.Padding = new System.Windows.Forms.Padding(3);
            this.MainWindowTab2.Size = new System.Drawing.Size(770, 412);
            this.MainWindowTab2.TabIndex = 1;
            this.MainWindowTab2.Text = "NPC Generator";
            this.MainWindowTab2.UseVisualStyleBackColor = true;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 676);
            this.Controls.Add(this.MainWindowTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Window";
            this.Text = "Shadowrun GM Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainWindowTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diceRollerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPCGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.TabControl MainWindowTabControl;
        private System.Windows.Forms.TabPage MainWindowTab1;
        private System.Windows.Forms.TabPage MainWindowTab2;
    }
}