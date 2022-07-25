using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Yarışı
{
    public partial class Form1 : Form
    {
        Random a = new Random();
        int x, y, z;

        public Form1()
        {
            InitializeComponent();
        }



        private void btnBaşlat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = a.Next(0, 20);
            pictureBox1.Left += x;

            y = a.Next(0, 20);
            pictureBox2.Left += y;

            z = a.Next(0, 20);
            pictureBox3.Left += z;

            if ((pictureBox1.Location.X)>(pictureBox2.Location.X)&& (pictureBox1.Location.X)>(pictureBox3.Location.X))
            {
                lblSonuç.Text = "1. Araba Önde";
                if (pictureBox1.Location.X>700)
                {
                    timer1.Stop();
                    lblSonuç.Text = "1. Araba Kazandı";
                }
            }

            else if ((pictureBox2.Location.X)>(pictureBox1.Location.X)&&(pictureBox2.Location.X)>(pictureBox3.Location.X))
            {

                lblSonuç.Text = "2. Araba Önde";

                if (pictureBox2.Location.X>700)
                {
                    timer1.Stop();
                    lblSonuç.Text = "2. Araba Kazandı";
                }
                
            }

            else if ((pictureBox3.Location.X)>(pictureBox1.Location.X)&&(pictureBox3.Location.X)>(pictureBox2.Location.X))
            {
                lblSonuç.Text = "3. Araba Önde";
                if (pictureBox3.Location.X>700)
                {
                    timer1.Stop();
                    lblSonuç.Text = "3. Araba Kazandı";
                }
            }

        }

        private void btnTekrar_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 1;
            pictureBox2.Left = 1;
            pictureBox3.Left = 1;
            lblSonuç.Text = " ";
        }

        
    }
}
