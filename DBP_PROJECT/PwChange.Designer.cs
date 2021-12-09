
namespace DBP_PROJECT
{
    partial class PwChange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelCheckPw = new System.Windows.Forms.Label();
            this.buttonChangePW = new System.Windows.Forms.Button();
            this.textBoxCurPW = new System.Windows.Forms.TextBox();
            this.textBoxNewPW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNewPWOK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelCheckPw);
            this.groupBox3.Controls.Add(this.buttonChangePW);
            this.groupBox3.Controls.Add(this.textBoxCurPW);
            this.groupBox3.Controls.Add(this.textBoxNewPW);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxNewPWOK);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(27, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 184);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "비밀번호 변경";
            // 
            // labelCheckPw
            // 
            this.labelCheckPw.AutoSize = true;
            this.labelCheckPw.Location = new System.Drawing.Point(157, 132);
            this.labelCheckPw.Name = "labelCheckPw";
            this.labelCheckPw.Size = new System.Drawing.Size(110, 15);
            this.labelCheckPw.TabIndex = 24;
            this.labelCheckPw.Text = "일치하지 않습니다!";
            // 
            // buttonChangePW
            // 
            this.buttonChangePW.Location = new System.Drawing.Point(270, 155);
            this.buttonChangePW.Name = "buttonChangePW";
            this.buttonChangePW.Size = new System.Drawing.Size(75, 23);
            this.buttonChangePW.TabIndex = 22;
            this.buttonChangePW.Text = "변경";
            this.buttonChangePW.UseVisualStyleBackColor = true;
            this.buttonChangePW.Click += new System.EventHandler(this.buttonChangePW_Click);
            // 
            // textBoxCurPW
            // 
            this.textBoxCurPW.Location = new System.Drawing.Point(123, 37);
            this.textBoxCurPW.MaxLength = 20;
            this.textBoxCurPW.Name = "textBoxCurPW";
            this.textBoxCurPW.PasswordChar = '*';
            this.textBoxCurPW.Size = new System.Drawing.Size(195, 23);
            this.textBoxCurPW.TabIndex = 2;
            // 
            // textBoxNewPW
            // 
            this.textBoxNewPW.Location = new System.Drawing.Point(123, 71);
            this.textBoxNewPW.MaxLength = 20;
            this.textBoxNewPW.Name = "textBoxNewPW";
            this.textBoxNewPW.PasswordChar = '*';
            this.textBoxNewPW.PlaceholderText = "비밀번호를 입력하세요!";
            this.textBoxNewPW.Size = new System.Drawing.Size(195, 23);
            this.textBoxNewPW.TabIndex = 13;
            this.textBoxNewPW.Tag = "";
            this.textBoxNewPW.TextChanged += new System.EventHandler(this.textBoxNewPW_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "비밀번호 확인";
            // 
            // textBoxNewPWOK
            // 
            this.textBoxNewPWOK.Location = new System.Drawing.Point(123, 106);
            this.textBoxNewPWOK.MaxLength = 20;
            this.textBoxNewPWOK.Name = "textBoxNewPWOK";
            this.textBoxNewPWOK.PasswordChar = '*';
            this.textBoxNewPWOK.Size = new System.Drawing.Size(195, 23);
            this.textBoxNewPWOK.TabIndex = 14;
            this.textBoxNewPWOK.TextChanged += new System.EventHandler(this.textBoxNewPWOK_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "현재 비밀번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "새로운 비밀번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "8자리 이상 14자리 이하 : 영어 대문자, 소문자, 숫자, 특수문자 포함";
            // 
            // PwChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Name = "PwChange";
            this.Text = "PwChange";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelCheckPw;
        private System.Windows.Forms.Button buttonChangePW;
        private System.Windows.Forms.TextBox textBoxCurPW;
        private System.Windows.Forms.TextBox textBoxNewPW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNewPWOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}