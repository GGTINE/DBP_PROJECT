
namespace DBP_PROJECT
{
    partial class Admin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonMenuChange = new System.Windows.Forms.Button();
            this.buttonUserLog = new System.Windows.Forms.Button();
            this.buttonKukbapMonthSell = new System.Windows.Forms.Button();
            this.buttonKukbapDaySell = new System.Windows.Forms.Button();
            this.buttonUserDaySell = new System.Windows.Forms.Button();
            this.groupBoxUserLogout = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUserDaysSell = new System.Windows.Forms.TabPage();
            this.tabPageGoodsDaysSell = new System.Windows.Forms.TabPage();
            this.tabPageGoodsMonthSell = new System.Windows.Forms.TabPage();
            this.tabPageCheckLog = new System.Windows.Forms.TabPage();
            this.dataGridInfo = new System.Windows.Forms.DataGridView();
            this.groupBoxUserLogout.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(23, 33);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 20);
            this.labelUserName.TabIndex = 4;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(289, 29);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(96, 31);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "로그아웃";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonMenuChange
            // 
            this.buttonMenuChange.Location = new System.Drawing.Point(912, 125);
            this.buttonMenuChange.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMenuChange.Name = "buttonMenuChange";
            this.buttonMenuChange.Size = new System.Drawing.Size(79, 36);
            this.buttonMenuChange.TabIndex = 18;
            this.buttonMenuChange.Text = "메뉴";
            this.buttonMenuChange.UseVisualStyleBackColor = true;
            this.buttonMenuChange.Click += new System.EventHandler(this.buttonMenuChange_Click);
            // 
            // buttonUserLog
            // 
            this.buttonUserLog.Location = new System.Drawing.Point(465, 46);
            this.buttonUserLog.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUserLog.Name = "buttonUserLog";
            this.buttonUserLog.Size = new System.Drawing.Size(129, 64);
            this.buttonUserLog.TabIndex = 16;
            this.buttonUserLog.Text = "로그 확인";
            this.buttonUserLog.UseVisualStyleBackColor = true;
            this.buttonUserLog.Click += new System.EventHandler(this.buttonUserLog_Click);
            // 
            // buttonKukbapMonthSell
            // 
            this.buttonKukbapMonthSell.Location = new System.Drawing.Point(328, 46);
            this.buttonKukbapMonthSell.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKukbapMonthSell.Name = "buttonKukbapMonthSell";
            this.buttonKukbapMonthSell.Size = new System.Drawing.Size(129, 64);
            this.buttonKukbapMonthSell.TabIndex = 15;
            this.buttonKukbapMonthSell.Text = "월간 국밥 판매";
            this.buttonKukbapMonthSell.UseVisualStyleBackColor = true;
            this.buttonKukbapMonthSell.Click += new System.EventHandler(this.buttonKukbapMonthSell_Click);
            // 
            // buttonKukbapDaySell
            // 
            this.buttonKukbapDaySell.Location = new System.Drawing.Point(197, 46);
            this.buttonKukbapDaySell.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKukbapDaySell.Name = "buttonKukbapDaySell";
            this.buttonKukbapDaySell.Size = new System.Drawing.Size(123, 64);
            this.buttonKukbapDaySell.TabIndex = 14;
            this.buttonKukbapDaySell.Text = "일간 국밥 판매";
            this.buttonKukbapDaySell.UseVisualStyleBackColor = true;
            this.buttonKukbapDaySell.Click += new System.EventHandler(this.buttonKukbapDaySell_Click);
            // 
            // buttonUserDaySell
            // 
            this.buttonUserDaySell.Location = new System.Drawing.Point(66, 46);
            this.buttonUserDaySell.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUserDaySell.Name = "buttonUserDaySell";
            this.buttonUserDaySell.Size = new System.Drawing.Size(123, 64);
            this.buttonUserDaySell.TabIndex = 13;
            this.buttonUserDaySell.Text = "일간 유저 판매";
            this.buttonUserDaySell.UseVisualStyleBackColor = true;
            this.buttonUserDaySell.Click += new System.EventHandler(this.buttonUserDaySell_Click);
            // 
            // groupBoxUserLogout
            // 
            this.groupBoxUserLogout.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxUserLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxUserLogout.Controls.Add(this.buttonLogOut);
            this.groupBoxUserLogout.Controls.Add(this.labelUserName);
            this.groupBoxUserLogout.Location = new System.Drawing.Point(623, 13);
            this.groupBoxUserLogout.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUserLogout.Name = "groupBoxUserLogout";
            this.groupBoxUserLogout.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUserLogout.Size = new System.Drawing.Size(393, 85);
            this.groupBoxUserLogout.TabIndex = 15;
            this.groupBoxUserLogout.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUserDaysSell);
            this.tabControl1.Controls.Add(this.tabPageGoodsDaysSell);
            this.tabControl1.Controls.Add(this.tabPageGoodsMonthSell);
            this.tabControl1.Controls.Add(this.tabPageCheckLog);
            this.tabControl1.Location = new System.Drawing.Point(66, 133);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 31);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageUserDaysSell
            // 
            this.tabPageUserDaysSell.Location = new System.Drawing.Point(4, 29);
            this.tabPageUserDaysSell.Name = "tabPageUserDaysSell";
            this.tabPageUserDaysSell.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserDaysSell.Size = new System.Drawing.Size(418, 0);
            this.tabPageUserDaysSell.TabIndex = 0;
            this.tabPageUserDaysSell.Text = "일간 유저 판매";
            this.tabPageUserDaysSell.UseVisualStyleBackColor = true;
            // 
            // tabPageGoodsDaysSell
            // 
            this.tabPageGoodsDaysSell.Location = new System.Drawing.Point(4, 29);
            this.tabPageGoodsDaysSell.Name = "tabPageGoodsDaysSell";
            this.tabPageGoodsDaysSell.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGoodsDaysSell.Size = new System.Drawing.Size(934, 0);
            this.tabPageGoodsDaysSell.TabIndex = 1;
            this.tabPageGoodsDaysSell.Text = "일간 국밥 판매";
            this.tabPageGoodsDaysSell.UseVisualStyleBackColor = true;
            // 
            // tabPageGoodsMonthSell
            // 
            this.tabPageGoodsMonthSell.Location = new System.Drawing.Point(4, 29);
            this.tabPageGoodsMonthSell.Name = "tabPageGoodsMonthSell";
            this.tabPageGoodsMonthSell.Size = new System.Drawing.Size(934, 0);
            this.tabPageGoodsMonthSell.TabIndex = 2;
            this.tabPageGoodsMonthSell.Text = "월간 국밥 판매";
            this.tabPageGoodsMonthSell.UseVisualStyleBackColor = true;
            // 
            // tabPageCheckLog
            // 
            this.tabPageCheckLog.Location = new System.Drawing.Point(4, 29);
            this.tabPageCheckLog.Name = "tabPageCheckLog";
            this.tabPageCheckLog.Size = new System.Drawing.Size(934, 0);
            this.tabPageCheckLog.TabIndex = 3;
            this.tabPageCheckLog.Text = "로그 확인";
            this.tabPageCheckLog.UseVisualStyleBackColor = true;
            // 
            // dataGridInfo
            // 
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.Location = new System.Drawing.Point(70, 169);
            this.dataGridInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.RowHeadersWidth = 51;
            this.dataGridInfo.RowTemplate.Height = 25;
            this.dataGridInfo.Size = new System.Drawing.Size(920, 499);
            this.dataGridInfo.TabIndex = 12;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 691);
            this.Controls.Add(this.dataGridInfo);
            this.Controls.Add(this.buttonMenuChange);
            this.Controls.Add(this.groupBoxUserLogout);
            this.Controls.Add(this.buttonUserLog);
            this.Controls.Add(this.buttonUserDaySell);
            this.Controls.Add(this.buttonKukbapMonthSell);
            this.Controls.Add(this.buttonKukbapDaySell);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "B";
            this.groupBoxUserLogout.ResumeLayout(false);
            this.groupBoxUserLogout.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonLogOut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxUserLogout;
        private System.Windows.Forms.Button buttonKukbapMonthSell;
        private System.Windows.Forms.Button buttonKukbapDaySell;
        private System.Windows.Forms.Button buttonUserDaySell;
        private System.Windows.Forms.Button buttonUserLog;
        private System.Windows.Forms.Button buttonMenuChange;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUserDaysSell;
        private System.Windows.Forms.DataGridView dataGridInfo;
        private System.Windows.Forms.TabPage tabPageGoodsDaysSell;
        private System.Windows.Forms.TabPage tabPageGoodsMonthSell;
        private System.Windows.Forms.TabPage tabPageCheckLog;
    }
}

