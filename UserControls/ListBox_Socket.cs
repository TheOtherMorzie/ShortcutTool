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
    public partial class ListBox_Socket : UserControl
    {
        public ListBox_Socket()
        {
            InitializeComponent();
            UserControls = new List<UserControl>();
        }

        public List<UserControl>? UserControls { get; set; }

        bool b_dummyLoad = true;
        private void ListBox_Socket_Load(object sender, EventArgs e)
        {
            if (b_dummyLoad)
            {
                DummyLoad();
            }
            LoadList();
        }

        void LoadList()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < UserControls.Count; i++)
            {
                var ctrl = UserControls[i];
                flowLayoutPanel1.Controls.Add(ctrl);
            }
        }

        public void DummyLoad()
        {
            for (int i = 0; i < 10; i++)
            {
                var item = new Socket_Executable();
                UserControls.Add(item);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        private void ListBox_Socket_Resize(object sender, EventArgs e)
        {
            foreach (var item in UserControls)
            {
                var size = item.Size;
                size.Width = flowLayoutPanel1.ClientSize.Width;
                item.Size = size;
            }
        }

        private void ListBox_Socket_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        //protected override void OnResize(EventArgs e)
        //{
        //    foreach (var item in UserControls)
        //    {
        //        var size = item.Size;
        //        size.Width = flowLayoutPanel1.ClientSize.Width;
        //        item.Size = size;
        //    }
        //    base.OnResize(e);
        //}
    }
}
