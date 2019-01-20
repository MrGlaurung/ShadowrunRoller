using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowRunRoller.NPCGeneratorTab.Generator
{
    static class FillWindow
    {
        public static void WriteOutChar(Character chr, NPCGeneratorWindow ngw)
        {
            ngw.GetStrengthStatTextBox().Text = chr.StrengthStat.ToString();
        }
    }
}
