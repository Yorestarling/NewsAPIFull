
namespace NewsFormsAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLog = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(198, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(158, 197);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '⚫';
            this.TxtPassword.Size = new System.Drawing.Size(183, 27);
            this.TxtPassword.TabIndex = 2;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(158, 126);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(183, 27);
            this.TxtUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username:";
            // 
            // BtnLog
            // 
            this.BtnLog.BackColor = System.Drawing.Color.Teal;
            this.BtnLog.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BtnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLog.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLog.Location = new System.Drawing.Point(187, 280);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(113, 43);
            this.BtnLog.TabIndex = 3;
            this.BtnLog.Text = "Log In";
            this.BtnLog.UseVisualStyleBackColor = false;
            this.BtnLog.Click += new System.EventHandler(this.button1_Click);
            this.BtnLog.DragEnter += new System.Windows.Forms.DragEventHandler(this.BtnLog_DragEnter);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegister.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRegister.Location = new System.Drawing.Point(402, 280);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(143, 43);
            this.BtnRegister.TabIndex = 12;
            this.BtnRegister.Text = "Sign up Now";
            this.BtnRegister.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(591, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(609, 423);
            this.MinimumSize = new System.Drawing.Size(609, 423);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLog;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}