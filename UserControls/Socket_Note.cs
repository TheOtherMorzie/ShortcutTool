using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lil.UserControls
{
    public partial class Socket_Note : UserControl
    {
        public Socket_Note()
        {
            InitializeComponent();
        }

        void SaveChanges()
        {

            textChanged = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.SuspendLayout();
            textBox2.Text = textBox1.Text;
            textBox2.ResumeLayout();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.SuspendLayout();
            textBox1.Text = textBox2.Text;
            textBox1.ResumeLayout();
        }

        bool textChanged = false;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void bindingSource1_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_ListChanged(object sender, ListChangedEventArgs e)
        {

        }
    }
}
