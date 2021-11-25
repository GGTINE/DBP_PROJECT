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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            StartForm();
        }
        private void StartForm()
        {
            var list = DBManager.GetInstance().GetSelect("SELECT ");
        }
    }
}
