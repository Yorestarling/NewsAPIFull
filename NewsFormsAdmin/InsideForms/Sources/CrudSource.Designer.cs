
namespace NewsFormsAdmin.InsideForms.Sources
{
    partial class CrudSource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudSource));
            this.button1 = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnArticles = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(16, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 59);
            this.button1.TabIndex = 61;
            this.button1.Text = "BACK TO MENU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Teal;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCategories.Location = new System.Drawing.Point(566, 298);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(155, 59);
            this.btnCategories.TabIndex = 60;
            this.btnCategories.Text = "Source List";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(566, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 155);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // BtnArticles
            // 
            this.BtnArticles.BackColor = System.Drawing.Color.Teal;
            this.BtnArticles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArticles.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnArticles.Location = new System.Drawing.Point(245, 298);
            this.BtnArticles.Name = "BtnArticles";
            this.BtnArticles.Size = new System.Drawing.Size(155, 59);
            this.BtnArticles.TabIndex = 64;
            this.BtnArticles.Text = "Add Sources";
            this.BtnArticles.UseVisualStyleBackColor = false;
            this.BtnArticles.Click += new System.EventHandler(this.BtnArticles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // CrudSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(948, 481);
            this.Controls.Add(this.BtnArticles);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.pictureBox3);
            this.MaximumSize = new System.Drawing.Size(966, 528);
            this.MinimumSize = new System.Drawing.Size(966, 528);
            this.Name = "CrudSource";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Source";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnArticles;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}