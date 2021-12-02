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
            listBoxMenu.Items.Clear();
            var list = DBManager.GetInstance().GetList("SELECT 상품명 From s5469394.Goods");
            listBoxMenu.Items.Add("선택");
            for(int i = 0; i < list.Count; i++)
            {
                listBoxMenu.Items.Add(list[i]);
            }
        }

        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = DBManager.GetInstance().GetSelect($"SELECT * From s5469394.Goods WHERE(상품명 = '{listBoxMenu.SelectedItem}')");
            textBoxName.Text = list["상품명"].ToString();
            textBoxPrice.Text = list["가격"].ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            bool insert = DBManager.GetInstance().WriteQuery(
                "INSERT INTO `s5469394`.`Goods` (`상품명`, `가격`)" +
                $"VALUES('{textBoxName.Text}', '{textBoxPrice.Text}');");
            if(insert)
            {
                MessageBox.Show("추가되었습니다.");
                StartForm();
            }
            else
            {
                MessageBox.Show("추가하지 못했습니다.");
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if(listBoxMenu.SelectedIndex == 0)
            {
                MessageBox.Show("상품을 선택해주세요.");
            }
            else
            {
                bool change = DBManager.GetInstance().WriteQuery(
                    "UPDATE `s5469394`.`Goods`" +
                    $"SET `상품명` = '{textBoxName.Text}', `가격` = '{textBoxPrice.Text}'" +
                    $"WHERE(`상품명` = '{listBoxMenu.SelectedItem}');");
                if(change)
                {
                    MessageBox.Show("변경되었습니다.");
                    StartForm();
                }
                else
                {
                    MessageBox.Show("변경하지 못했습니다.");
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedIndex == 0)
            {
                MessageBox.Show("상품을 선택해주세요.");
            }
            else
            {
                DBManager.GetInstance().WriteQuery(
                    "DELETE " +
                    "FROM s5469394.Goods " +
                    $"WHERE (상품명 = '{listBoxMenu.SelectedItem}');");
                MessageBox.Show("삭제되었습니다.");
                StartForm();
            }
        }
    }
}
