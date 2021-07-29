namespace Evaluacion2
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbFiguras = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFigura = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.cbAccion = new System.Windows.Forms.ComboBox();
            this.lblGrados = new System.Windows.Forms.Label();
            this.txtGrados = new System.Windows.Forms.TextBox();
            this.cmdRotar = new System.Windows.Forms.Button();
            this.cmdIngresarDatos = new System.Windows.Forms.Button();
            this.lblX1 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.lblX2 = new System.Windows.Forms.Label();
            this.txtX3 = new System.Windows.Forms.TextBox();
            this.lblX3 = new System.Windows.Forms.Label();
            this.txtY3 = new System.Windows.Forms.TextBox();
            this.lblY3 = new System.Windows.Forms.Label();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.lblY2 = new System.Windows.Forms.Label();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.lblY1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdDibujar = new System.Windows.Forms.Button();
            this.txtY4 = new System.Windows.Forms.TextBox();
            this.lblY4 = new System.Windows.Forms.Label();
            this.txtX4 = new System.Windows.Forms.TextBox();
            this.lblX4 = new System.Windows.Forms.Label();
            this.txtY5 = new System.Windows.Forms.TextBox();
            this.lblY5 = new System.Windows.Forms.Label();
            this.txtX5 = new System.Windows.Forms.TextBox();
            this.lblX5 = new System.Windows.Forms.Label();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.lblEnX = new System.Windows.Forms.Label();
            this.txtEnX = new System.Windows.Forms.TextBox();
            this.txtEnY = new System.Windows.Forms.TextBox();
            this.lblEnY = new System.Windows.Forms.Label();
            this.cmdTrasladar = new System.Windows.Forms.Button();
            this.cmdEscalar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFiguras
            // 
            this.cbFiguras.FormattingEnabled = true;
            this.cbFiguras.Items.AddRange(new object[] {
            "Líneas",
            "Triángulo",
            "Cuadrilatero",
            "Pentágono"});
            this.cbFiguras.Location = new System.Drawing.Point(251, 96);
            this.cbFiguras.Name = "cbFiguras";
            this.cbFiguras.Size = new System.Drawing.Size(126, 21);
            this.cbFiguras.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(59, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(330, 62);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Evaluación Parcial 2";
            // 
            // lblFigura
            // 
            this.lblFigura.AutoSize = true;
            this.lblFigura.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFigura.ForeColor = System.Drawing.Color.White;
            this.lblFigura.Location = new System.Drawing.Point(60, 87);
            this.lblFigura.Name = "lblFigura";
            this.lblFigura.Size = new System.Drawing.Size(191, 43);
            this.lblFigura.TabIndex = 2;
            this.lblFigura.Text = "Elige una figura:";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.ForeColor = System.Drawing.Color.White;
            this.lblAccion.Location = new System.Drawing.Point(15, 130);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(236, 43);
            this.lblAccion.TabIndex = 3;
            this.lblAccion.Text = "¿Qué quieres hacer?";
            // 
            // cbAccion
            // 
            this.cbAccion.FormattingEnabled = true;
            this.cbAccion.Items.AddRange(new object[] {
            "Rotar",
            "Trasladar",
            "Escalar",
            "Segmentar"});
            this.cbAccion.Location = new System.Drawing.Point(251, 135);
            this.cbAccion.Name = "cbAccion";
            this.cbAccion.Size = new System.Drawing.Size(126, 21);
            this.cbAccion.TabIndex = 4;
            // 
            // lblGrados
            // 
            this.lblGrados.AutoSize = true;
            this.lblGrados.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrados.ForeColor = System.Drawing.Color.White;
            this.lblGrados.Location = new System.Drawing.Point(64, 173);
            this.lblGrados.Name = "lblGrados";
            this.lblGrados.Size = new System.Drawing.Size(79, 34);
            this.lblGrados.TabIndex = 5;
            this.lblGrados.Text = "Grados:";
            this.lblGrados.Visible = false;
            // 
            // txtGrados
            // 
            this.txtGrados.Location = new System.Drawing.Point(144, 178);
            this.txtGrados.Name = "txtGrados";
            this.txtGrados.Size = new System.Drawing.Size(100, 20);
            this.txtGrados.TabIndex = 6;
            this.txtGrados.Visible = false;
            this.txtGrados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrados_KeyPress);
            // 
            // cmdRotar
            // 
            this.cmdRotar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.cmdRotar.FlatAppearance.BorderSize = 2;
            this.cmdRotar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.cmdRotar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.cmdRotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRotar.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRotar.ForeColor = System.Drawing.Color.White;
            this.cmdRotar.Location = new System.Drawing.Point(287, 171);
            this.cmdRotar.Name = "cmdRotar";
            this.cmdRotar.Size = new System.Drawing.Size(62, 36);
            this.cmdRotar.TabIndex = 7;
            this.cmdRotar.Text = "Rotar";
            this.cmdRotar.UseVisualStyleBackColor = true;
            this.cmdRotar.Visible = false;
            this.cmdRotar.Click += new System.EventHandler(this.cmdRotar_Click);
            // 
            // cmdIngresarDatos
            // 
            this.cmdIngresarDatos.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.cmdIngresarDatos.FlatAppearance.BorderSize = 2;
            this.cmdIngresarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.cmdIngresarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.cmdIngresarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIngresarDatos.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIngresarDatos.ForeColor = System.Drawing.Color.White;
            this.cmdIngresarDatos.Location = new System.Drawing.Point(383, 92);
            this.cmdIngresarDatos.Name = "cmdIngresarDatos";
            this.cmdIngresarDatos.Size = new System.Drawing.Size(78, 69);
            this.cmdIngresarDatos.TabIndex = 8;
            this.cmdIngresarDatos.Text = "Ingresar Datos";
            this.cmdIngresarDatos.UseVisualStyleBackColor = true;
            this.cmdIngresarDatos.Click += new System.EventHandler(this.cmdIngresarDatos_Click);
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX1.ForeColor = System.Drawing.Color.White;
            this.lblX1.Location = new System.Drawing.Point(63, 216);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(32, 27);
            this.lblX1.TabIndex = 9;
            this.lblX1.Text = "X1:";
            this.lblX1.Visible = false;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(101, 216);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(94, 20);
            this.txtX1.TabIndex = 10;
            this.txtX1.Visible = false;
            this.txtX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX1_KeyPress);
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(101, 242);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(94, 20);
            this.txtX2.TabIndex = 12;
            this.txtX2.Visible = false;
            this.txtX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX2_KeyPress);
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2.ForeColor = System.Drawing.Color.White;
            this.lblX2.Location = new System.Drawing.Point(63, 242);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(32, 27);
            this.lblX2.TabIndex = 11;
            this.lblX2.Text = "X2:";
            this.lblX2.Visible = false;
            // 
            // txtX3
            // 
            this.txtX3.Location = new System.Drawing.Point(101, 268);
            this.txtX3.Name = "txtX3";
            this.txtX3.Size = new System.Drawing.Size(94, 20);
            this.txtX3.TabIndex = 14;
            this.txtX3.Visible = false;
            this.txtX3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX3_KeyPress);
            // 
            // lblX3
            // 
            this.lblX3.AutoSize = true;
            this.lblX3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX3.ForeColor = System.Drawing.Color.White;
            this.lblX3.Location = new System.Drawing.Point(63, 268);
            this.lblX3.Name = "lblX3";
            this.lblX3.Size = new System.Drawing.Size(32, 27);
            this.lblX3.TabIndex = 13;
            this.lblX3.Text = "X3:";
            this.lblX3.Visible = false;
            // 
            // txtY3
            // 
            this.txtY3.Location = new System.Drawing.Point(255, 265);
            this.txtY3.Name = "txtY3";
            this.txtY3.Size = new System.Drawing.Size(94, 20);
            this.txtY3.TabIndex = 20;
            this.txtY3.Visible = false;
            this.txtY3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY3_KeyPress);
            // 
            // lblY3
            // 
            this.lblY3.AutoSize = true;
            this.lblY3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY3.ForeColor = System.Drawing.Color.White;
            this.lblY3.Location = new System.Drawing.Point(217, 265);
            this.lblY3.Name = "lblY3";
            this.lblY3.Size = new System.Drawing.Size(31, 27);
            this.lblY3.TabIndex = 19;
            this.lblY3.Text = "Y3:";
            this.lblY3.Visible = false;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(255, 239);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(94, 20);
            this.txtY2.TabIndex = 18;
            this.txtY2.Visible = false;
            this.txtY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY2_KeyPress);
            // 
            // lblY2
            // 
            this.lblY2.AutoSize = true;
            this.lblY2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY2.ForeColor = System.Drawing.Color.White;
            this.lblY2.Location = new System.Drawing.Point(217, 239);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(31, 27);
            this.lblY2.TabIndex = 17;
            this.lblY2.Text = "Y2:";
            this.lblY2.Visible = false;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(255, 213);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(94, 20);
            this.txtY1.TabIndex = 16;
            this.txtY1.Visible = false;
            this.txtY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY1_KeyPress);
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY1.ForeColor = System.Drawing.Color.White;
            this.lblY1.Location = new System.Drawing.Point(217, 213);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(31, 27);
            this.lblY1.TabIndex = 15;
            this.lblY1.Text = "Y1:";
            this.lblY1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox1.Location = new System.Drawing.Point(486, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 297);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // cmdDibujar
            // 
            this.cmdDibujar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.cmdDibujar.FlatAppearance.BorderSize = 2;
            this.cmdDibujar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.cmdDibujar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.cmdDibujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDibujar.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDibujar.ForeColor = System.Drawing.Color.White;
            this.cmdDibujar.Location = new System.Drawing.Point(379, 235);
            this.cmdDibujar.Name = "cmdDibujar";
            this.cmdDibujar.Size = new System.Drawing.Size(82, 36);
            this.cmdDibujar.TabIndex = 22;
            this.cmdDibujar.Text = "Dibujar";
            this.cmdDibujar.UseVisualStyleBackColor = true;
            this.cmdDibujar.Visible = false;
            this.cmdDibujar.Click += new System.EventHandler(this.cmdDibujar_Click);
            // 
            // txtY4
            // 
            this.txtY4.Location = new System.Drawing.Point(255, 291);
            this.txtY4.Name = "txtY4";
            this.txtY4.Size = new System.Drawing.Size(94, 20);
            this.txtY4.TabIndex = 26;
            this.txtY4.Visible = false;
            // 
            // lblY4
            // 
            this.lblY4.AutoSize = true;
            this.lblY4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY4.ForeColor = System.Drawing.Color.White;
            this.lblY4.Location = new System.Drawing.Point(217, 291);
            this.lblY4.Name = "lblY4";
            this.lblY4.Size = new System.Drawing.Size(31, 27);
            this.lblY4.TabIndex = 25;
            this.lblY4.Text = "Y4:";
            this.lblY4.Visible = false;
            // 
            // txtX4
            // 
            this.txtX4.Location = new System.Drawing.Point(101, 294);
            this.txtX4.Name = "txtX4";
            this.txtX4.Size = new System.Drawing.Size(94, 20);
            this.txtX4.TabIndex = 24;
            this.txtX4.Visible = false;
            // 
            // lblX4
            // 
            this.lblX4.AutoSize = true;
            this.lblX4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX4.ForeColor = System.Drawing.Color.White;
            this.lblX4.Location = new System.Drawing.Point(63, 294);
            this.lblX4.Name = "lblX4";
            this.lblX4.Size = new System.Drawing.Size(32, 27);
            this.lblX4.TabIndex = 23;
            this.lblX4.Text = "X4:";
            this.lblX4.Visible = false;
            // 
            // txtY5
            // 
            this.txtY5.Location = new System.Drawing.Point(255, 317);
            this.txtY5.Name = "txtY5";
            this.txtY5.Size = new System.Drawing.Size(94, 20);
            this.txtY5.TabIndex = 30;
            this.txtY5.Visible = false;
            // 
            // lblY5
            // 
            this.lblY5.AutoSize = true;
            this.lblY5.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY5.ForeColor = System.Drawing.Color.White;
            this.lblY5.Location = new System.Drawing.Point(217, 317);
            this.lblY5.Name = "lblY5";
            this.lblY5.Size = new System.Drawing.Size(31, 27);
            this.lblY5.TabIndex = 29;
            this.lblY5.Text = "Y5:";
            this.lblY5.Visible = false;
            // 
            // txtX5
            // 
            this.txtX5.Location = new System.Drawing.Point(101, 320);
            this.txtX5.Name = "txtX5";
            this.txtX5.Size = new System.Drawing.Size(94, 20);
            this.txtX5.TabIndex = 28;
            this.txtX5.Visible = false;
            // 
            // lblX5
            // 
            this.lblX5.AutoSize = true;
            this.lblX5.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX5.ForeColor = System.Drawing.Color.White;
            this.lblX5.Location = new System.Drawing.Point(63, 320);
            this.lblX5.Name = "lblX5";
            this.lblX5.Size = new System.Drawing.Size(32, 27);
            this.lblX5.TabIndex = 27;
            this.lblX5.Text = "X5:";
            this.lblX5.Visible = false;
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.cmdLimpiar.FlatAppearance.BorderSize = 2;
            this.cmdLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.cmdLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.cmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLimpiar.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.ForeColor = System.Drawing.Color.White;
            this.cmdLimpiar.Location = new System.Drawing.Point(379, 284);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(82, 36);
            this.cmdLimpiar.TabIndex = 31;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Visible = false;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // lblEnX
            // 
            this.lblEnX.AutoSize = true;
            this.lblEnX.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnX.ForeColor = System.Drawing.Color.White;
            this.lblEnX.Location = new System.Drawing.Point(31, 171);
            this.lblEnX.Name = "lblEnX";
            this.lblEnX.Size = new System.Drawing.Size(56, 34);
            this.lblEnX.TabIndex = 32;
            this.lblEnX.Text = "En X:";
            this.lblEnX.Visible = false;
            // 
            // txtEnX
            // 
            this.txtEnX.Location = new System.Drawing.Point(93, 173);
            this.txtEnX.Name = "txtEnX";
            this.txtEnX.Size = new System.Drawing.Size(89, 20);
            this.txtEnX.TabIndex = 33;
            this.txtEnX.Visible = false;
            // 
            // txtEnY
            // 
            this.txtEnY.Location = new System.Drawing.Point(250, 169);
            this.txtEnY.Name = "txtEnY";
            this.txtEnY.Size = new System.Drawing.Size(89, 20);
            this.txtEnY.TabIndex = 35;
            this.txtEnY.Visible = false;
            // 
            // lblEnY
            // 
            this.lblEnY.AutoSize = true;
            this.lblEnY.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnY.ForeColor = System.Drawing.Color.White;
            this.lblEnY.Location = new System.Drawing.Point(188, 167);
            this.lblEnY.Name = "lblEnY";
            this.lblEnY.Size = new System.Drawing.Size(56, 34);
            this.lblEnY.TabIndex = 34;
            this.lblEnY.Text = "En Y:";
            this.lblEnY.Visible = false;
            // 
            // cmdTrasladar
            // 
            this.cmdTrasladar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.cmdTrasladar.FlatAppearance.BorderSize = 2;
            this.cmdTrasladar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.cmdTrasladar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.cmdTrasladar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTrasladar.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTrasladar.ForeColor = System.Drawing.Color.White;
            this.cmdTrasladar.Location = new System.Drawing.Point(369, 169);
            this.cmdTrasladar.Name = "cmdTrasladar";
            this.cmdTrasladar.Size = new System.Drawing.Size(92, 36);
            this.cmdTrasladar.TabIndex = 36;
            this.cmdTrasladar.Text = "Trasladar";
            this.cmdTrasladar.UseVisualStyleBackColor = true;
            this.cmdTrasladar.Visible = false;
            this.cmdTrasladar.Click += new System.EventHandler(this.cmdTrasladar_Click_1);
            // 
            // cmdEscalar
            // 
            this.cmdEscalar.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.cmdEscalar.FlatAppearance.BorderSize = 2;
            this.cmdEscalar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.cmdEscalar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.cmdEscalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEscalar.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEscalar.ForeColor = System.Drawing.Color.White;
            this.cmdEscalar.Location = new System.Drawing.Point(369, 173);
            this.cmdEscalar.Name = "cmdEscalar";
            this.cmdEscalar.Size = new System.Drawing.Size(92, 36);
            this.cmdEscalar.TabIndex = 37;
            this.cmdEscalar.Text = "Escalar";
            this.cmdEscalar.UseVisualStyleBackColor = true;
            this.cmdEscalar.Visible = false;
            this.cmdEscalar.Click += new System.EventHandler(this.cmdEscalar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(482, 347);
            this.Controls.Add(this.cmdEscalar);
            this.Controls.Add(this.cmdTrasladar);
            this.Controls.Add(this.txtEnY);
            this.Controls.Add(this.lblEnY);
            this.Controls.Add(this.txtEnX);
            this.Controls.Add(this.lblEnX);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.txtY5);
            this.Controls.Add(this.lblY5);
            this.Controls.Add(this.txtX5);
            this.Controls.Add(this.lblX5);
            this.Controls.Add(this.txtY4);
            this.Controls.Add(this.lblY4);
            this.Controls.Add(this.txtX4);
            this.Controls.Add(this.lblX4);
            this.Controls.Add(this.cmdDibujar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtY3);
            this.Controls.Add(this.lblY3);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.lblY2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.lblY1);
            this.Controls.Add(this.txtX3);
            this.Controls.Add(this.lblX3);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.cmdIngresarDatos);
            this.Controls.Add(this.cmdRotar);
            this.Controls.Add(this.txtGrados);
            this.Controls.Add(this.lblGrados);
            this.Controls.Add(this.cbAccion);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblFigura);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbFiguras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluación";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFiguras;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFigura;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.ComboBox cbAccion;
        private System.Windows.Forms.Label lblGrados;
        private System.Windows.Forms.TextBox txtGrados;
        private System.Windows.Forms.Button cmdRotar;
        private System.Windows.Forms.Button cmdIngresarDatos;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.TextBox txtX3;
        private System.Windows.Forms.Label lblX3;
        private System.Windows.Forms.TextBox txtY3;
        private System.Windows.Forms.Label lblY3;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdDibujar;
        private System.Windows.Forms.TextBox txtY4;
        private System.Windows.Forms.Label lblY4;
        private System.Windows.Forms.TextBox txtX4;
        private System.Windows.Forms.Label lblX4;
        private System.Windows.Forms.TextBox txtY5;
        private System.Windows.Forms.Label lblY5;
        private System.Windows.Forms.TextBox txtX5;
        private System.Windows.Forms.Label lblX5;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Label lblEnX;
        private System.Windows.Forms.TextBox txtEnX;
        private System.Windows.Forms.TextBox txtEnY;
        private System.Windows.Forms.Label lblEnY;
        private System.Windows.Forms.Button cmdTrasladar;
        private System.Windows.Forms.Button cmdEscalar;
    }
}

