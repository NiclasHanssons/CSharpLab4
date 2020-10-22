using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WinForms
{
    public partial class WordTranslations : Form
    {
        public string NameOfDictionary { get; set; }

        public WordTranslations(string listName)
        {
            NameOfDictionary = listName;
            InitializeComponent();
        }

        private void WordTranslations_Load(object sender, EventArgs e)
        {
            WordTranslations loadListForWordsTest = new WordTranslations(NameOfDictionary);
            NameOfDictionary = loadListForWordsTest.NameOfDictionary;

            WordList testWordList = WordList.LoadList(NameOfDictionary);
            string[] wordsArray = MethodsForWinFormApp.ListWordsAlphabetically(NameOfDictionary);

            foreach (var item in testWordList.Languages)
            {
                dataGridViewWord.Columns.Add("Language", item);
            }

            testWordList.List(0, x =>
            {
                dataGridViewWord.Rows.Add(x);
            });
                

            
            
            //foreach (var item in MethodsForWinFormApp.ListWordsAlphabetically(NameOfDictionary))
            //{
            //    dataGridViewWord.Rows.Add(item);
            //}


        }
    }
}
