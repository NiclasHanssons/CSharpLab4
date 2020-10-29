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
        public void LoadWords()
        {
            WordTranslations loadListForWords = new WordTranslations(NameOfDictionary);
            NameOfDictionary = loadListForWords.NameOfDictionary;

            WordList wordList = WordList.LoadList(NameOfDictionary);
            string[] wordsArray = MethodsForWinFormApp.ListWordsAlphabetically(NameOfDictionary);

            foreach (var item in wordList.Languages)
            {
                dataGridViewWord.Columns.Add("Language", item);
            }

            //Lägger till alla ord i listan genom List metoden med delegat och lambda expression
            wordList.List(0, x =>
            {
                dataGridViewWord.Rows.Add(x);
            });

            if (dataGridViewWord.Rows.Count > 0)
            {
                buttonRemoveWord.Enabled = true;
            }

        }
        public string NameOfDictionary { get; set; }

        public WordTranslations(string listName)
        {
            NameOfDictionary = listName;
            InitializeComponent();
        }

        //Laddar in markerad lista i en dataGridView
        private void WordTranslations_Load(object sender, EventArgs e)
        {
            LoadWords();
        }

        private void buttonAddWord_Click(object sender, EventArgs e)
        {
            AddNewWords addNewWordDataGrid = new AddNewWords(NameOfDictionary);

            if (addNewWordDataGrid.ShowDialog() == DialogResult.OK)
            {
                dataGridViewWord.Rows.Clear();
                dataGridViewWord.Columns.Clear();
                LoadWords();
            }
        }

        private void buttonRemoveWord_Click(object sender, EventArgs e)
        {
            WordList wordList = WordList.LoadList(NameOfDictionary);
            DataGridViewSelectedCellCollection selectedCells = dataGridViewWord.SelectedCells;

            dataGridViewWord.Rows.RemoveAt(dataGridViewWord.SelectedRows[0].Index);
            wordList.Remove(0, selectedCells[0].Value.ToString());
            wordList.Save();

            if (dataGridViewWord.RowCount == 0)
            {
                buttonRemoveWord.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

