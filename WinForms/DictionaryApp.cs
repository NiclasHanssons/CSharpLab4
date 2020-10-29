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
    public partial class DictionaryApp : Form
    {
        public DictionaryApp()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            ListViewDictionarys listView = new ListViewDictionarys();

            if (listView.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void DictionaryApp_Load(object sender, EventArgs e)
        //{
        //    ListViewDictionarys listView = new ListViewDictionarys();
        //    listView.ShowDialog();
        //}
    }
}
