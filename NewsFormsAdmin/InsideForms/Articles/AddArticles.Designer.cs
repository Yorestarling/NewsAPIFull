
namespace NewsFormsAdmin.InsideForms.Articles
{
    partial class AddArticles
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnBackToMenu = new System.Windows.Forms.Button();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.CbAuthor = new System.Windows.Forms.ComboBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblDescriptions = new System.Windows.Forms.Label();
            this.LblUrl = new System.Windows.Forms.Label();
            this.TxtDescriptions = new System.Windows.Forms.TextBox();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.LblCountry = new System.Windows.Forms.Label();
            this.CbCountry = new System.Windows.Forms.ComboBox();
            this.LblCategory = new System.Windows.Forms.Label();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.CbSources = new System.Windows.Forms.ComboBox();
            this.LblSource = new System.Windows.Forms.Label();
            this.LblUrlToImage = new System.Windows.Forms.Label();
            this.TxtUrlToImage = new System.Windows.Forms.TextBox();
            this.LblContent = new System.Windows.Forms.Label();
            this.TxtContent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Location = new System.Drawing.Point(846, 481);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(164, 58);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnBackToMenu
            // 
            this.BtnBackToMenu.BackColor = System.Drawing.Color.Crimson;
            this.BtnBackToMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnBackToMenu.Location = new System.Drawing.Point(12, 481);
            this.BtnBackToMenu.Name = "BtnBackToMenu";
            this.BtnBackToMenu.Size = new System.Drawing.Size(174, 58);
            this.BtnBackToMenu.TabIndex = 1;
            this.BtnBackToMenu.Text = "BACK TO MENU";
            this.BtnBackToMenu.UseVisualStyleBackColor = false;
            this.BtnBackToMenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAuthor.Location = new System.Drawing.Point(12, 95);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(72, 23);
            this.LblAuthor.TabIndex = 2;
            this.LblAuthor.Text = "Author:";
            // 
            // CbAuthor
            // 
            this.CbAuthor.FormattingEnabled = true;
            this.CbAuthor.Location = new System.Drawing.Point(126, 95);
            this.CbAuthor.Name = "CbAuthor";
            this.CbAuthor.Size = new System.Drawing.Size(295, 28);
            this.CbAuthor.TabIndex = 3;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTitle.Location = new System.Drawing.Point(126, 149);
            this.TxtTitle.Multiline = true;
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(295, 55);
            this.TxtTitle.TabIndex = 4;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(12, 152);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(51, 23);
            this.LblTitle.TabIndex = 6;
            this.LblTitle.Text = "Title:";
            // 
            // LblDescriptions
            // 
            this.LblDescriptions.AutoSize = true;
            this.LblDescriptions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblDescriptions.Location = new System.Drawing.Point(12, 231);
            this.LblDescriptions.Name = "LblDescriptions";
            this.LblDescriptions.Size = new System.Drawing.Size(114, 23);
            this.LblDescriptions.TabIndex = 7;
            this.LblDescriptions.Text = "Descriptions:";
            // 
            // LblUrl
            // 
            this.LblUrl.AutoSize = true;
            this.LblUrl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUrl.Location = new System.Drawing.Point(12, 447);
            this.LblUrl.Name = "LblUrl";
            this.LblUrl.Size = new System.Drawing.Size(39, 23);
            this.LblUrl.TabIndex = 8;
            this.LblUrl.Text = "Url:";
            // 
            // TxtDescriptions
            // 
            this.TxtDescriptions.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtDescriptions.Location = new System.Drawing.Point(126, 231);
            this.TxtDescriptions.Multiline = true;
            this.TxtDescriptions.Name = "TxtDescriptions";
            this.TxtDescriptions.Size = new System.Drawing.Size(295, 194);
            this.TxtDescriptions.TabIndex = 9;
            // 
            // TxtUrl
            // 
            this.TxtUrl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUrl.Location = new System.Drawing.Point(126, 439);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(295, 30);
            this.TxtUrl.TabIndex = 10;
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCountry.Location = new System.Drawing.Point(468, 160);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(80, 23);
            this.LblCountry.TabIndex = 11;
            this.LblCountry.Text = "Country:";
            // 
            // CbCountry
            // 
            this.CbCountry.FormattingEnabled = true;
            this.CbCountry.Location = new System.Drawing.Point(580, 159);
            this.CbCountry.Name = "CbCountry";
            this.CbCountry.Size = new System.Drawing.Size(430, 28);
            this.CbCountry.TabIndex = 12;
            // 
            // LblCategory
            // 
            this.LblCategory.AutoSize = true;
            this.LblCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCategory.Location = new System.Drawing.Point(749, 96);
            this.LblCategory.Name = "LblCategory";
            this.LblCategory.Size = new System.Drawing.Size(89, 23);
            this.LblCategory.TabIndex = 13;
            this.LblCategory.Text = "Category:";
            // 
            // CbCategory
            // 
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(862, 95);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(148, 28);
            this.CbCategory.TabIndex = 14;
            // 
            // CbSources
            // 
            this.CbSources.FormattingEnabled = true;
            this.CbSources.Location = new System.Drawing.Point(580, 94);
            this.CbSources.Name = "CbSources";
            this.CbSources.Size = new System.Drawing.Size(163, 28);
            this.CbSources.TabIndex = 16;
            // 
            // LblSource
            // 
            this.LblSource.AutoSize = true;
            this.LblSource.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSource.Location = new System.Drawing.Point(467, 99);
            this.LblSource.Name = "LblSource";
            this.LblSource.Size = new System.Drawing.Size(69, 23);
            this.LblSource.TabIndex = 15;
            this.LblSource.Text = "Source:";
            // 
            // LblUrlToImage
            // 
            this.LblUrlToImage.AutoSize = true;
            this.LblUrlToImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblUrlToImage.Location = new System.Drawing.Point(468, 226);
            this.LblUrlToImage.Name = "LblUrlToImage";
            this.LblUrlToImage.Size = new System.Drawing.Size(117, 23);
            this.LblUrlToImage.TabIndex = 17;
            this.LblUrlToImage.Text = "Url To Image:";
            // 
            // TxtUrlToImage
            // 
            this.TxtUrlToImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUrlToImage.Location = new System.Drawing.Point(580, 223);
            this.TxtUrlToImage.Name = "TxtUrlToImage";
            this.TxtUrlToImage.Size = new System.Drawing.Size(430, 30);
            this.TxtUrlToImage.TabIndex = 18;
            // 
            // LblContent
            // 
            this.LblContent.AutoSize = true;
            this.LblContent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblContent.Location = new System.Drawing.Point(468, 281);
            this.LblContent.Name = "LblContent";
            this.LblContent.Size = new System.Drawing.Size(79, 23);
            this.LblContent.TabIndex = 19;
            this.LblContent.Text = "Content:";
            // 
            // TxtContent
            // 
            this.TxtContent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtContent.Location = new System.Drawing.Point(580, 281);
            this.TxtContent.Multiline = true;
            this.TxtContent.Name = "TxtContent";
            this.TxtContent.Size = new System.Drawing.Size(430, 192);
            this.TxtContent.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(402, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 41);
            this.label10.TabIndex = 21;
            this.label10.Text = "New Article";
            // 
            // AddArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1022, 551);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtContent);
            this.Controls.Add(this.LblContent);
            this.Controls.Add(this.TxtUrlToImage);
            this.Controls.Add(this.LblUrlToImage);
            this.Controls.Add(this.CbSources);
            this.Controls.Add(this.LblSource);
            this.Controls.Add(this.CbCategory);
            this.Controls.Add(this.LblCategory);
            this.Controls.Add(this.CbCountry);
            this.Controls.Add(this.LblCountry);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.TxtDescriptions);
            this.Controls.Add(this.LblUrl);
            this.Controls.Add(this.LblDescriptions);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.CbAuthor);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.BtnBackToMenu);
            this.Controls.Add(this.BtnSave);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1040, 598);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1040, 598);
            this.Name = "AddArticles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Article";
            this.Load += new System.EventHandler(this.AddArticles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnBackToMenu;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.ComboBox CbAuthor;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblDescriptions;
        private System.Windows.Forms.Label LblUrl;
        private System.Windows.Forms.TextBox TxtDescriptions;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.ComboBox CbCountry;
        private System.Windows.Forms.Label LblCategory;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.ComboBox CbSources;
        private System.Windows.Forms.Label LblSource;
        private System.Windows.Forms.Label LblUrlToImage;
        private System.Windows.Forms.TextBox TxtUrlToImage;
        private System.Windows.Forms.Label LblContent;
        private System.Windows.Forms.TextBox TxtContent;
        private System.Windows.Forms.Label label10;
    }
}