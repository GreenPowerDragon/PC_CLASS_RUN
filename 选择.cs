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
    public partial class 选择 : Form
    {
        public 选择()
        {
            InitializeComponent();
        }

        private void 选择_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            好学生 from1 = new 好学生();from1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            基友 from2 = new 基友(); from2.Show();
        }
    }
}
