using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowRunRoller.NPCGeneratorTab
{
    public partial class NPCGeneratorWindow : UserControl
    {
        private ToolStripStatusLabel MainStatusLabel;

        public NPCGeneratorWindow(ToolStripStatusLabel StatusLabel = null)
        {
            InitializeComponent();
            if (StatusLabel != null) { MainStatusLabel = StatusLabel; }
        }

        private void setStatusLabelText(string text)
        {
            if (MainStatusLabel != null)
            {
                MainStatusLabel.Text = text;
            }
        }
    }
}
