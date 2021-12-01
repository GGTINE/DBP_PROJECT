
namespace DBP_PROJECT
{
    partial class Login
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
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxLogin.Controls.Add(this.textBoxID);
            this.groupBoxLogin.Controls.Add(this.textBoxPW);
            this.groupBoxLogin.Controls.Add(this.ID);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.label2);
            this.groupBoxLogin.Location = new System.Drawing.Point(54, 28);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(215, 249);
            this.groupBoxLogin.TabIndex = 15;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "로그인";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(63, 62);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 0;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(63, 101);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.PasswordChar = '*';
            this.textBoxPW.Size = new System.Drawing.Size(100, 23);
            this.textBoxPW.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(38, 64);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(19, 15);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(71, 173);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 303);
            this.Controls.Add(this.groupBoxLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label2;
    }
}