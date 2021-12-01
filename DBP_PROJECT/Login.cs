using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace DBP_PROJECT
{
    public partial class Login : Form
    {
        public static Login Loginform;
        public Login()
        {
            InitializeComponent();
        }
        private void StartForm()
        {
            this.Show();
            reset();
        }
        private void reset()
        {
            textBoxID.Text = "";
            textBoxPW.Text = "";
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
                WriteLog();
                MessageBox.Show("로그인에 성공하였습니다.");
                this.Hide();
                if (User.GetInstance().Name == "관리자")
                {
                    Admin admin = new();
                    admin.ShowDialog();
                }
                else
                {
                    Casher casher = new();
                    casher.ShowDialog();
                }
                StartForm();
            }
            else
            {
                MessageBox.Show("올바르지 않은 정보입니다.");
            }
        }
        private void WriteLog()
        {
            DBManager.GetInstance().WriteQuery(
                "INSERT INTO `s5469394`.`Log` (`id`, `log`, `state`) " +
                $"VALUES ('{User.GetInstance().ID}', '{DateTime.Now:yyyy-MM-dd-HH-mm-ss}', '로그인');");
        }
    }
}
