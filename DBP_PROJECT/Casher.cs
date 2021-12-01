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
        int CheckLogout = 0;
        public Casher()
        {
            InitializeComponent();
            labelUserName.Text = User.GetInstance().Name + "님 반갑습니다.";
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

        private void Sellkukbap(string goods)
        {
            bool check = DBManager.GetInstance().WriteQuery(
                "INSERT INTO `s5469394`.`Sales` (`날짜`, `국밥종류`, `판매자`) " +
                $"VALUES ('{dateTimePeeker.Value:yyyy-MM-dd HH:mm:ss}', '{goods}', '{User.GetInstance().ID}');");
            if (check) MessageBox.Show("판매하였습니다.");
            else MessageBox.Show("판매하지 못하였습니다.");
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
    }
}
