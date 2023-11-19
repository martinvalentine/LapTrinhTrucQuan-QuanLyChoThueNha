using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();

            bunifuFormDock1.SubscribeControlToDragEvents(panel1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage3);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage4);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage5);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage6);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage7);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(4);

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(5);

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(6);

        }
    }
}
