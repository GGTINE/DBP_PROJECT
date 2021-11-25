
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
            this.groupBoxLogin.Location = new System.Drawing.Point(69, 38);
            this.groupBoxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLogin.Size = new System.Drawing.Size(277, 332);
            this.groupBoxLogin.TabIndex = 15;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "로그인";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(81, 83);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(127, 27);
            this.textBoxID.TabIndex = 0;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(81, 135);
            this.textBoxPW.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(127, 27);
            this.textBoxPW.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(49, 86);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 20);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(91, 231);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(96, 31);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 404);
            this.Controls.Add(this.groupBoxLogin);
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