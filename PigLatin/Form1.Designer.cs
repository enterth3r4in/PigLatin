namespace PigLatin
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
            this.tbPhraseInput = new System.Windows.Forms.TextBox();
            this.tbPigLatin = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPhraseInput
            // 
            this.tbPhraseInput.Location = new System.Drawing.Point(12, 12);
            this.tbPhraseInput.Name = "tbPhraseInput";
            this.tbPhraseInput.Size = new System.Drawing.Size(507, 20);
            this.tbPhraseInput.TabIndex = 0;
            // 
            // tbPigLatin
            // 
            this.tbPigLatin.Location = new System.Drawing.Point(12, 230);
            this.tbPigLatin.Name = "tbPigLatin";
            this.tbPigLatin.Size = new System.Drawing.Size(507, 20);
            this.tbPigLatin.TabIndex = 1;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(184, 96);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(138, 59);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "\"Translate\"";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 262);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.tbPigLatin);
            this.Controls.Add(this.tbPhraseInput);
            this.Name = "Form1";
            this.Text = "Pig Latin Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPhraseInput;
        private System.Windows.Forms.TextBox tbPigLatin;
        private System.Windows.Forms.Button btnTranslate;
    }
}

