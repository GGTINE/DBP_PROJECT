﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SingleUser(string id)
        {
            var UserInfo = DBManager.GetInstance().select_line($"SELECT * FROM s5469394.User WHERE (id = '{id}');");
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
                labelUserName.Text = $"{User.GetInstance().Name}님 반갑습니다.";
            }
            else
            {
                MessageBox.Show("올바르지 않은 정보입니다.");
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃 합니다.");
            this.Close();
        }

        private void buttonMeal1_Click(object sender, EventArgs e)
        {
            DBManager.GetInstance().Throw_Query($"INSERT INTO `s5469394`.`Sales` (`날짜`, `국밥종류`, `판매자`) " +
                $"VALUES ('{dateTimePeeker.Value}', '{buttonMeal1.Text}', '{User.GetInstance().ID}');");
        }

        private void buttonMeal2_Click(object sender, EventArgs e)
        {
            DBManager.GetInstance().Throw_Query($"INSERT INTO `s5469394`.`Sales` (`날짜`, `국밥종류`, `판매자`) " +
                $"VALUES ('{dateTimePeeker.Value}', '{buttonMeal2.Text}', '{User.GetInstance().ID}');");
        }

        private void buttonMeal3_Click(object sender, EventArgs e)
        {
            DBManager.GetInstance().Throw_Query($"INSERT INTO `s5469394`.`Sales` (`날짜`, `국밥종류`, `판매자`) " +
                $"VALUES ('{dateTimePeeker.Value}', '{buttonMeal3.Text}', '{User.GetInstance().ID}');");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = DBManager.GetInstance().SELECT(
                "Select 판매자, COUNT(국밥종류) AS 판매량 from s5469394.Sales GROUP BY 국밥종류");
            dataGridInfo.DataSource = dt;
        }
    }
}