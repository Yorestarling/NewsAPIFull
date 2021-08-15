
namespace NewsFormsAdmin.InsideForms.Countries
{
    partial class AddCountries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCountries));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCountry = new System.Windows.Forms.Button();
            this.BtnToMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCountry
            // 
            this.BtnCountry.BackColor = System.Drawing.Color.Teal;
            this.BtnCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCountry.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCountry.Location = new System.Drawing.Point(376, 255);
            this.BtnCountry.Name = "BtnCountry";
            this.BtnCountry.Size = new System.Drawing.Size(155, 59);
            this.BtnCountry.TabIndex = 54;
            this.BtnCountry.Text = "Add Country";
            this.BtnCountry.UseVisualStyleBackColor = false;
            // 
            // BtnToMenu
            // 
            this.BtnToMenu.BackColor = System.Drawing.Color.Crimson;
            this.BtnToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnToMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnToMenu.Location = new System.Drawing.Point(26, 375);
            this.BtnToMenu.Name = "BtnToMenu";
            this.BtnToMenu.Size = new System.Drawing.Size(155, 59);
            this.BtnToMenu.TabIndex = 53;
            this.BtnToMenu.Text = "BACK TO MENU";
            this.BtnToMenu.UseVisualStyleBackColor = false;
            this.BtnToMenu.Click += new System.EventHandler(this.BtnToMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "Country Name:";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(301, 206);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(299, 27);
            this.txtCountry.TabIndex = 51;
            // 
            // AddCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCountry);
            this.Controls.Add(this.BtnToMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCountry);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "AddCountries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCountries";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCountry;
        private System.Windows.Forms.Button BtnToMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCountry;
    }
}