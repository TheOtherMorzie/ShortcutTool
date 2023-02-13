namespace Lil.UserControls
{
    partial class ListBox_Socket
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.smartPanel1 = new Lil.UserControls.SmartPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.smartPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(432, 430);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // smartPanel1
            // 
            this.smartPanel1.HideDetails = true;
            this.smartPanel1.Location = new System.Drawing.Point(3, 3);
            this.smartPanel1.MinimumSize = new System.Drawing.Size(200, 29);
            this.smartPanel1.Name = "smartPanel1";
            this.smartPanel1.Size = new System.Drawing.Size(301, 182);
            this.smartPanel1.TabIndex = 0;
            // 
            // ListBox_Socket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ListBox_Socket";
            this.Size = new System.Drawing.Size(432, 430);
            this.Load += new System.EventHandler(this.ListBox_Socket_Load);
            this.ClientSizeChanged += new System.EventHandler(this.ListBox_Socket_ClientSizeChanged);
            this.Resize += new System.EventHandler(this.ListBox_Socket_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private SmartPanel smartPanel1;
    }
}
