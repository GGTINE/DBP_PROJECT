using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_PROJECT
{
    public partial class PwChange : Form
    {
        public PwChange()
        {
            InitializeComponent();
        }
        private bool CheckRegulPw(string pw)
        {
            // 길이 8 ~ 14 
            if (pw != null && pw.Length < 8 || pw.Length > 15)
            {
                return false;
            }
            Regex RegulPw = new(@"^(?=.*?[a-z]) (?=.*?[A-Z]) (?=.*?\d)(?=.*?[#?!@$%^&*-])[A-Za-z\d$@$!%?&].{8,14}$",
                        RegexOptions.IgnorePatternWhitespace);

            return RegulPw.IsMatch(pw);
        }
        private void buttonChangePW_Click(object sender, EventArgs e)
        {
            if (DBManager.GetInstance().Compare($"SELECT * FROM s5469394.User WHERE (Pw = '{User.GetInstance().Password}');", "Pw", User.GetInstance().Password) && (labelCheckPw.Text == "일치합니다!") && CheckRegulPw(textBoxNewPWOK.Text))
            {
                DBManager.GetInstance().WriteQuery($"UPDATE `s5469394`.`User` SET `Pw` = '{textBoxNewPWOK.Text}' WHERE (`Id` = '{User.GetInstance().ID}');");
                MessageBox.Show("변경이 완료되었습니다.");
                this.Close();
            }
            else
            {
                MessageBox.Show("변경 할 수 없습니다!");
            }
        }

        private void textBoxNewPW_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewPW.Text == textBoxNewPWOK.Text)
            {
                labelCheckPw.Text = "일치합니다!";
            }
            else
            {
                labelCheckPw.Text = "일치하지 않습니다!";
            }
        }

        private void textBoxNewPWOK_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxNewPW.Text == textBoxNewPWOK.Text))
            {
                labelCheckPw.Text = "일치합니다!";
            }
            else
            {
                labelCheckPw.Text = "일치하지 않습니다!";
            }
        }
    }
}