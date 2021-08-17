
namespace NewsFormsAdmin.InsideForms.Sources
{
    partial class AddSource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSource));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSource = new System.Windows.Forms.Button();
            this.BtnToMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSource
            // 
            this.BtnSource.BackColor = System.Drawing.Color.Teal;
            this.BtnSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSource.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSource.Location = new System.Drawing.Point(367, 261);
            this.BtnSource.Name = "BtnSource";
            this.BtnSource.Size = new System.Drawing.Size(155, 59);
            this.BtnSource.TabIndex = 59;
            this.BtnSource.Text = "Add Country";
            this.BtnSource.UseVisualStyleBackColor = false;
            this.BtnSource.Click += new System.EventHandler(this.BtnSource_Click);
            // 
            // BtnToMenu
            // 
            this.BtnToMenu.BackColor = System.Drawing.Color.Crimson;
            this.BtnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnToMenu.Location = new System.Drawing.Point(12, 379);
            this.BtnToMenu.Name = "BtnToMenu";
            this.BtnToMenu.Size = new System.Drawing.Size(155, 59);
            this.BtnToMenu.TabIndex = 58;
            this.BtnToMenu.Text = "BACK TO MENU";
            this.BtnToMenu.UseVisualStyleBackColor = false;
            this.BtnToMenu.Click += new System.EventHandler(this.BtnToMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 57;
            this.label1.Text = "Source Name:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(292, 212);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(299, 27);
            this.txtSource.TabIndex = 56;
            // 
            // AddSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSource);
            this.Controls.Add(this.BtnToMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSource);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "AddSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSource";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSource;
        private System.Windows.Forms.Button BtnToMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
    }
}