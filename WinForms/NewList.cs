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

            WordList newListAndLanguages = new WordList(listNameInput, newLanguages);

            newListAndLanguages.Save();
        }
    }
}
