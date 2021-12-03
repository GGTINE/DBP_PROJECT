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
    public partial class Casher : Form
    {

        /*
         * DBManager.GetInstance().WriteQuery(
                    "INSERT INTO `s5469394`.`CurTable` (`날짜`, `상품명`, `판매자`, `테이블번호`) " +
                    $"VALUES ('{dateTimePeeker.Value:yyyy-MM-dd HH:mm:ss}', '{Goods.GetInstance().name}', '{User.GetInstance().ID}', '{textBoxTableNumber.Text}');");
         */
        int CheckLogout = 0;
        public Casher()
        {
            InitializeComponent();
            labelUserName.Text = User.GetInstance().Name + "님 반갑습니다.";
            listViewSellList.View = View.Details;
        }

        private void SingleGoods(string name)
        {
            var GoodsInfo = DBManager.GetInstance().GetSelect(
                "SELECT * " +
                "FROM s5469394.Goods " +
                $"WHERE (상품명 = '{name}');");

            Goods.GetInstance().name = GoodsInfo["상품명"];
            Goods.GetInstance().price = GoodsInfo["가격"];
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            CheckLogout = 1;
            WriteLog();
            MessageBox.Show("로그아웃 합니다.");
            this.Close();
        }

        private void buttonPigkukbap_Click(object sender, EventArgs e)
        {
            Sellkukbap(buttonPigkukbap.Text);
        }

        private void buttonCowheadkukbap_Click(object sender, EventArgs e)
        {
            Sellkukbap(buttonCowheadkukbap.Text);
        }
        private void buttondumpling_Click(object sender, EventArgs e)
        {
            Sellkukbap(buttondumpling.Text);
        }

        private void buttonBeefMeat_Click(object sender, EventArgs e)
        {
            Sellkukbap(buttonBeefMeat.Text);
        }

        private void buttonCoke_Click(object sender, EventArgs e)
        {
            Sellkukbap(buttonCoke.Text);
        }

        private void buttonSundaekukbap_Click(object sender, EventArgs e)
        {
            Sellkukbap(buttonSundaekukbap.Text);
        }
        private int Payment()
        {
            int AllPrice = 0;
            for (int i = 0; i < listViewSellList.Items.Count; i++)
            {
                AllPrice += Convert.ToInt32(listViewSellList.Items[i].SubItems[2].Text);
                labelMoney.Text = AllPrice.ToString();
            }
            return AllPrice;
        }

        private void Sellkukbap(string goods)
        {
            SingleGoods(goods);
            listViewSellList.BeginUpdate();
            ListViewItem item = new(Goods.GetInstance().name);
            item.SubItems.Add("1");
            item.SubItems.Add(Goods.GetInstance().price);
            for (int i = 0; i < listViewSellList.Items.Count; i++)
            {
                if (listViewSellList.Items[i].Text == goods)
                {
                    listViewSellList.Items[i].SubItems[1].Text = (Convert.ToInt32(listViewSellList.Items[i].SubItems[1].Text) + 1).ToString();
                    listViewSellList.Items[i].SubItems[2].Text = (Convert.ToInt32(listViewSellList.Items[i].SubItems[2].Text) + Convert.ToInt32(Goods.GetInstance().price)).ToString();
                    Payment();
                    listViewSellList.EndUpdate();
                    return;
                }
            }
            listViewSellList.Items.Add(item);
            Payment();
            listViewSellList.EndUpdate();
        }
        private void WriteLog()
        {
            DBManager.GetInstance().WriteQuery(
                "INSERT INTO `s5469394`.`Log` (`id`, `log`, `state`) " +
                $"VALUES ('{User.GetInstance().ID}', '{DateTime.Now:yyyy-MM-dd-HH-mm-ss}', '로그아웃');");
        }

        private void Casher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckLogout == 0)
            {
                WriteLog();
                MessageBox.Show("로그아웃 합니다.");
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewSellList.Items.Count; i++)
            {
                DBManager.GetInstance().WriteQuery(
                "INSERT INTO `s5469394`.`Sales` (`날짜`, `상품명`, `상품개수`, `상품가격합`, `테이블번호`, `상태`, 판매자) " +
                $"VALUES ('{dateTimePeeker.Value:yyyy-MM-dd HH:mm:ss}', '{listViewSellList.Items[i].SubItems[0].Text}', '{listViewSellList.Items[i].SubItems[1].Text}', '{listViewSellList.Items[i].SubItems[2].Text}', '{tabControl1.SelectedIndex}', '주문', '{User.GetInstance().ID}');");
            }
            MessageBox.Show("주문이 완료되었습니다.");
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            string table = tabControl1.SelectedIndex.ToString();
            for (int i = 0; i < listViewSellList.Items.Count; i++)
            {
                DBManager.GetInstance().WriteQuery(
                    "UPDATE `s5469394`.`Sales` " +
                    "SET `상태` = '주문완료' " +
                    $"WHERE(`상태` = '주문' AND `테이블번호` = '{table}');");

                DBManager.GetInstance().WriteQuery(
                "INSERT INTO `s5469394`.`Sales` (`날짜`, `상품명`, `상품개수`, `상품가격합`, `테이블번호`, `상태`, 판매자) " +
                $"VALUES ('{DateTime.Now:yyyy-MM-dd-HH-mm-ss}', '{listViewSellList.Items[i].SubItems[0].Text}', '{listViewSellList.Items[i].SubItems[1].Text}', '{listViewSellList.Items[i].SubItems[2].Text}', '{tabControl1.SelectedIndex}', '결제완료', '{User.GetInstance().ID}');");
            }
            MessageBox.Show("결제가 완료되었습니다.");
            listViewSellList.Items.Clear();
        }
        private void AddListView()
        {
            string table = tabControl1.SelectedIndex.ToString();
            string query = "SELECT 상품명, 상품개수, 상품가격합, 테이블번호, 상태 " +
                        "FROM s5469394.Sales " +
                        $"WHERE (`테이블번호` = '{table}' AND `상태` = '주문');";
            List<Dictionary<string, string>> n_list;
            listViewSellList.Items.Clear();
            n_list = DBManager.GetInstance().GetTable(query);
            for (int i = 0; i < n_list.Count; i++)
            {
                ListViewItem item = new(n_list[i]["상품명"]);
                item.SubItems.Add(n_list[i]["상품개수"]);
                item.SubItems.Add(n_list[i]["상품가격합"]);
                listViewSellList.Items.Add(item);
            }
            Payment();
            listViewSellList.EndUpdate();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    AddListView();
                    break;

                case 2:
                    AddListView();
                    break;

                case 3:
                    AddListView();
                    break;

                case 4:
                    AddListView();
                    break;

                case 5:
                    AddListView();
                    break;

                case 6:
                    AddListView();
                    break;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if (textBoxTableNumber.Text != "")
            {
                if (checkBoxOrder.Checked == true && checkBoxPayment.Checked == true)
                {
                    dt = DBManager.GetInstance().GetGrid(
                            "SELECT * " +
                            "FROM s5469394.Sales " +
                            $"WHERE (`테이블번호` = '{textBoxTableNumber.Text}');");
                    dataGridViewResult.DataSource = dt;
                }
                else if (checkBoxOrder.Checked == true)
                {
                    dt = DBManager.GetInstance().GetGrid(
                            "SELECT * " +
                            "FROM s5469394.Sales " +
                            $"WHERE (`테이블번호` = '{textBoxTableNumber.Text}' AND `상태` = '주문완료');");
                    dataGridViewResult.DataSource = dt;
                }
                else if(checkBoxPayment.Checked == true)
                {
                    dt = DBManager.GetInstance().GetGrid(
                            "SELECT * " +
                            "FROM s5469394.Sales " +
                            $"WHERE (`테이블번호` = '{textBoxTableNumber.Text}' AND `상태` = '결제완료');");
                    dataGridViewResult.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("옵션을 체크해주세요");
                }
            }
            else
            {
                MessageBox.Show("테이블번호를 입력해주세요");
            }
        }

        private void listViewSellList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewSellList.SelectedItems.Count != 0)
            {
                textBoxCancelName.Text = listViewSellList.SelectedItems[0].Text;
                textBoxCancelValue.Text = listViewSellList.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            int table = tabControl1.SelectedIndex;
            int check = Convert.ToInt32(listViewSellList.SelectedItems[0].SubItems[1].Text) - Convert.ToInt32(textBoxCancelValue.Text);
            int price = check * Convert.ToInt32(Goods.GetInstance().price);
            SingleGoods(textBoxCancelName.Text);
            DBManager.GetInstance().WriteQuery(
                "INSERT INTO `s5469394`.`Sales` (`날짜`, `상품명`, `상품개수`, `상품가격합`, `테이블번호`, `상태`, 판매자) " +
                $"VALUES ('{DateTime.Now:yyyy-MM-dd-HH-mm-ss}', '{textBoxCancelName.Text}', '{textBoxCancelValue.Text}', '{Convert.ToInt32(Goods.GetInstance().price) * Convert.ToInt32(textBoxCancelValue.Text)}', '{table}', '취소완료', '{User.GetInstance().ID}');");

            if(check == 0)
            {
                DBManager.GetInstance().WriteQuery(
                    "DELETE FROM `s5469394`.`Sales` " +
                    $"WHERE (`상품명` = '{textBoxCancelName.Text}') AND `상태` = '주문';");
            }
            else
            {
                DBManager.GetInstance().WriteQuery(
                    "UPDATE `s5469394`.`Sales` " +
                    $"SET `상품개수` = '{check}', `상품가격합` = '{price}' " +
                    $"WHERE(`상태` = '주문' AND `테이블번호` = '{table}');");
            }
        }
    }
}
