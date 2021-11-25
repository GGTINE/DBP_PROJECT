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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private void WriteLog()
        {
            DBManager.GetInstance().WriteQuery(
                "INSERT INTO `s5469394`.`Log` (`id`, `log`, `state`) " +
                $"VALUES ('{User.GetInstance().ID}', '{DateTime.Now:yyyy-MM-dd-HH-mm-ss}', '로그아웃');");
        }
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            WriteLog();
            MessageBox.Show("로그아웃 합니다.");
            this.Close();
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

        private void buttonUserLog_Click(object sender, EventArgs e)
        {
            DataTable dt = DBManager.GetInstance().GetGrid(
                "SELECT * FROM s5469394.Log;");
            dataGridInfo.DataSource = dt;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt;
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    dt = DBManager.GetInstance().GetGrid(
                        "SELECT DATE_FORMAT(s.날짜, '%Y-%m-%d') AS `판매일`, " +
                        "s.판매자 AS `ID`, " +
                        "COUNT(s.국밥종류) AS `판매량`, " +
                        "SUM(g.가격) AS `판매액` " +
                        "FROM s5469394.Sales s " +
                        "INNER JOIN s5469394.Goods g " +
                        "ON s.국밥종류 = g.국밥종류 " +
                        "GROUP BY 판매일, s.판매자;");
                    dataGridInfo.DataSource = dt;
                    break;

                case 1:
                    dt = DBManager.GetInstance().GetGrid(
                        "SELECT DATE_FORMAT(s.날짜, '%Y-%m-%d') AS `판매일`, " +
                        "s.국밥종류, " +
                        "COUNT(s.국밥종류) AS `판매량`, " +
                        "SUM(g.가격) AS `판매액` " +
                        "FROM s5469394.Sales s " +
                        "INNER JOIN s5469394.Goods g " +
                        "ON s.국밥종류 = g.국밥종류 " +
                        "GROUP BY 판매일, s.국밥종류;");

                    dataGridInfo.DataSource = dt;
                    break;

                case 2:
                    dt = DBManager.GetInstance().GetGrid(
                        "SELECT DATE_FORMAT(s.날짜, '%Y-%m') AS `판매일`, " +
                        "s.국밥종류, " +
                        "COUNT(s.국밥종류) AS `판매량`, " +
                        "SUM(g.가격) AS `판매액` " +
                        "FROM s5469394.Sales s " +
                        "INNER JOIN s5469394.Goods g " +
                        "ON s.국밥종류 = g.국밥종류 " +
                        "GROUP BY 판매일, s.국밥종류;");

                    dataGridInfo.DataSource = dt;
                    break;
                case 3:
                    dt = DBManager.GetInstance().GetGrid(
                        "SELECT * FROM s5469394.Log;");
                    dataGridInfo.DataSource = dt;
                    break;
            }
        }
    }
}