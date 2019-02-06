using System;
using System.Windows.Forms;
using ShadowRunRoller.NPCGeneratorTab;
using ShadowRunRoller.Resources;

namespace ShadowRunRoller.Main_Window
{
    public partial class Main_Window : Form
    {
        private TextBoxBase _currentBox;
        // Create a random engine in the main window and use that one
        // everywhere to get as randomized numbers as possible.
        private Random rnd = new Random();
        
        // TODO: It seems that ctrl+v/c/x don't work. I got he menu items to work but not the keybindings. I need to fix that.
        public Main_Window()
        {
            InitializeComponent();
            MainWindowTab1.Controls.Add(new DiceWindow(rnd, MainWindowTooltipTextStripLeft));
            MainWindowTab1.Controls[0].Anchor = ( AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right );
            MainWindowTab2.Controls.Add(new NPCGeneratorWindow(rnd, MainWindowTooltipTextStripLeft));
            MainWindowTab2.Controls[0].Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            MainWindowTooltipTextStripLeft.Text = Globals.APPLICATION_LOADED;
        }

        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Globals.APPLICATION_HELP, Globals.APPLICATION_NAME + " " + Globals.APPLICATION_VERSION);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DiceRollerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindowTabControl.SelectedTab = MainWindowTab1;
        }

        private void NPCGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindowTabControl.SelectedTab = MainWindowTab2;
        }

        // Enable and disable items as appropriate.
        private void EditToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
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

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!CheckActiveControl()) { return; }

            Clipboard.SetText(this._currentBox.SelectedText);

            this._currentBox.SelectedText = string.Empty;
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckActiveControl()) { return; }

            Clipboard.SetText(this._currentBox.SelectedText);
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckActiveControl()) { return; }

            string pasteText = Clipboard.GetText();

            this._currentBox.SelectedText = string.Empty;
            this._currentBox.Text = this._currentBox.Text.Insert(this._currentBox.SelectionStart, pasteText);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckActiveControl()) { return; }

            this._currentBox.Text = string.Empty;
        }
    }
}
