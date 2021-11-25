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
            var list = DBManager.GetInstance().GetList("SELECT 국밥종류 From s5469394.Goods");
            listBoxMenu.Items.Add("선택");
            for(int i = 1; i < list.Count; i++)
            {
                listBoxMenu.Items.Add(list[i]);
            }
        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBoxMenu.Items.Add()
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if(listBoxMenu.TabIndex == 0)
            {
                MessageBox.Show("국밥을 선택해주세요.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.TabIndex == 0)
            {
                MessageBox.Show("국밥을 선택해주세요.");
            }
        }
    }
}
