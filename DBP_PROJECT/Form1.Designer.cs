
namespace DBP_PROJECT
{
    partial class Form1
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
            this.buttonMeal1 = new System.Windows.Forms.Button();
            this.buttonMeal2 = new System.Windows.Forms.Button();
            this.buttonMeal3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.dateTimePeeker = new System.Windows.Forms.DateTimePicker();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).BeginInit();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridInfo
            // 
            this.dataGridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInfo.Location = new System.Drawing.Point(14, 48);
            this.dataGridInfo.Name = "dataGridInfo";
            this.dataGridInfo.RowTemplate.Height = 25;
            this.dataGridInfo.Size = new System.Drawing.Size(635, 150);
            this.dataGridInfo.TabIndex = 12;
           
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(37, 23);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 0;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(197, 23);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(100, 23);
            this.textBoxPW.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 27);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(19, 15);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(533, 27);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 15);
            this.labelUserName.TabIndex = 4;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(701, 23);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "로그아웃";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(333, 24);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonMeal1
            // 
            this.buttonMeal1.Location = new System.Drawing.Point(14, 104);
            this.buttonMeal1.Name = "buttonMeal1";
            this.buttonMeal1.Size = new System.Drawing.Size(127, 42);
            this.buttonMeal1.TabIndex = 9;
            this.buttonMeal1.Text = "국밥1";
            this.buttonMeal1.UseVisualStyleBackColor = true;
            this.buttonMeal1.Click += new System.EventHandler(this.buttonMeal1_Click);
            // 
            // buttonMeal2
            // 
            this.buttonMeal2.Location = new System.Drawing.Point(280, 104);
            this.buttonMeal2.Name = "buttonMeal2";
            this.buttonMeal2.Size = new System.Drawing.Size(127, 42);
            this.buttonMeal2.TabIndex = 10;
            this.buttonMeal2.Text = "국밥2";
            this.buttonMeal2.UseVisualStyleBackColor = true;
            this.buttonMeal2.Click += new System.EventHandler(this.buttonMeal2_Click);
            // 
            // buttonMeal3
            // 
            this.buttonMeal3.Location = new System.Drawing.Point(537, 104);
            this.buttonMeal3.Name = "buttonMeal3";
            this.buttonMeal3.Size = new System.Drawing.Size(127, 42);
            this.buttonMeal3.TabIndex = 11;
            this.buttonMeal3.Text = "국밥3";
            this.buttonMeal3.UseVisualStyleBackColor = true;
            this.buttonMeal3.Click += new System.EventHandler(this.buttonMeal3_Click);
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.dateTimePeeker);
            this.groupBoxUser.Controls.Add(this.buttonMeal1);
            this.groupBoxUser.Controls.Add(this.buttonMeal3);
            this.groupBoxUser.Controls.Add(this.buttonMeal2);
            this.groupBoxUser.Location = new System.Drawing.Point(37, 82);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(670, 152);
            this.groupBoxUser.TabIndex = 13;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "캐셔용화면";
            // 
            // dateTimePeeker
            // 
            this.dateTimePeeker.Location = new System.Drawing.Point(14, 34);
            this.dateTimePeeker.Name = "dateTimePeeker";
            this.dateTimePeeker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePeeker.TabIndex = 13;
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.buttonSearch);
            this.groupBoxAdmin.Controls.Add(this.dataGridInfo);
            this.groupBoxAdmin.Location = new System.Drawing.Point(37, 240);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(670, 209);
            this.groupBoxAdmin.TabIndex = 14;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "관리자화면";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(14, 22);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "조회";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBoxID);
            this.Name = "Form1";
            this.Text = "B";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInfo)).EndInit();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonMeal1;
        private System.Windows.Forms.Button buttonMeal2;
        private System.Windows.Forms.Button buttonMeal3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridInfo;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.DateTimePicker dateTimePeeker;
        private System.Windows.Forms.Button buttonSearch;
    }
}

