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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            textBoxID.Text = "";
            textBoxPW.Text = "";
            groupBoxUserLogout.Hide();
            groupBoxAdmin.Hide();
            groupBoxUser.Hide();
        }

        private void SingleUser(string id)
        {
            var UserInfo = DBManager.GetInstance().GetSelect(
                "SELECT * " +
                "FROM s5469394.User " +
                $"WHERE (id = '{id}');");

            User.GetInstance().ID = UserInfo["ID"];
            User.GetInstance().Password = UserInfo["PW"];
            User.GetInstance().Name = UserInfo["이름"];
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string User_ID = textBoxID.Text;
            string User_PW = textBoxPW.Text;
            bool try_ = DBManager.GetInstance().Compare(
                "SELECT * " +
                "FROM s5469394.User " +
                $"where (Id = '{User_ID}' AND Pw = '{User_PW}');", 
                "Id", User_ID, "Pw", User_PW);

            if (try_)
            {
                SingleUser(User_ID);
                MessageBox.Show("로그인에 성공하였습니다.");
                groupBoxLogin.Hide();
                groupBoxUserLogout.Show();
                labelUserName.Text = $"{User.GetInstance().Name}님 반갑습니다.";
                if(User.GetInstance().Name == "관리자")
                {
                    groupBoxAdmin.Show();
                }
                else
                {
                    groupBoxUser.Show();
                }
            }
            else
            {
                MessageBox.Show("올바르지 않은 정보입니다.");
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃 합니다.");
            Reset();
            groupBoxLogin.Show();
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

        private void Sellkukbap(string goods)
        {
            bool check = DBManager.GetInstance().WriteQuery(
                "INSERT INTO `s5469394`.`Sales` (`날짜`, `국밥종류`, `판매자`) " +
                $"VALUES ('{dateTimePeeker.Value:yyyy-MM-dd HH:mm:ss}', '{goods}', '{User.GetInstance().ID}');");
            if (check) MessageBox.Show("판매하였습니다.");
            else MessageBox.Show("판매하지 못하였습니다.");
        }

        private void buttonUserDaySell_Click(object sender, EventArgs e)
        {
            DataTable dt = DBManager.GetInstance().GetGrid(
                "SELECT DATE_FORMAT(s.날짜, '%Y-%m-%d') AS `판매일`, " +
                "s.판매자 AS `ID`, " +
                "COUNT(s.국밥종류) AS `판매량`, " +
                "SUM(g.가격) AS `판매액` " +
                "FROM s5469394.Sales s " +
                "INNER JOIN s5469394.Goods g " +
                "ON s.국밥종류 = g.국밥종류 " +
                "GROUP BY 판매일, s.판매자;");

            dataGridInfo.DataSource = dt;
        }

        private void buttonKukbapDaySell_Click(object sender, EventArgs e)
        {
            DataTable dt = DBManager.GetInstance().GetGrid(
                "SELECT DATE_FORMAT(s.날짜, '%Y-%m-%d') AS `판매일`, " +
                "s.국밥종류, " +
                "COUNT(s.국밥종류) AS `판매량`, " +
                "SUM(g.가격) AS `판매액` " +
                "FROM s5469394.Sales s " +
                "INNER JOIN s5469394.Goods g " +
                "ON s.국밥종류 = g.국밥종류 " +
                "GROUP BY 판매일, s.국밥종류;");

            dataGridInfo.DataSource = dt;
        }

        private void buttonKukbapMonthSell_Click(object sender, EventArgs e)
        {
            DataTable dt = DBManager.GetInstance().GetGrid(
                "SELECT DATE_FORMAT(s.날짜, '%Y-%m') AS `판매일`, " +
                "s.국밥종류, " +
                "COUNT(s.국밥종류) AS `판매량`, " +
                "SUM(g.가격) AS `판매액` " +
                "FROM s5469394.Sales s " +
                "INNER JOIN s5469394.Goods g " +
                "ON s.국밥종류 = g.국밥종류 " +
                "GROUP BY 판매일, s.국밥종류;");

            dataGridInfo.DataSource = dt;
        }
    }
}