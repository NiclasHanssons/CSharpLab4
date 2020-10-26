using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{

    public partial class ListViewDictionarys : Form
    {
        public string NameOfDictionaryListView { get; set; }

        public ListViewDictionarys()
        {
            InitializeComponent();
        }

        //Listar alla ordlistor i listBox, använder ShowLists metoden
        private void ListView_Load(object sender, EventArgs e)
        {
            string[] list = MethodsForWinFormApp.ShowLists();
            foreach (string file in list)
            {
                listBoxDictionaries.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        //Event för listBox när ett item är selected
        private void listBoxDictionaries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDictionaries.SelectedIndex > 1)
            {
                buttonConfirm.Enabled = true;
            }

            //Anger antal ord i varje lista på Word count label
            labelWordCount.Text = $"Word count: { MethodsForWinFormApp.CountWords(listBoxDictionaries.GetItemText(listBoxDictionaries.SelectedItem))}";

            //Anger vilka språk som finns i varje lista i en listbox
            WordList languagesForWinForm = WordList.LoadList(listBoxDictionaries.GetItemText(listBoxDictionaries.SelectedItem));

            listBoxLanguages.Items.Clear();

            //Lägger till språken från varje lista i en listBox
            for (int i = 0; i < languagesForWinForm.Languages.Length; i++)
            {
                listBoxLanguages.Items.Add(languagesForWinForm.Languages[i]);
            }
        }

        //Öppnar ett nytt form för att lägga till en ny lista och språk
        private void buttonNewList_Click(object sender, EventArgs e)
        {
            NewList addNewList = new NewList();
            
            if (addNewList.ShowDialog() == DialogResult.OK)
            {
                listBoxDictionaries.Items.Clear();
                string[] list = MethodsForWinFormApp.ShowLists();
                foreach (string file in list)
                {
                    listBoxDictionaries.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
        }

        //Öppnar ett nytt form där alla ord skall listas
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            WordList selectedListToShowWords = WordList.LoadList(listBoxDictionaries.SelectedItem.ToString());
            WordTranslations showWordsInDataGrid  = new WordTranslations(selectedListToShowWords.Name);

            NameOfDictionaryListView = listBoxDictionaries.SelectedItem.ToString();
            if (showWordsInDataGrid.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonPractice_Click(object sender, EventArgs e)
        {
            NameOfDictionaryListView = listBoxDictionaries.SelectedItem.ToString();
            Practice practiceView = new Practice(NameOfDictionaryListView);
            practiceView.ShowDialog();
        }
    }
}
