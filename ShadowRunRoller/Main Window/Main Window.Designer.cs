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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.MainWindowStatusStrip = new System.Windows.Forms.StatusStrip();
            this.MainWindowTooltipTextStripLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadNPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveNPCGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diceRollerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainWindowTabControl = new System.Windows.Forms.TabControl();
            this.MainWindowTab1 = new System.Windows.Forms.TabPage();
            this.MainWindowTab2 = new System.Windows.Forms.TabPage();
            this.MainWindowStatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MainWindowTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowStatusStrip
            // 
            this.MainWindowStatusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainWindowStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainWindowTooltipTextStripLeft});
            this.MainWindowStatusStrip.Location = new System.Drawing.Point(0, 568);
            this.MainWindowStatusStrip.Name = "MainWindowStatusStrip";
            this.MainWindowStatusStrip.Size = new System.Drawing.Size(492, 22);
            this.MainWindowStatusStrip.TabIndex = 1;
            this.MainWindowStatusStrip.Text = "MainWindowStatusStrip";
            // 
            // MainWindowTooltipTextStripLeft
            // 
            this.MainWindowTooltipTextStripLeft.Name = "MainWindowTooltipTextStripLeft";
            this.MainWindowTooltipTextStripLeft.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadNPCToolStripMenuItem,
            this.saveNPCToolStripMenuItem,
            this.saveNPCGroupToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadNPCToolStripMenuItem
            // 
            this.loadNPCToolStripMenuItem.Name = "loadNPCToolStripMenuItem";
            this.loadNPCToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.loadNPCToolStripMenuItem.Text = "Load Character";
            // 
            // saveNPCToolStripMenuItem
            // 
            this.saveNPCToolStripMenuItem.Name = "saveNPCToolStripMenuItem";
            this.saveNPCToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveNPCToolStripMenuItem.Text = "Save Character";
            // 
            // saveNPCGroupToolStripMenuItem
            // 
            this.saveNPCGroupToolStripMenuItem.Name = "saveNPCGroupToolStripMenuItem";
            this.saveNPCGroupToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveNPCGroupToolStripMenuItem.Text = "Save Character Group";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.EditToolStripMenuItem_DropDownOpening);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
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
            this.diceRollerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.diceRollerToolStripMenuItem.Text = "DiceRoller";
            this.diceRollerToolStripMenuItem.Click += new System.EventHandler(this.DiceRollerToolStripMenuItem_Click);
            // 
            // nPCGeneratorToolStripMenuItem
            // 
            this.nPCGeneratorToolStripMenuItem.Name = "nPCGeneratorToolStripMenuItem";
            this.nPCGeneratorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.nPCGeneratorToolStripMenuItem.Text = "NPC Generator";
            this.nPCGeneratorToolStripMenuItem.Click += new System.EventHandler(this.NPCGeneratorToolStripMenuItem_Click);
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
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.versionToolStripMenuItem.Text = "Version";
            this.versionToolStripMenuItem.Click += new System.EventHandler(this.VersionToolStripMenuItem_Click);
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
            this.MainWindowTabControl.Size = new System.Drawing.Size(470, 526);
            this.MainWindowTabControl.TabIndex = 3;
            // 
            // MainWindowTab1
            // 
            this.MainWindowTab1.Location = new System.Drawing.Point(4, 22);
            this.MainWindowTab1.Name = "MainWindowTab1";
            this.MainWindowTab1.Padding = new System.Windows.Forms.Padding(3);
            this.MainWindowTab1.Size = new System.Drawing.Size(462, 500);
            this.MainWindowTab1.TabIndex = 0;
            this.MainWindowTab1.Text = "DiceRoller";
            this.MainWindowTab1.UseVisualStyleBackColor = true;
            // 
            // MainWindowTab2
            // 
            this.MainWindowTab2.Location = new System.Drawing.Point(4, 22);
            this.MainWindowTab2.Name = "MainWindowTab2";
            this.MainWindowTab2.Padding = new System.Windows.Forms.Padding(3);
            this.MainWindowTab2.Size = new System.Drawing.Size(462, 500);
            this.MainWindowTab2.TabIndex = 1;
            this.MainWindowTab2.Text = "NPC Generator";
            this.MainWindowTab2.UseVisualStyleBackColor = true;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 590);
            this.Controls.Add(this.MainWindowTabControl);
            this.Controls.Add(this.MainWindowStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(508, 629);
            this.Name = "Main_Window";
            this.Text = "Shadowrun GM Tool";
            this.MainWindowStatusStrip.ResumeLayout(false);
            this.MainWindowStatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainWindowTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip MainWindowStatusStrip;
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
        private System.Windows.Forms.ToolStripStatusLabel MainWindowTooltipTextStripLeft;
        private System.Windows.Forms.ToolStripMenuItem loadNPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveNPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveNPCGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}