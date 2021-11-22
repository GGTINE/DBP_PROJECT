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

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("저장 클릭했습니다.");
        }
    }
}
