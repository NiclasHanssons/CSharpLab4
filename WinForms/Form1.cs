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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            ListViewDictionarys listView = new ListViewDictionarys();

            if (listView.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("You pressed confirm.");
            }
            //else if (listView.DialogResult == DialogResult.Abort)
            //{
            //    MessageBox.Show("You pressed abort.");
            //}
            //else
            //{
            //    MessageBox.Show("You pressed close.");
            //}
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
