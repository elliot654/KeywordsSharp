using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            string[] ToRemove = new string[] {",","." };
            string article = articleTxt.Text.ToLower();

           foreach(string punctuation in ToRemove)
            {
                article = article.Replace(punctuation, string.Empty);
            }

            foreach(string keyword in keywordsTxt.Lines)
            {
                string pattern = @"\b" + keyword + @"\b";
                MatchCollection matches = Regex.Matches(article, pattern);
                if (matches.Count > 0)
                {
                    resultsTxt.AppendText(keyword + " - " + matches.Count.ToString() + Environment.NewLine);
                }
                else
                {
                    resultsTxt.AppendText(keyword + " - " + "0" + Environment.NewLine);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    articleTxt.Text = text;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }
    }
}
