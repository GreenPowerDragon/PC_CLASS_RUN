using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_CLASS_RUN
{
    public partial class 联想云教室 : Form
    {
        public 联想云教室()
        {
            InitializeComponent();
        }

        Boolean zt = false;

        private void 联想云教室_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.pictureBox1.Height = Screen.PrimaryScreen.Bounds.Height;
            this.pictureBox1.Width = Screen.PrimaryScreen.Bounds.Width;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 显示加载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image= Image.FromFile(@".\1.png");
            zt = false;
        }

        private void 显示桌面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zt = true;
        }
    }
}
