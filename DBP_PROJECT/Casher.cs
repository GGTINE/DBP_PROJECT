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
            listViewSellList1.View = View.Details;
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

        private void buttonSundaekukbap_Click(object sender, EventArgs e)
        {
            Sellkukbap(buttonSundaekukbap.Text);
        }
        private int Payment()
        {
            int AllPrice = 0;
            for (int i = 0; i < listViewSellList1.Items.Count; i++)
            {
                AllPrice += Convert.ToInt32(listViewSellList1.Items[i].SubItems[2].Text);
                labelMoney.Text = AllPrice.ToString();
            }
            return AllPrice;
        }

        private void Sellkukbap(string goods)
        {
            SingleGoods(goods);
            listViewSellList1.BeginUpdate();
            ListViewItem item = new(Goods.GetInstance().name);
            item.SubItems.Add("1");
            item.SubItems.Add(Goods.GetInstance().price);
            for (int i = 0; i < listViewSellList1.Items.Count; i++)
            {
                if (listViewSellList1.Items[i].Text == goods)
                {
                    listViewSellList1.Items[i].SubItems[1].Text = (Convert.ToInt32(listViewSellList1.Items[i].SubItems[1].Text) + 1).ToString();
                    listViewSellList1.Items[i].SubItems[2].Text = (Convert.ToInt32(listViewSellList1.Items[i].SubItems[2].Text) + Convert.ToInt32(Goods.GetInstance().price)).ToString();
                    Payment();
                    listViewSellList1.EndUpdate();
                    return;
                }
            }
            listViewSellList1.Items.Add(item);
            Payment();
            listViewSellList1.EndUpdate();
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

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (textBoxTableNumber.Text != "") MessageBox.Show("주문완료되었습니다.");
            else MessageBox.Show("테이블번호를 입력해주세요.");
            for (int i = 0; i < listViewSellList1.Items.Count; i++)
            {
                DBManager.GetInstance().WriteQuery(
                "INSERT INTO `s5469394`.`CurTable` (`날짜`, `상품명`, `상품개수`, `테이블번호`) " +
                $"VALUES ('{dateTimePeeker.Value:yyyy-MM-dd HH:mm:ss}', '{listViewSellList1.Items[i].SubItems[0].Text}', '{listViewSellList1.Items[i].SubItems[2].Text}', '{textBoxTableNumber.Text}');");

                DBManager.GetInstance().WriteQuery(
                "INSERT INTO `s5469394`.`Sales` (`날짜`, `상품명`, `상품개수`, `테이블번호`, `상태`) " +
                $"VALUES ('{dateTimePeeker.Value:yyyy-MM-dd HH:mm:ss}', '{listViewSellList1.Items[i].SubItems[0].Text}', '{listViewSellList1.Items[i].SubItems[2].Text}', '{textBoxTableNumber.Text}', '주문');");
            }
            textBoxTableNumber.Text = "";
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            if (textBoxTableNumber.Text != "") MessageBox.Show("결제완료되었습니다.");
            else MessageBox.Show("테이블번호를 입력해주세요.");
            for (int i = 0; i < listViewSellList1.Items.Count; i++)
            {
                DBManager.GetInstance().WriteQuery(
                    "DELETE FROM `s5469394`.`CurTable` " +
                    $"WHERE (`Index` = '{textBoxTableNumber.Text}');");

                DBManager.GetInstance().WriteQuery(
                "INSERT INTO `s5469394`.`Sales` (`날짜`, `상품명`, `상품개수`, `테이블번호`, `상태`) " +
                $"VALUES ('{dateTimePeeker.Value:yyyy-MM-dd HH:mm:ss}', '{listViewSellList1.Items[i].SubItems[0].Text}', '{listViewSellList1.Items[i].SubItems[2].Text}', '{textBoxTableNumber.Text}', '결제');");
            }
            textBoxTableNumber.Text = "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxTableNumber.Text != "") MessageBox.Show("조회완료되었습니다.");
            else MessageBox.Show("테이블번호를 입력해주세요.");
        }
    }
}
