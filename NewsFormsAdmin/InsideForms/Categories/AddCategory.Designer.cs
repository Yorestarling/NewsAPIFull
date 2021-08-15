
namespace NewsFormsAdmin.InsideForms.Categories
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btncategory = new System.Windows.Forms.Button();
            this.BtnToMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(327, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // Btncategory
            // 
            this.Btncategory.BackColor = System.Drawing.Color.Teal;
            this.Btncategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btncategory.Location = new System.Drawing.Point(370, 257);
            this.Btncategory.Name = "Btncategory";
            this.Btncategory.Size = new System.Drawing.Size(155, 59);
            this.Btncategory.TabIndex = 49;
            this.Btncategory.Text = "Add Category";
            this.Btncategory.UseVisualStyleBackColor = false;
            this.Btncategory.Click += new System.EventHandler(this.Btncategory_Click);
            // 
            // BtnToMenu
            // 
            this.BtnToMenu.BackColor = System.Drawing.Color.Crimson;
            this.BtnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnToMenu.Location = new System.Drawing.Point(20, 377);
            this.BtnToMenu.Name = "BtnToMenu";
            this.BtnToMenu.Size = new System.Drawing.Size(155, 59);
            this.BtnToMenu.TabIndex = 48;
            this.BtnToMenu.Text = "BACK TO MENU";
            this.BtnToMenu.UseVisualStyleBackColor = false;
            this.BtnToMenu.Click += new System.EventHandler(this.BtnToMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "Category Name:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(300, 194);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(299, 27);
            this.txtCategoryName.TabIndex = 46;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btncategory);
            this.Controls.Add(this.BtnToMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btncategory;
        private System.Windows.Forms.Button BtnToMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryName;
    }
}