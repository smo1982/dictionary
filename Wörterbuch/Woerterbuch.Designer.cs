namespace Wörterbuch
{
    partial class Woerterbuch
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbGermanWord = new System.Windows.Forms.TextBox();
            this.tbEnglishWord = new System.Windows.Forms.TextBox();
            this.lbTranslation = new System.Windows.Forms.Label();
            this.lBoxGermanWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.btExportCsv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(309, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(67, 60);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(239, 22);
            this.tbGermanWord.TabIndex = 1;
            // 
            // tbEnglishWord
            // 
            this.tbEnglishWord.Location = new System.Drawing.Point(413, 60);
            this.tbEnglishWord.Name = "tbEnglishWord";
            this.tbEnglishWord.Size = new System.Drawing.Size(239, 22);
            this.tbEnglishWord.TabIndex = 2;
            // 
            // lbTranslation
            // 
            this.lbTranslation.AutoSize = true;
            this.lbTranslation.Location = new System.Drawing.Point(325, 63);
            this.lbTranslation.Name = "lbTranslation";
            this.lbTranslation.Size = new System.Drawing.Size(70, 17);
            this.lbTranslation.TabIndex = 3;
            this.lbTranslation.Text = "DE <> EN";
            // 
            // lBoxGermanWords
            // 
            this.lBoxGermanWords.FormattingEnabled = true;
            this.lBoxGermanWords.ItemHeight = 16;
            this.lBoxGermanWords.Location = new System.Drawing.Point(36, 174);
            this.lBoxGermanWords.Name = "lBoxGermanWords";
            this.lBoxGermanWords.Size = new System.Drawing.Size(390, 260);
            this.lBoxGermanWords.TabIndex = 4;
            this.lBoxGermanWords.SelectedIndexChanged += new System.EventHandler(this.lBoxGermanWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(468, 174);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(221, 22);
            this.tbTranslation.TabIndex = 5;
            // 
            // btExportCsv
            // 
            this.btExportCsv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btExportCsv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btExportCsv.Location = new System.Drawing.Point(503, 377);
            this.btExportCsv.Name = "btExportCsv";
            this.btExportCsv.Size = new System.Drawing.Size(107, 46);
            this.btExportCsv.TabIndex = 6;
            this.btExportCsv.Text = "Export CSV";
            this.btExportCsv.UseVisualStyleBackColor = false;
            this.btExportCsv.Click += new System.EventHandler(this.btExportCsv_Click);
            // 
            // Woerterbuch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExportCsv);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lBoxGermanWords);
            this.Controls.Add(this.lbTranslation);
            this.Controls.Add(this.tbEnglishWord);
            this.Controls.Add(this.tbGermanWord);
            this.Controls.Add(this.btnAdd);
            this.Name = "Woerterbuch";
            this.Text = "Wörterbuch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbGermanWord;
        private System.Windows.Forms.TextBox tbEnglishWord;
        private System.Windows.Forms.Label lbTranslation;
        private System.Windows.Forms.ListBox lBoxGermanWords;
        private System.Windows.Forms.TextBox tbTranslation;
        private System.Windows.Forms.Button btExportCsv;
    }
}

