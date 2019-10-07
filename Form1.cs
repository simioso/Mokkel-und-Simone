using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidCam
{
    public partial class Form1 : Form
    {
        WebCam WebCam;

        Stack<Bitmap> imagestack;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebCam = new WebCam();
            WebCam.InitializeWebCam(ref Kamerabillede);
            //Thread.Sleep(1000);
            imagestack = new Stack<Bitmap>();
            WebCam.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult dr= MessageBox.Show("Are you sure you want to close the program?","sure",MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                WebCam.Stop();
            }
        }

        private void ButtonCapture_Click(object sender, EventArgs e)
        {
            if (Capturebillede.Image !=null)
            {
                imagestack.Push(new Bitmap(Capturebillede.Image));
            }
            Capturebillede.Image = (Image)Kamerabillede.Image.Clone();
        }

        private void ButtonGray_Click(object sender, EventArgs e)
        {
            try
            {


                imagestack.Push(new Bitmap(Kamerabillede.Image));
                Bitmap bt = new Bitmap(Capturebillede.Image);
                for (int x = 0; x < bt.Width; x++)
                {
                    for (int y = 0; y < bt.Height; y++)
                    {
                        Color c = bt.GetPixel(x, y);
                        int avg = (c.R + c.G + c.B) / 3;
                        bt.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                    }
                }
                Capturebillede.Image = bt;
            }
            catch(NullReferenceException)

            { 
                MessageBox.Show("du skal capture først");
            }
        }
    }
}
