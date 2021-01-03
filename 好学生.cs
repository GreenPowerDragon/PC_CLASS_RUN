using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
//TCP、UDP
using System.Net;
using System.Net.Sockets;

//多线程
using System.Threading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace PC_CLASS_RUN
{

    public partial class 好学生 : Form
    {
        private ScreenForm sf = new ScreenForm();

        private Bitmap curBitmap;
        public 好学生()
        {
            InitializeComponent();
        }

        private void 好学生_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //通过ParameterizedThreadStart创建线程
            Thread thread1 = new Thread(new ThreadStart(Thread1));
            //给方法传值
            thread1.Start();
            Console.ReadKey();
        }

        static void Thread1()
        {
            Image img = GetScreen();
            byte[] bytes = img.ToJpegData(80);
        }
 

        public Bitmap GetScreen()
        {
            //获取整个屏幕图像,不包括任务栏
            Rectangle ScreenArea = Screen.GetWorkingArea(this);
            Bitmap bmp = new Bitmap(ScreenArea.Width, ScreenArea.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, new Size(ScreenArea.Width, ScreenArea.Height));
            }
            return bmp;
        }

        public static byte[] bitmapimagetobytearray(Bitmap bmp)
        {
            byte[] bytearray = null;

            try
            {
                stream smarket = bmp.streamsource;

                if (smarket != null && smarket.length > 0)
                {
                    //很重要，因为position经常位于stream的末尾，导致下面读取到的长度为0。
                    smarket.position = 0;

                    using (binaryreader br = new binaryreader(smarket))
                    {
                        bytearray = br.readbytes((int)smarket.length);
                    }
                }
            }
            catch
            {
                //other exception handling
            }

            return bytearray;
        }

    }
