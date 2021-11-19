
namespace DBP_PROJECT
{
    partial class Main
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
            this.dataGridInfo = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonPigkukbap = new System.Windows.Forms.Button();
            this.buttonCowheadkukbap = new System.Windows.Forms.Button();
            this.buttonSundaekukbap = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.dateTimePeeker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.groupBoxUserLogout = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).BeginInit();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxAdmin.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxUserLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridInfo
            // 
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.Location = new System.Drawing.Point(14, 22);
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.RowTemplate.Height = 25;
            this.dataGridInfo.Size = new System.Drawing.Size(635, 176);
            this.dataGridInfo.TabIndex = 12;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(53, 22);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 0;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(213, 22);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(100, 23);
            this.textBoxPW.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(28, 26);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(19, 15);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(18, 25);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 15);
            this.labelUserName.TabIndex = 4;
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
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(349, 23);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonPigkukbap
            // 
            this.buttonPigkukbap.Location = new System.Drawing.Point(14, 104);
            this.buttonPigkukbap.Name = "buttonPigkukbap";
            this.buttonPigkukbap.Size = new System.Drawing.Size(127, 42);
            this.buttonPigkukbap.TabIndex = 9;
            this.buttonPigkukbap.Text = "돼지국밥";
            this.buttonPigkukbap.UseVisualStyleBackColor = true;
            this.buttonPigkukbap.Click += new System.EventHandler(this.buttonPigkukbap_Click);
            // 
            // buttonCowheadkukbap
            // 
            this.buttonCowheadkukbap.Location = new System.Drawing.Point(280, 104);
            this.buttonCowheadkukbap.Name = "buttonCowheadkukbap";
            this.buttonCowheadkukbap.Size = new System.Drawing.Size(127, 42);
            this.buttonCowheadkukbap.TabIndex = 10;
            this.buttonCowheadkukbap.Text = "소머리국밥";
            this.buttonCowheadkukbap.UseVisualStyleBackColor = true;
            this.buttonCowheadkukbap.Click += new System.EventHandler(this.buttonCowheadkukbap_Click);
            // 
            // buttonSundaekukbap
            // 
            this.buttonSundaekukbap.Location = new System.Drawing.Point(537, 104);
            this.buttonSundaekukbap.Name = "buttonSundaekukbap";
            this.buttonSundaekukbap.Size = new System.Drawing.Size(127, 42);
            this.buttonSundaekukbap.TabIndex = 11;
            this.buttonSundaekukbap.Text = "순대국밥";
            this.buttonSundaekukbap.UseVisualStyleBackColor = true;
            this.buttonSundaekukbap.Click += new System.EventHandler(this.buttonSundaekukbap_Click);
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.dateTimePeeker);
            this.groupBoxUser.Controls.Add(this.buttonPigkukbap);
            this.groupBoxUser.Controls.Add(this.buttonSundaekukbap);
            this.groupBoxUser.Controls.Add(this.buttonCowheadkukbap);
            this.groupBoxUser.Location = new System.Drawing.Point(37, 82);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(670, 152);
            this.groupBoxUser.TabIndex = 13;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "캐셔용화면";
            // 
            // dateTimePeeker
            // 
            this.dateTimePeeker.CustomFormat = "";
            this.dateTimePeeker.Location = new System.Drawing.Point(14, 34);
            this.dateTimePeeker.Name = "dateTimePeeker";
            this.dateTimePeeker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePeeker.TabIndex = 13;
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.dataGridInfo);
            this.groupBoxAdmin.Location = new System.Drawing.Point(37, 240);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(670, 209);
            this.groupBoxAdmin.TabIndex = 14;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "관리자화면";
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxLogin.Controls.Add(this.textBoxID);
            this.groupBoxLogin.Controls.Add(this.textBoxPW);
            this.groupBoxLogin.Controls.Add(this.ID);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Location = new System.Drawing.Point(37, 12);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(439, 64);
            this.groupBoxLogin.TabIndex = 14;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "로그인";
            // 
            // groupBoxUserLogout
            // 
            this.groupBoxUserLogout.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxUserLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxUserLogout.Controls.Add(this.buttonLogOut);
            this.groupBoxUserLogout.Controls.Add(this.labelUserName);
            this.groupBoxUserLogout.Location = new System.Drawing.Point(482, 12);
            this.groupBoxUserLogout.Name = "groupBoxUserLogout";
            this.groupBoxUserLogout.Size = new System.Drawing.Size(306, 64);
            this.groupBoxUserLogout.TabIndex = 15;
            this.groupBoxUserLogout.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxUserLogout);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.groupBoxUser);
            this.Name = "Main";
            this.Text = "B";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxUserLogout.ResumeLayout(false);
            this.groupBoxUserLogout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonPigkukbap;
        private System.Windows.Forms.Button buttonCowheadkukbap;
        private System.Windows.Forms.Button buttonSundaekukbap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridInfo;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.DateTimePicker dateTimePeeker;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.GroupBox groupBoxUserLogout;
    }
}

