using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2.Clase
{
    public class Linea
    {
        private Pen lapiz;
        private Graphics vector;
        private TextBox txtX1, txtX2, txtY1, txtY2, txtEnX, txtEnY, txtGrados;
        private PictureBox pictureBox;
        private double x1, x2, y1, y2;
        private int xcentro, ycentro;
        private double atan, atan1, atan2, b, b1, c, c1, an, an1, an2, fx, fx1, fx2, fy, fy1, fy2, g, g1, g2, j, j1, j2, sqrt, sqrt1, sqrt2, calc;
        public Linea(TextBox txtX1, TextBox txtX2, TextBox txtY1, TextBox txtY2, TextBox txtEnX, TextBox txtEnY, TextBox txtGrados, PictureBox pictureBox)
        {
            this.txtX1 = txtX1;
            this.txtX2 = txtX2;
            this.txtY1 = txtY1;
            this.txtY2 = txtY2;
            this.txtEnX = txtEnX;
            this.txtEnY = txtEnY;
            this.txtGrados = txtGrados;
            this.pictureBox = pictureBox;
            lapiz = new Pen(Color.Black, 2);
            xcentro = pictureBox.Width / 2;
            ycentro = pictureBox.Height / 2;
        }
        public void graficarLinea()
        {
            if(txtX1.Text == "")
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
                            dibujarLinea();
                        }
                    }
                }
            }
        }
        private void dibujarLinea()
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
            vector.DrawLine(lapiz, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
            lapiz.Dispose();
            vector.Dispose();
        }
        public void traslacionLinea()
        {
            int o, o1;
            vector = pictureBox.CreateGraphics();
            lapiz = new Pen(Color.Black);
            lapiz.Color = Color.White;
            o = Convert.ToInt32(txtEnX.Text);
            o1 = Convert.ToInt32(txtEnY.Text);
            x1 = (Convert.ToDouble(xcentro) + (Convert.ToDouble(txtX1.Text) + o));
            y1 = (Convert.ToDouble(ycentro) - (Convert.ToDouble(txtY1.Text) + o1));
            x2 = (Convert.ToDouble(xcentro) + (Convert.ToDouble(txtX2.Text) + o));
            y2 = (Convert.ToDouble(ycentro) - (Convert.ToDouble(txtY2.Text) + o1));
            vector.DrawLine(lapiz, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));
            /*vector = pictureBox.CreateGraphics();
            lapiz = new Pen(Color.Black);
            lapiz.Color = Color.White;
            xcentro = Convert.ToInt32(txtEnX.Text);
            ycentro = Convert.ToInt32(txtEnY.Text);
            vector.TranslateTransform(xcentro, ycentro);
            x1 = (Convert.ToDouble(xcentro) + Convert.ToDouble(txtX1.Text));
            y1 = (Convert.ToDouble(ycentro) - Convert.ToDouble(txtY1.Text));
            x2 = (Convert.ToDouble(xcentro) + Convert.ToDouble(txtX2.Text));
            y2 = (Convert.ToDouble(ycentro) - Convert.ToDouble(txtY2.Text));
            vector.DrawLine(lapiz, Convert.ToInt32(x1), Convert.ToInt32(y1), Convert.ToInt32(x2), Convert.ToInt32(y2));*/
        }
        private void trigonometria(int valor)
        {
            atan = Math.Atan((c) / (b));
            an = (atan * 180) / Math.PI;
            sqrt = Math.Sqrt((Math.Pow((b), 2)) + (Math.Pow((c), 2)));
            if (valor == 1)
            {
                g = an + Convert.ToDouble(txtGrados.Text);
            }
            else
            {
                g = an + calc;
            }
            j = Math.PI * g / 180;
            fx = (sqrt) * (Math.Cos(j));
            fy = (sqrt) * (Math.Sin(j));
            // ---------------
            atan1 = Math.Atan((c1) / (b1));
            an1 = (atan1 * 180) / Math.PI;
            sqrt1 = Math.Sqrt((Math.Pow((b1), 2)) + (Math.Pow((c1), 2)));
            if (valor == 1)
            {
                g1 = an1 + Convert.ToDouble(txtGrados.Text);
            }
            else
            {
                g1 = an1 + calc;
            }
            j1 = (Math.PI * g1) / 180;
            fx1 = (sqrt1) * (Math.Cos(j1));
            fy1 = (sqrt1) * (Math.Sin(j1));
        }
        public void rotarLinea()
        {
            if (txtGrados.Text == "")
            {
                txtGrados.Focus();
            }
            else
            {
                trigonometria(1);
                lapiz = new Pen(Color.Black, 1);
                vector = pictureBox.CreateGraphics();
                lapiz.Color = Color.BlueViolet;
                vector.DrawLine(lapiz, xcentro + Convert.ToInt32(fx), ycentro - Convert.ToInt32(fy),
                    xcentro + Convert.ToInt32(fx1), ycentro - Convert.ToInt32(fy1));

                vector.DrawLine(lapiz, xcentro + Convert.ToInt32(fx1), ycentro - Convert.ToInt32(fy1),
                    xcentro + Convert.ToInt32(fx), ycentro - Convert.ToInt32(fy));

                lapiz.Dispose();
                vector.Dispose();
            }
        }
    }
}
