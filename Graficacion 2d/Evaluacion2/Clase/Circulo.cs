using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2.Clase
{
    public class Circulo
    {
        private Pen lapiz;
        private Graphics vector;
        private TextBox txtX1, txtX2, txtY1, txtY2, txtGrados;
        private PictureBox pictureBox;
        private double x1, x2, y1, y2;
        private int xcentro, ycentro;
        private double atan, atan1, atan2, b, b1, c, c1, d, d1, e, e1, an, an1, an2, fx, fx1, fx2, fy, fy1, fy2, g, g1, g2, j, j1, j2, sqrt, sqrt1, sqrt2, z, z1, calc;
        public Circulo(TextBox txtX1, TextBox txtX2, TextBox txtY1, TextBox txtY2, TextBox txtGrados, PictureBox pictureBox)
        {
            this.txtX1 = txtX1;
            this.txtX2 = txtX2;
            this.txtY1 = txtY1;
            this.txtY2 = txtY2;
            this.txtGrados = txtGrados;
            this.pictureBox = pictureBox;
            lapiz = new Pen(Color.Black, 2);
            xcentro = pictureBox.Width / 2;
            ycentro = pictureBox.Height / 2;
        }
        public void graficarCirculo()
        {
            if (txtX1.Text == "")
            {
                txtX1.Focus();
            }
            else
            {
                if (txtX2.Text == "")
                {
                    txtX2.Focus();
                }
                else
                {
                    if (txtY1.Text == "")
                    {
                        txtY1.Focus();
                    }
                    else
                    {
                        if (txtY2.Text == "")
                        {
                            txtY2.Focus();
                        }
                        else
                        {
                            dibujarCirculo();
                        }
                    }
                }
            }
        }
        private void dibujarCirculo()
        {
            b = Convert.ToDouble(txtX1.Text);
             c = Convert.ToDouble(txtY1.Text);
             b1 = Convert.ToDouble(txtX2.Text);
             c1 = Convert.ToDouble(txtY2.Text);

             x1 = (Convert.ToDouble(xcentro) + Convert.ToDouble(txtX1.Text));
             y1 = (Convert.ToDouble(ycentro) - Convert.ToDouble(txtY1.Text));
             x2 = (Convert.ToDouble(xcentro) + Convert.ToDouble(txtX2.Text));
             y2 = (Convert.ToDouble(ycentro) - Convert.ToDouble(txtY2.Text));

             vector = pictureBox.CreateGraphics();
             lapiz = new Pen(Color.Black);
             lapiz.Color = Color.White;

            //vector.DrawLine(lapiz, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
            vector.DrawEllipse(lapiz, new Rectangle(Convert.ToInt32(txtX1.Text), Convert.ToInt32(txtX2.Text), Convert.ToInt32(txtY1.Text), Convert.ToInt32(txtY2.Text)));
            //vector.DrawEllipse (lapiz, Convert.ToInt32(x2), Convert.ToInt32(y2), Convert.ToInt32(x1), Convert.ToInt32(y1));

            //lapiz.Dispose();
            //vector.Dispose();
        }
    }
}
