using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_D_animation
{
    public partial class animation : Form
    {
        float sunx;
        float suny;
        double movementx = 0;
        double movementy = 0;
        double angle = 0;
        int r = 22;
        int x0 = 270;
        int y0 = 480;

        public animation()
        {
            InitializeComponent();
            pictureBox_earth.Image = new Bitmap(pictureBox_earth.Width, pictureBox_earth.Height);
            Graphics g = Graphics.FromImage(pictureBox_earth.Image);
            g.Clear(Color.Green);
            pictureBox_sunrise.Image = new Bitmap(pictureBox_sunrise.Width, pictureBox_sunrise.Height);
            Graphics gr = Graphics.FromImage(pictureBox_sunrise.Image);
            gr.Clear(Color.Blue);
        }
        public void sunrise(double movementx, double movementy, double angle)
        {
            pictureBox_sunrise.Image = new Bitmap(pictureBox_sunrise.Width, pictureBox_sunrise.Height);
            Graphics g = Graphics.FromImage(pictureBox_sunrise.Image);
            g.Clear(Color.Blue);
            //sun
            sunx =(float)( x0 + movementx);
            suny = (float)(y0 + movementy);
            g.FillEllipse(Brushes.Gold, sunx, suny, 70, 70);
            //rays up/down/left/right

            for(double teta = 0; teta < 2* Math.PI; teta += Math.PI/100)
            {

                g.DrawLine(new Pen(Brushes.Gold), sunx + 100 * (float)Math.Sin(teta) + 35, suny + 100 * (float)Math.Cos(teta) + 35, sunx + 35, suny + 35);
            }

            //g.FillRectangle(Brushes.Gold, sunx + 32, suny - 25, sunraywidth, sunraiheight);
            //g.FillRectangle(Brushes.Gold, sunx + 32, suny + 75, sunraywidth, sunraiheight);
            //g.FillRectangle(Brushes.Gold, sunx - 30, suny + 30, sunraiheight, sunraywidth);
            //g.FillRectangle(Brushes.Gold, sunx + 75, suny + 30, sunraiheight, sunraywidth);
        }


        private void animation_KeyDown(object sender, KeyEventArgs e)
        {
            pictureBox_sunrise.Image = new Bitmap(pictureBox_sunrise.Width, pictureBox_sunrise.Height);
            Graphics g = Graphics.FromImage(pictureBox_sunrise.Image);
            if (e.KeyCode == Keys.Left)
            {

                angle -= 0.1;
                movementx += r * Math.Cos(angle);
                movementy += r * Math.Sin(angle);
                sunrise(movementx, movementy, angle);
            }
            if (e.KeyCode == Keys.Right)
            {  

                movementx -= r * Math.Cos(angle);
                movementy -= r * Math.Sin(angle);
                angle += 0.1;
                sunrise(movementx, movementy, angle);
            }
            else
            {
                
            }
                
           
        }
      
    }
}
