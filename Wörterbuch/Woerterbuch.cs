using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wörterbuch
{
    public partial class Woerterbuch : Form
    {
        Dictionary<string, string> germanToEnglishDict = new Dictionary<string, string>();
        public Woerterbuch()
        {
            InitializeComponent();
            UpdateDictionary();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var germanWord = tbGermanWord.Text;
            var englishWord = tbEnglishWord.Text;

            if(!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(englishWord))
            {
                germanToEnglishDict.Add(germanWord, englishWord);
                UpdateTranslations();
            }
        }

        private void UpdateTranslations()
        {
            lBoxGermanWords.DataSource = germanToEnglishDict.Keys.ToList();
        }

        private void lBoxGermanWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWord = lBoxGermanWords.SelectedItem as string;

            if(!string.IsNullOrEmpty(selectedWord) && germanToEnglishDict.ContainsKey(selectedWord))
            {
                tbTranslation.Text = germanToEnglishDict[selectedWord];
            }
        }

        private void btExportCsv_Click(object sender, EventArgs e)
        {
            string[] writeText = new string[germanToEnglishDict.Count];
            for (int i = 0; i < germanToEnglishDict.Count; i++)
            {
            writeText[i] = $"{germanToEnglishDict.Keys.ElementAt(i)};{germanToEnglishDict.Values.ElementAt(i)}";
            }
            System.IO.File.WriteAllLines("C:\\Users\\DCV\\Downloads\\persons1.txt", writeText);
        }

        private void UpdateDictionary()
        {
            string[] myFileContent = System.IO.File.ReadAllLines("C:\\Users\\DCV\\Downloads\\persons1.txt");
            foreach (string oneWord in myFileContent)
            {
                string[] textWord = oneWord.Split(';');
                string german = textWord[0];
                string english = textWord[1];
                germanToEnglishDict.Add(german, english);
                UpdateTranslations();

            }
        }
    }
}
