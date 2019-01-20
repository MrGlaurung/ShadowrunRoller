using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShadowRunRoller.DiceRollerTab;
using ShadowRunRoller.Resources;

namespace ShadowRunRoller.Main_Window
{
    public partial class Main_Window : Form
    {
        private TextBoxBase _currentBox;
        
        // TODO: It seems that ctrl+v/c/x don't work. I got he menu items to work but not the keybindings. I need to fix that.
        public Main_Window()
        {
            InitializeComponent();
            MainWindowTab1.Controls.Add(new DiceWindow(MainWindowTooltipTextStripLeft));
            MainWindowTab1.Controls[0].Anchor = ( AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right );
            MainWindowTab2.Controls.Add(new NPCGeneratorTab.NPCGeneratorWindow(MainWindowTooltipTextStripLeft));
            MainWindowTab2.Controls[0].Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            MainWindowTooltipTextStripLeft.Text = Globals.APPLICATION_LOADED;
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Globals.APPLICATION_HELP, Globals.APPLICATION_NAME + " " + Globals.APPLICATION_VERSION);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void diceRollerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindowTabControl.SelectedTab = MainWindowTab1;
        }

        private void nPCGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindowTabControl.SelectedTab = MainWindowTab2;
        }

        // Enable and disable items as appropriate.
        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            FixEditMenuItems();
        }

        private void FixEditMenuItems()
        {
            Control controlObj = ActiveControl;
            if(controlObj is UserControl) { controlObj = (controlObj as UserControl).ActiveControl; }

            // First disable all commands, the user cannot do anything Muahhahah!.
            copyToolStripMenuItem.Enabled = false;
            cutToolStripMenuItem.Enabled = false;
            pasteToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;

            if (controlObj is TextBoxBase && controlObj.Enabled)
            {
                this._currentBox = controlObj as TextBoxBase;
                copyToolStripMenuItem.Enabled = (this._currentBox.SelectionLength > 0);
                if ((controlObj is TextBox && (controlObj as TextBox).ReadOnly == false) ||
                    (controlObj is RichTextBox) && (controlObj as RichTextBox).ReadOnly == false)
                {
                    cutToolStripMenuItem.Enabled = (this._currentBox.SelectionLength > 0);
                    pasteToolStripMenuItem.Enabled = Clipboard.ContainsText();
                    deleteToolStripMenuItem.Enabled = (this._currentBox.SelectionLength > 0);
                }
            }
        }

        private bool CheckActiveControl()
        {
            Control controlObj = ActiveControl;
            if (controlObj is UserControl) { controlObj = (controlObj as UserControl).ActiveControl; }

            return this._currentBox != null && this._currentBox == controlObj as TextBoxBase;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckActiveControl()) { return; }

            Clipboard.SetText(this._currentBox.SelectedText);

            this._currentBox.SelectedText = string.Empty;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckActiveControl()) { return; }

            Clipboard.SetText(this._currentBox.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckActiveControl()) { return; }

            string pasteText = Clipboard.GetText();

            this._currentBox.SelectedText = string.Empty;
            this._currentBox.Text = this._currentBox.Text.Insert(this._currentBox.SelectionStart, pasteText);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckActiveControl()) { return; }

            this._currentBox.Text = string.Empty;
        }
    }
}
