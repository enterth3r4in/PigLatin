using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatin
{
    public partial class Form1 : Form
    {
        string englishInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            englishInput = tbPhraseInput.Text.ToUpper();

            string[] tokens = englishInput.Split();
            string pigLatinWord = "";

            foreach (string str in tokens)
            {
                pigLatinWord = (str.Substring(1, str.Length - 1) + str[0] + "ay").ToUpper();
                tbPigLatin.Text = tbPigLatin.Text + pigLatinWord + " ";
                    tbPigLatin.Text = tbPigLatin.Text + " ";
                tbPigLatin.Text.ToUpper();
            }
        }
    }
}
