
namespace DBP_PROJECT
{
    partial class Casher
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
            this.groupBoxUserLogout = new System.Windows.Forms.GroupBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.dateTimePeeker = new System.Windows.Forms.DateTimePicker();
            this.buttonPigkukbap = new System.Windows.Forms.Button();
            this.buttonSundaekukbap = new System.Windows.Forms.Button();
            this.buttonCowheadkukbap = new System.Windows.Forms.Button();
            this.groupBoxUserLogout.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUserLogout
            // 
            this.groupBoxUserLogout.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxUserLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxUserLogout.Controls.Add(this.buttonLogOut);
            this.groupBoxUserLogout.Controls.Add(this.labelUserName);
            this.groupBoxUserLogout.Location = new System.Drawing.Point(692, 13);
            this.groupBoxUserLogout.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUserLogout.Name = "groupBoxUserLogout";
            this.groupBoxUserLogout.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUserLogout.Size = new System.Drawing.Size(419, 85);
            this.groupBoxUserLogout.TabIndex = 17;
            this.groupBoxUserLogout.TabStop = false;
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
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(24, 34);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 20);
            this.labelUserName.TabIndex = 4;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.dateTimePeeker);
            this.groupBoxUser.Controls.Add(this.buttonPigkukbap);
            this.groupBoxUser.Controls.Add(this.buttonSundaekukbap);
            this.groupBoxUser.Controls.Add(this.buttonCowheadkukbap);
            this.groupBoxUser.Location = new System.Drawing.Point(89, 201);
            this.groupBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUser.Size = new System.Drawing.Size(887, 203);
            this.groupBoxUser.TabIndex = 16;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "판매";
            // 
            // dateTimePeeker
            // 
            this.dateTimePeeker.CustomFormat = "";
            this.dateTimePeeker.Location = new System.Drawing.Point(18, 45);
            this.dateTimePeeker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePeeker.Name = "dateTimePeeker";
            this.dateTimePeeker.Size = new System.Drawing.Size(256, 27);
            this.dateTimePeeker.TabIndex = 13;
            // 
            // buttonPigkukbap
            // 
            this.buttonPigkukbap.Location = new System.Drawing.Point(18, 139);
            this.buttonPigkukbap.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPigkukbap.Name = "buttonPigkukbap";
            this.buttonPigkukbap.Size = new System.Drawing.Size(163, 56);
            this.buttonPigkukbap.TabIndex = 9;
            this.buttonPigkukbap.Text = "돼지국밥";
            this.buttonPigkukbap.UseVisualStyleBackColor = true;
            // 
            // buttonSundaekukbap
            // 
            this.buttonSundaekukbap.Location = new System.Drawing.Point(690, 139);
            this.buttonSundaekukbap.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSundaekukbap.Name = "buttonSundaekukbap";
            this.buttonSundaekukbap.Size = new System.Drawing.Size(163, 56);
            this.buttonSundaekukbap.TabIndex = 11;
            this.buttonSundaekukbap.Text = "순대국밥";
            this.buttonSundaekukbap.UseVisualStyleBackColor = true;
            // 
            // buttonCowheadkukbap
            // 
            this.buttonCowheadkukbap.Location = new System.Drawing.Point(360, 139);
            this.buttonCowheadkukbap.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCowheadkukbap.Name = "buttonCowheadkukbap";
            this.buttonCowheadkukbap.Size = new System.Drawing.Size(163, 56);
            this.buttonCowheadkukbap.TabIndex = 10;
            this.buttonCowheadkukbap.Text = "소머리국밥";
            this.buttonCowheadkukbap.UseVisualStyleBackColor = true;
            // 
            // Casher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.groupBoxUserLogout);
            this.Controls.Add(this.groupBoxUser);
            this.Name = "Casher";
            this.Text = "Casher";
            this.groupBoxUserLogout.ResumeLayout(false);
            this.groupBoxUserLogout.PerformLayout();
            this.groupBoxUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUserLogout;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.DateTimePicker dateTimePeeker;
        private System.Windows.Forms.Button buttonPigkukbap;
        private System.Windows.Forms.Button buttonSundaekukbap;
        private System.Windows.Forms.Button buttonCowheadkukbap;
    }
}