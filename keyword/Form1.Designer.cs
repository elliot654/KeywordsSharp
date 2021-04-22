
namespace keyword
{
    partial class Form1
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
            this.Article = new System.Windows.Forms.GroupBox();
            this.articleTxt = new System.Windows.Forms.TextBox();
            this.Keywords = new System.Windows.Forms.GroupBox();
            this.keywordsTxt = new System.Windows.Forms.TextBox();
            this.Keywords2 = new System.Windows.Forms.GroupBox();
            this.resultsTxt = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.Article.SuspendLayout();
            this.Keywords.SuspendLayout();
            this.Keywords2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Article
            // 
            this.Article.Controls.Add(this.articleTxt);
            this.Article.Location = new System.Drawing.Point(12, 293);
            this.Article.Name = "Article";
            this.Article.Size = new System.Drawing.Size(776, 190);
            this.Article.TabIndex = 0;
            this.Article.TabStop = false;
            this.Article.Text = "Article";
            this.Article.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // articleTxt
            // 
            this.articleTxt.Location = new System.Drawing.Point(6, 19);
            this.articleTxt.Multiline = true;
            this.articleTxt.Name = "articleTxt";
            this.articleTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.articleTxt.Size = new System.Drawing.Size(764, 165);
            this.articleTxt.TabIndex = 0;
            // 
            // Keywords
            // 
            this.Keywords.Controls.Add(this.keywordsTxt);
            this.Keywords.Location = new System.Drawing.Point(12, 72);
            this.Keywords.Name = "Keywords";
            this.Keywords.Size = new System.Drawing.Size(346, 170);
            this.Keywords.TabIndex = 1;
            this.Keywords.TabStop = false;
            this.Keywords.Text = "Keywords";
            // 
            // keywordsTxt
            // 
            this.keywordsTxt.Location = new System.Drawing.Point(6, 20);
            this.keywordsTxt.Multiline = true;
            this.keywordsTxt.Name = "keywordsTxt";
            this.keywordsTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keywordsTxt.Size = new System.Drawing.Size(334, 144);
            this.keywordsTxt.TabIndex = 0;
            // 
            // Keywords2
            // 
            this.Keywords2.Controls.Add(this.resultsTxt);
            this.Keywords2.Location = new System.Drawing.Point(442, 72);
            this.Keywords2.Name = "Keywords2";
            this.Keywords2.Size = new System.Drawing.Size(340, 170);
            this.Keywords2.TabIndex = 2;
            this.Keywords2.TabStop = false;
            this.Keywords2.Text = "Keywords";
            this.Keywords2.UseCompatibleTextRendering = true;
            // 
            // resultsTxt
            // 
            this.resultsTxt.Location = new System.Drawing.Point(6, 20);
            this.resultsTxt.Multiline = true;
            this.resultsTxt.Name = "resultsTxt";
            this.resultsTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsTxt.Size = new System.Drawing.Size(328, 144);
            this.resultsTxt.TabIndex = 0;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(361, 29);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(75, 23);
            this.checkBtn.TabIndex = 3;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(361, 264);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Upload File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.Keywords2);
            this.Controls.Add(this.Keywords);
            this.Controls.Add(this.Article);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Article.ResumeLayout(false);
            this.Article.PerformLayout();
            this.Keywords.ResumeLayout(false);
            this.Keywords.PerformLayout();
            this.Keywords2.ResumeLayout(false);
            this.Keywords2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Article;
        private System.Windows.Forms.TextBox articleTxt;
        private System.Windows.Forms.GroupBox Keywords;
        private System.Windows.Forms.TextBox keywordsTxt;
        private System.Windows.Forms.GroupBox Keywords2;
        private System.Windows.Forms.TextBox resultsTxt;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button btnLoad;
    }
}

