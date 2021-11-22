using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_PROJECT
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)sender;
            TabPage tp = tabPage1;
            MessageBox.Show("Selected = " + tc.SelectedIndex);
            switch (tc.SelectedIndex)
            {
                case 0:
                    tp = tabPage1;
                    //// Refresh_Tabpage0();
                    break;
            }
            // Refresh_Tabpage(tp);
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("저장 클릭");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult =  MessageBox.Show("출력물...", "확인해주세요.", MessageBoxButtons.YesNoCancel);
            if(DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Yes");
            }
            else if(DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel");
            }
            else if(DialogResult == DialogResult.No)
            {
                MessageBox.Show("No");
            }
        }
    }
}
