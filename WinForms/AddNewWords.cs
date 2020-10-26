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
    public partial class AddNewWords : Form
    {
        public string NameOfList { get; set; }

        public WordList CurrentWordList { get; set; }

        public AddNewWords(string nameOfList)
        {
            InitializeComponent();
            NameOfList = nameOfList;
        }
        
        private void AddNewWords_Load(object sender, EventArgs e)
        {
            WordList loadedList = WordList.LoadList(NameOfList);
            CurrentWordList = loadedList;

            dataGridViewAddNewWords.Columns.Add("Language", "Language");
            dataGridViewAddNewWords.Columns.Add("Word", "Word");
            dataGridViewAddNewWords.Columns["Language"].ReadOnly = true;

            foreach (var item in CurrentWordList.Languages)
            {
                dataGridViewAddNewWords.Rows.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<string> newWords = new List<string>();

            foreach (DataGridViewRow row in dataGridViewAddNewWords.Rows)
            {
                newWords.Add(row.Cells[1].Value.ToString());
            }

            CurrentWordList.Add(newWords.ToArray());
            CurrentWordList.Save();
        }

    }
}
