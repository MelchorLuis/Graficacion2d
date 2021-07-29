using Evaluacion2.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2
{
    public partial class frmMain : Form
    {
        Triangulo triangulo;
        Linea linea;
        Cuadrilatero cuadrilatero;
        Circulo circulo;
        Pentagono pentagono;
        public frmMain()
        {
            InitializeComponent();
            triangulo = new Triangulo(txtX1,txtX2,txtX3,txtY1,txtY2,txtY3,txtEnX,txtEnY,txtGrados,pictureBox1);
            linea = new Linea(txtX1, txtX2, txtY1, txtY2, txtEnX, txtEnY, txtGrados, pictureBox1);
            cuadrilatero = new Cuadrilatero(txtX1, txtX2, txtX3, txtX4, txtY1, txtY2, txtY3, txtY4, txtEnX, txtEnY, txtGrados, pictureBox1);
            circulo = new Circulo(txtX1, txtX2, txtY1, txtY2, txtGrados, pictureBox1);
            pentagono = new Pentagono(txtX1, txtX2, txtX3, txtX4, txtX5, txtY1, txtY2, txtY3, txtY4, txtY5, txtEnX, txtEnY, txtGrados, pictureBox1);
        }

        private void cmdIngresarDatos_Click(object sender, EventArgs e)
        {
            if(cbAccion.Text == "")
            {
                lblEnX.Visible = false;
                lblEnY.Visible = false;
                txtEnX.Visible = false;
                txtEnY.Visible = false;
                cmdTrasladar.Visible = false;
                cmdEscalar.Visible = false;
                cmdRotar.Visible = false;
                lblGrados.Visible = false;
                txtGrados.Visible = false;
            }
            if(cbAccion.Text == "Rotar")
            {
                lblGrados.Visible = true;
                txtGrados.Visible = true;
                cmdRotar.Visible = true;
                lblEnY.Visible = false;
                lblEnX.Visible = false;
                txtEnX.Visible = false;
                txtEnY.Visible = false;
                cmdTrasladar.Visible = false;
                cmdEscalar.Visible = false;
            }
            if(cbAccion.Text == "Trasladar")
            {
                lblEnY.Visible = true;
                lblEnX.Visible = true;
                txtEnX.Visible = true;
                txtEnY.Visible = true;
                cmdTrasladar.Visible = true;
                lblGrados.Visible = false;
                txtGrados.Visible = false;
                cmdRotar.Visible = false;
                cmdEscalar.Visible = false;
            }
            if (cbAccion.Text == "Escalar")
            {
                lblEnY.Visible = true;
                lblEnX.Visible = true;
                txtEnX.Visible = true;
                txtEnY.Visible = true;
                cmdTrasladar.Visible = false;
                lblGrados.Visible = false;
                txtGrados.Visible = false;
                cmdRotar.Visible = false;
                cmdEscalar.Visible = true;
            }
            if (cbFiguras.Text == "Líneas")
            {
                lblX1.Visible = true;
                lblX2.Visible = true;
                lblX3.Visible = false;
                lblX4.Visible = false;
                lblY1.Visible = true;
                lblY2.Visible = true;
                lblY3.Visible = false;
                lblY4.Visible = false;
                txtX1.Visible = true;
                txtX2.Visible = true;
                txtX3.Visible = false;
                txtX4.Visible = false;
                txtY1.Visible = true;
                txtY2.Visible = true;
                txtY3.Visible = false;
                txtY4.Visible = false;
                lblX5.Visible = false;
                txtX5.Visible = false;
                lblY5.Visible = false;
                txtY5.Visible = false;
                cmdDibujar.Visible = true;
            }
            if (cbFiguras.Text == "Triángulo")
            {
                lblX1.Visible = true;
                lblX2.Visible = true;
                lblX3.Visible = true;
                lblX4.Visible = false;
                lblY1.Visible = true;
                lblY2.Visible = true;
                lblY3.Visible = true;
                lblY4.Visible = false;
                txtX1.Visible = true;
                txtX2.Visible = true;
                txtX3.Visible = true;
                txtX4.Visible = false;
                txtY1.Visible = true;
                txtY2.Visible = true;
                txtY3.Visible = true;
                txtY4.Visible = false;
                lblX5.Visible = false;
                txtX5.Visible = false;
                lblY5.Visible = false;
                txtY5.Visible = false;
                cmdDibujar.Visible = true;
            }
            if (cbFiguras.Text == "Cuadrilatero")
            {
                lblX1.Visible = true;
                lblX2.Visible = true;
                lblX3.Visible = true;
                lblX4.Visible = true;
                lblY1.Visible = true;
                lblY2.Visible = true;
                lblY3.Visible = true;
                lblY4.Visible = true;
                txtX1.Visible = true;
                txtX2.Visible = true;
                txtX3.Visible = true;
                txtX4.Visible = true;
                txtY1.Visible = true;
                txtY2.Visible = true;
                txtY3.Visible = true;
                txtY4.Visible = true;
                lblX5.Visible = false;
                txtX5.Visible = false;
                lblY5.Visible = false;
                txtY5.Visible = false;
                cmdDibujar.Visible = true;
            }
            if (cbFiguras.Text == "Circulo")
            {
                lblX1.Visible = true;
                lblX2.Visible = true;
                lblX3.Visible = false;
                lblX4.Visible = false;
                lblY1.Visible = true;
                lblY2.Visible = true;
                lblY3.Visible = false;
                lblY4.Visible = false;
                txtX1.Visible = true;
                txtX2.Visible = true;
                txtX3.Visible = false;
                txtX4.Visible = false;
                txtY1.Visible = true;
                txtY2.Visible = true;
                txtY3.Visible = false;
                txtY4.Visible = false;
                lblX5.Visible = false;
                txtX5.Visible = false;
                lblY5.Visible = false;
                txtY5.Visible = false;
                cmdDibujar.Visible = true;
            }
            if(cbFiguras.Text == "Pentágono")
            {
                lblX1.Visible = true;
                lblX2.Visible = true;
                lblX3.Visible = true;
                lblX4.Visible = true;
                lblY1.Visible = true;
                lblY2.Visible = true;
                lblY3.Visible = true;
                lblY4.Visible = true;
                txtX1.Visible = true;
                txtX2.Visible = true;
                txtX3.Visible = true;
                txtX4.Visible = true;
                txtY1.Visible = true;
                txtY2.Visible = true;
                txtY3.Visible = true;
                txtY4.Visible = true;
                lblX5.Visible = true;
                txtX5.Visible = true;
                lblY5.Visible = true;
                txtY5.Visible = true;
                cmdDibujar.Visible = true;
            }
            cmdLimpiar.Visible = true;
        }

        private void cmdRotar_Click(object sender, EventArgs e)
        {
            if (cbAccion.Text == "Rotar" && cbFiguras.Text == "Triángulo")
            {
                triangulo.rotarTriangulo();
            }
            if (cbAccion.Text == "Rotar" && cbFiguras.Text == "Cuadrilatero")
            {
                cuadrilatero.rotarCuadrilatero();
            }
            if (cbAccion.Text == "Rotar" && cbFiguras.Text == "Líneas")
            {
                linea.rotarLinea();
            }
            if(cbAccion.Text == "Rotar" && cbFiguras.Text == "Pentágono")
            {
                pentagono.rotarPentagono();
            }
        }

        private void txtX1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtX2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtX3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtY1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtY2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtY3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtGrados_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int xcentro = pictureBox1.Width / 2;
            int ycentro = pictureBox1.Height / 2;
            Pen lapiz = new Pen(Color.Black, 2);
            e.Graphics.TranslateTransform(xcentro, ycentro);
            e.Graphics.ScaleTransform(1, -1);
            e.Graphics.DrawLine(lapiz, xcentro * -1, 0, xcentro * 2, 0);
            e.Graphics.DrawLine(lapiz, 0, ycentro, 0, ycentro * -1);
            for(int i=-xcentro;i<xcentro;i+=8)
            {
                e.Graphics.DrawLine(lapiz, 5, i, -5, i);
                e.Graphics.DrawLine(lapiz, i, 5, i, -5);
            }
        }

        private void cmdDibujar_Click(object sender, EventArgs e)
        {
            frmMain form = new frmMain();
            this.Size = new Size(954, 386);
            this.Location = new System.Drawing.Point(200, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
            if (cbFiguras.Text == "Triángulo")
            {
                triangulo.graficarTriangulo();
            }
            if(cbFiguras.Text == "Líneas")
            {
                linea.graficarLinea();
            }
            if(cbFiguras.Text == "Cuadrilatero")
            {
                cuadrilatero.graficarCuadrilatero();
            }
            if(cbFiguras.Text == "Circulo")
            {
                circulo.graficarCirculo();
            }
            if(cbFiguras.Text == "Pentágono")
            {
                pentagono.graficarPentagono();
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            txtX1.Clear();
            txtX2.Clear();
            txtX3.Clear();
            txtX4.Clear();
            txtX5.Clear();
            txtY1.Clear();
            txtY2.Clear();
            txtY3.Clear();
            txtY4.Clear();
            txtY5.Clear();
            txtGrados.Clear();
            cbAccion.Text = "";
            cbFiguras.Text = "";
            txtEnX.Clear();
            txtEnY.Clear();
        }

        private void cmdTrasladar_Click_1(object sender, EventArgs e)
        {
            if (cbFiguras.Text == "Triángulo" && cbAccion.Text == "Trasladar")
            {
                triangulo.traslacionTriangulo();
            }
            if (cbFiguras.Text == "Líneas" && cbAccion.Text == "Trasladar")
            {
                linea.traslacionLinea();
            }
            if (cbFiguras.Text == "Cuadrilatero" && cbAccion.Text == "Trasladar")
            {
                cuadrilatero.traslacionCuadrilatero();
            }
            if (cbFiguras.Text == "Pentágono" && cbAccion.Text == "Trasladar")
            {
                pentagono.traslacionPentagono();
            }
        }

        private void cmdEscalar_Click(object sender, EventArgs e)
        {
            if (cbFiguras.Text == "Triángulo" && cbAccion.Text == "Escalar")
            {
                triangulo.escalacionTriangulo();
            }
        }
    }
}
