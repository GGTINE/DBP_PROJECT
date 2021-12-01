
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
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonMenuChange = new System.Windows.Forms.Button();
            this.groupBoxUserLogout = new System.Windows.Forms.GroupBox();
            this.labelUserName = new System.Windows.Forms.Label();
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
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(225, 22);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "로그아웃";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonMenuChange
            // 
            this.buttonMenuChange.Location = new System.Drawing.Point(709, 94);
            this.buttonMenuChange.Name = "buttonMenuChange";
            this.buttonMenuChange.Size = new System.Drawing.Size(61, 27);
            this.buttonMenuChange.TabIndex = 18;
            this.buttonMenuChange.Text = "메뉴";
            this.buttonMenuChange.UseVisualStyleBackColor = true;
            this.buttonMenuChange.Click += new System.EventHandler(this.buttonMenuChange_Click);
            // 
            // groupBoxUserLogout
            // 
            this.groupBoxUserLogout.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxUserLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxUserLogout.Controls.Add(this.labelUserName);
            this.groupBoxUserLogout.Controls.Add(this.buttonLogOut);
            this.groupBoxUserLogout.Location = new System.Drawing.Point(462, 12);
            this.groupBoxUserLogout.Name = "groupBoxUserLogout";
            this.groupBoxUserLogout.Size = new System.Drawing.Size(308, 64);
            this.groupBoxUserLogout.TabIndex = 15;
            this.groupBoxUserLogout.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(18, 26);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 15);
            this.labelUserName.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUserDaysSell);
            this.tabControl1.Controls.Add(this.tabPageGoodsDaysSell);
            this.tabControl1.Controls.Add(this.tabPageGoodsMonthSell);
            this.tabControl1.Controls.Add(this.tabPageCheckLog);
            this.tabControl1.Location = new System.Drawing.Point(51, 100);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 23);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageUserDaysSell
            // 
            this.tabPageUserDaysSell.Location = new System.Drawing.Point(4, 24);
            this.tabPageUserDaysSell.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageUserDaysSell.Name = "tabPageUserDaysSell";
            this.tabPageUserDaysSell.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageUserDaysSell.Size = new System.Drawing.Size(380, 0);
            this.tabPageUserDaysSell.TabIndex = 0;
            this.tabPageUserDaysSell.Text = "일간 유저 판매";
            this.tabPageUserDaysSell.UseVisualStyleBackColor = true;
            // 
            // tabPageGoodsDaysSell
            // 
            this.tabPageGoodsDaysSell.Location = new System.Drawing.Point(4, 24);
            this.tabPageGoodsDaysSell.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageGoodsDaysSell.Name = "tabPageGoodsDaysSell";
            this.tabPageGoodsDaysSell.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageGoodsDaysSell.Size = new System.Drawing.Size(380, 0);
            this.tabPageGoodsDaysSell.TabIndex = 1;
            this.tabPageGoodsDaysSell.Text = "일간 국밥 판매";
            this.tabPageGoodsDaysSell.UseVisualStyleBackColor = true;
            // 
            // tabPageGoodsMonthSell
            // 
            this.tabPageGoodsMonthSell.Location = new System.Drawing.Point(4, 24);
            this.tabPageGoodsMonthSell.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageGoodsMonthSell.Name = "tabPageGoodsMonthSell";
            this.tabPageGoodsMonthSell.Size = new System.Drawing.Size(380, 0);
            this.tabPageGoodsMonthSell.TabIndex = 2;
            this.tabPageGoodsMonthSell.Text = "월간 국밥 판매";
            this.tabPageGoodsMonthSell.UseVisualStyleBackColor = true;
            // 
            // tabPageCheckLog
            // 
            this.tabPageCheckLog.Location = new System.Drawing.Point(4, 24);
            this.tabPageCheckLog.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCheckLog.Name = "tabPageCheckLog";
            this.tabPageCheckLog.Size = new System.Drawing.Size(380, 0);
            this.tabPageCheckLog.TabIndex = 3;
            this.tabPageCheckLog.Text = "로그 확인";
            this.tabPageCheckLog.UseVisualStyleBackColor = true;
            // 
            // dataGridInfo
            // 
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.Location = new System.Drawing.Point(54, 127);
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.RowHeadersWidth = 51;
            this.dataGridInfo.RowTemplate.Height = 25;
            this.dataGridInfo.Size = new System.Drawing.Size(716, 374);
            this.dataGridInfo.TabIndex = 12;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.dataGridInfo);
            this.Controls.Add(this.buttonMenuChange);
            this.Controls.Add(this.groupBoxUserLogout);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "B";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.groupBoxUserLogout.ResumeLayout(false);
            this.groupBoxUserLogout.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLogOut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxUserLogout;
        private System.Windows.Forms.Button buttonMenuChange;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUserDaysSell;
        private System.Windows.Forms.DataGridView dataGridInfo;
        private System.Windows.Forms.TabPage tabPageGoodsDaysSell;
        private System.Windows.Forms.TabPage tabPageGoodsMonthSell;
        private System.Windows.Forms.TabPage tabPageCheckLog;
        private System.Windows.Forms.Label labelUserName;
    }
}

