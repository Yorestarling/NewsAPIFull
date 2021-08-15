
namespace NewsFormsAdmin.InsideForms.Authors
{
    partial class Authors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authors));
            this.button1 = new System.Windows.Forms.Button();
            this.btnAuthorlis = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnAuthors = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(12, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 59);
            this.button1.TabIndex = 40;
            this.button1.Text = "BACK TO MENU";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAuthorlis
            // 
            this.btnAuthorlis.BackColor = System.Drawing.Color.Teal;
            this.btnAuthorlis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthorlis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAuthorlis.Location = new System.Drawing.Point(590, 294);
            this.btnAuthorlis.Name = "btnAuthorlis";
            this.btnAuthorlis.Size = new System.Drawing.Size(155, 59);
            this.btnAuthorlis.TabIndex = 38;
            this.btnAuthorlis.Text = " Author List";
            this.btnAuthorlis.UseVisualStyleBackColor = false;
            this.btnAuthorlis.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(590, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(155, 155);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // BtnAuthors
            // 
            this.BtnAuthors.BackColor = System.Drawing.Color.Teal;
            this.BtnAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAuthors.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAuthors.Location = new System.Drawing.Point(226, 294);
            this.BtnAuthors.Name = "BtnAuthors";
            this.BtnAuthors.Size = new System.Drawing.Size(155, 59);
            this.BtnAuthors.TabIndex = 43;
            this.BtnAuthors.Text = "Add Authors";
            this.BtnAuthors.UseVisualStyleBackColor = false;
            this.BtnAuthors.Click += new System.EventHandler(this.BtnAuthors_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(948, 481);
            this.Controls.Add(this.BtnAuthors);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAuthorlis);
            this.Controls.Add(this.pictureBox3);
            this.MaximumSize = new System.Drawing.Size(966, 528);
            this.MinimumSize = new System.Drawing.Size(966, 528);
            this.Name = "Authors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAuthorlis;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnAuthors;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}