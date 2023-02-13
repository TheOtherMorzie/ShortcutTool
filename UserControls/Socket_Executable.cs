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
    public partial class Socket_Executable : UserControl
    {
        public Socket_Executable()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = !checkBox1.Checked;
        }
    }
}
