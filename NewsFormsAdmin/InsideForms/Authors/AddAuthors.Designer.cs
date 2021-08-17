
namespace NewsFormsAdmin.InsideForms.Authors
{
    partial class AddAuthors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthors));
            this.TxtAuthors = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnToMenu = new System.Windows.Forms.Button();
            this.BtnAuthors = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAuthors
            // 
            this.TxtAuthors.Location = new System.Drawing.Point(292, 182);
            this.TxtAuthors.Name = "TxtAuthors";
            this.TxtAuthors.Size = new System.Drawing.Size(299, 27);
            this.TxtAuthors.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(116, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Author Name:";
            // 
            // BtnToMenu
            // 
            this.BtnToMenu.BackColor = System.Drawing.Color.Crimson;
            this.BtnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnToMenu.Location = new System.Drawing.Point(12, 379);
            this.BtnToMenu.Name = "BtnToMenu";
            this.BtnToMenu.Size = new System.Drawing.Size(155, 59);
            this.BtnToMenu.TabIndex = 41;
            this.BtnToMenu.Text = "BACK TO MENU";
            this.BtnToMenu.UseVisualStyleBackColor = false;
            this.BtnToMenu.Click += new System.EventHandler(this.BtnToMenu_Click);
            // 
            // BtnAuthors
            // 
            this.BtnAuthors.BackColor = System.Drawing.Color.Teal;
            this.BtnAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAuthors.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAuthors.Location = new System.Drawing.Point(364, 242);
            this.BtnAuthors.Name = "BtnAuthors";
            this.BtnAuthors.Size = new System.Drawing.Size(155, 59);
            this.BtnAuthors.TabIndex = 44;
            this.BtnAuthors.Text = "Add Authors";
            this.BtnAuthors.UseVisualStyleBackColor = false;
            this.BtnAuthors.Click += new System.EventHandler(this.BtnAuthors_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // AddAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnAuthors);
            this.Controls.Add(this.BtnToMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAuthors);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "AddAuthors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAuthors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAuthors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnToMenu;
        private System.Windows.Forms.Button BtnAuthors;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}