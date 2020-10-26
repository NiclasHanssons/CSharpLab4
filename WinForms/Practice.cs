using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Practice : Form
    {
        public string NameOfDictionary { get; set; }

        public string CorrectTranslationWord { get; set; }

        double correctTranslation = 0.0;
        double numberOfWordsTranslated = 0.0;

        public Practice(string listName)
        {
            NameOfDictionary = listName;
            InitializeComponent();
        }

       public void NewWord()
        {
            WordList wordListForPractice = WordList.LoadList(NameOfDictionary);

            Word word = wordListForPractice.GetWordToPractice();

            labelLanguageAndWordToTranslate.Text = $"Translate the {wordListForPractice.Languages[word.FromLanguage]} word" +
                $" '{word.Translations[0]}' to {wordListForPractice.Languages[word.ToLanguage]} and press enter.";

            CorrectTranslationWord = word.Translations[1];
        }

        private void Practice_Load(object sender, EventArgs e)
        {
            NewWord();
        }

        private void buttonEndPractice_Click(object sender, EventArgs e)
        {
            double correctAnswersInProcent = (correctTranslation / numberOfWordsTranslated) * 100;
            MessageBox.Show($"{correctTranslation} correct translations out of {numberOfWordsTranslated} words, {correctAnswersInProcent:F1}%", "Practice result");
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            correctTranslation = 0.0;
            numberOfWordsTranslated = 0.0;
            MessageBox.Show("Practice restarted.", "Practice restarted");
            NewWord();
        }

        private void textBoxTranslation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxTranslation.Text == CorrectTranslationWord)
                {
                    labelResult.Text = $"Corret translation";
                    correctTranslation++;
                }

                else
                {
                    labelResult.Text = $"Incorrect translation";
                }
                numberOfWordsTranslated++;

                textBoxTranslation.Clear();
                NewWord();
            }
        }
    }
}

