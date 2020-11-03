using ClassLibrary;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinForms
{
    public partial class NewList : Form
    {
        public NewList()
        {
            InitializeComponent();
        }

        //Lägger till listnamn och språk i en ny lista och sparar den med Save metoden
        private void buttonNewListOk_Click(object sender, EventArgs e)
        {
            string listNameInput = textBoxNewList.Text;
            string[] newLanguages = textBoxLanguages.Lines.ToArray();

            if (textBoxLanguages.Lines.Length < 2 || textBoxLanguages.Lines.Contains(""))
            {
                MessageBox.Show("Please add atleast two languages.", "Not enough languages");
                NewList wrongInput = new NewList();
                wrongInput.ShowDialog();
            }

            if (textBoxLanguages.Lines.Length > 1)
            {
                WordList newListAndLanguages = new WordList(listNameInput, newLanguages);
                newListAndLanguages.Save();
            }
        }

        private void textBoxNewList_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewList.Text != "" && textBoxLanguages.Lines.Length > 1)
            {
                buttonNewListOk.Enabled = true;
            }
        }

        private void textBoxLanguages_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewList.Text != "" && textBoxLanguages.Lines.Length > 1 && !textBoxLanguages.Lines.Contains(""))
            {
                buttonNewListOk.Enabled = true;
            }
        }

        private void textBoxNewList_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxNewList.Clear();
        }

        private void textBoxLanguages_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxLanguages.Clear();
        }

        private void textBoxNewList_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex pattern = new Regex(@"[^\\|\/|:|\*|\?|""|<|>|\|]");

            if (!pattern.IsMatch(e.KeyChar.ToString()))
            {
                MessageBox.Show("Title can't contain /, \\, :, *, ?, <, > or |.", "Wrong character input");
                e.Handled = true;
            }
        }
    }
}
