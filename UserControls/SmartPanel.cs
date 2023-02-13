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
    public partial class SmartPanel : UserControl
    {



        [Description("Hides the details Panel"), Category("Lil")]
        public bool HideDetails
        {
            get => splitContainer1.Panel2Collapsed;
            set => ToggleDetailsPanel(value);
        }


        public SmartPanel()
        {
            InitializeComponent();
        }

        void ToggleDetailsPanel(bool value)
        {
            SuspendLayout();
            if (value == true)
            {
                Size s = splitContainer1.Panel1.Size;
                s.Height += (splitContainer1.Width / 2);
                splitContainer1.Panel2Collapsed = value;
                Size = s;
                textBox1.Text = Size.ToString();
                button1.Text = "↓";
            }
            else
            {
                Size s = splitContainer1.Panel1.Size;
                Size s2 = splitContainer1.Panel2.Size;
                s.Height += s2.Height
                    - (splitContainer1.Width / 2);
                splitContainer1.Panel2Collapsed = value;
                Size = s;
                textBox1.Text = Size.ToString();
                button1.Text = "↑";
            }


            //button1.Text = (value ? "↑" : "↓");
            ResumeLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleDetailsPanel(!splitContainer1.Panel2Collapsed);
        }

        private void SmartPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
