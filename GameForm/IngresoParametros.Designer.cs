namespace GameForm
{
    partial class IngresoParametros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbCantJugadores = new TextBox();
            btnAceptarCant = new Button();
            gbCantidad = new GroupBox();
            gbTiros = new GroupBox();
            tbTiros = new TextBox();
            btnVolverCant = new Button();
            btnTiros = new Button();
            gbNombres = new GroupBox();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            btnVolverTiros = new Button();
            btnAceptarFin = new Button();
            lbNombres = new ListBox();
            tbNombre = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            gbCantidad.SuspendLayout();
            gbTiros.SuspendLayout();
            gbNombres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tbCantJugadores
            // 
            tbCantJugadores.Location = new Point(106, 63);
            tbCantJugadores.Name = "tbCantJugadores";
            tbCantJugadores.Size = new Size(100, 29);
            tbCantJugadores.TabIndex = 1;
            // 
            // btnAceptarCant
            // 
            btnAceptarCant.Location = new Point(248, 114);
            btnAceptarCant.Name = "btnAceptarCant";
            btnAceptarCant.Size = new Size(79, 29);
            btnAceptarCant.TabIndex = 2;
            btnAceptarCant.Text = "Aceptar";
            btnAceptarCant.UseVisualStyleBackColor = true;
            btnAceptarCant.Click += btnAceptarCant_Click;
            // 
            // gbCantidad
            // 
            gbCantidad.Controls.Add(btnAceptarCant);
            gbCantidad.Controls.Add(tbCantJugadores);
            gbCantidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gbCantidad.Location = new Point(24, 27);
            gbCantidad.Name = "gbCantidad";
            gbCantidad.Size = new Size(333, 149);
            gbCantidad.TabIndex = 3;
            gbCantidad.TabStop = false;
            gbCantidad.Text = "Cantidad de Jugadores";
            gbCantidad.Enter += groupBox1_Enter;
            // 
            // gbTiros
            // 
            gbTiros.Controls.Add(tbTiros);
            gbTiros.Controls.Add(btnVolverCant);
            gbTiros.Controls.Add(btnTiros);
            gbTiros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbTiros.Location = new Point(411, 27);
            gbTiros.Name = "gbTiros";
            gbTiros.Size = new Size(377, 149);
            gbTiros.TabIndex = 4;
            gbTiros.TabStop = false;
            gbTiros.Text = "Cuantos tiros?";
            gbTiros.Enter += groupBox2_Enter;
            // 
            // tbTiros
            // 
            tbTiros.Location = new Point(131, 68);
            tbTiros.Name = "tbTiros";
            tbTiros.Size = new Size(100, 29);
            tbTiros.TabIndex = 3;
            tbTiros.TextChanged += textBox1_TextChanged;
            // 
            // btnVolverCant
            // 
            btnVolverCant.Location = new Point(195, 114);
            btnVolverCant.Name = "btnVolverCant";
            btnVolverCant.Size = new Size(78, 29);
            btnVolverCant.TabIndex = 1;
            btnVolverCant.Text = "volver";
            btnVolverCant.UseVisualStyleBackColor = true;
            btnVolverCant.Click += button2_Click;
            // 
            // btnTiros
            // 
            btnTiros.Location = new Point(279, 114);
            btnTiros.Name = "btnTiros";
            btnTiros.Size = new Size(75, 29);
            btnTiros.TabIndex = 0;
            btnTiros.Text = "Aceptar";
            btnTiros.UseVisualStyleBackColor = true;
            btnTiros.Click += button1_Click;
            // 
            // gbNombres
            // 
            gbNombres.Controls.Add(btnLimpiar);
            gbNombres.Controls.Add(btnAgregar);
            gbNombres.Controls.Add(btnVolverTiros);
            gbNombres.Controls.Add(btnAceptarFin);
            gbNombres.Controls.Add(lbNombres);
            gbNombres.Controls.Add(tbNombre);
            gbNombres.Location = new Point(24, 221);
            gbNombres.Name = "gbNombres";
            gbNombres.Size = new Size(741, 192);
            gbNombres.TabIndex = 5;
            gbNombres.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(248, 79);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button6_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(152, 79);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button5_Click;
            // 
            // btnVolverTiros
            // 
            btnVolverTiros.Location = new Point(567, 163);
            btnVolverTiros.Name = "btnVolverTiros";
            btnVolverTiros.Size = new Size(75, 23);
            btnVolverTiros.TabIndex = 3;
            btnVolverTiros.Text = "Volver";
            btnVolverTiros.UseVisualStyleBackColor = true;
            btnVolverTiros.Click += btnVolverTiros_Click;
            // 
            // btnAceptarFin
            // 
            btnAceptarFin.Location = new Point(660, 163);
            btnAceptarFin.Name = "btnAceptarFin";
            btnAceptarFin.Size = new Size(75, 23);
            btnAceptarFin.TabIndex = 2;
            btnAceptarFin.Text = "Aceptar";
            btnAceptarFin.UseVisualStyleBackColor = true;
            btnAceptarFin.Click += btnAceptarFin_Click;
            // 
            // lbNombres
            // 
            lbNombres.FormattingEnabled = true;
            lbNombres.ItemHeight = 15;
            lbNombres.Location = new Point(333, 22);
            lbNombres.Name = "lbNombres";
            lbNombres.Size = new Size(215, 139);
            lbNombres.TabIndex = 1;
            lbNombres.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(26, 79);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 0;
            tbNombre.TextChanged += tbNombre_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // IngresoParametros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(gbNombres);
            Controls.Add(gbTiros);
            Controls.Add(gbCantidad);
            Name = "IngresoParametros";
            Text = "IngresoParametros";
            Load += IngresoParametros_Load;
            gbCantidad.ResumeLayout(false);
            gbCantidad.PerformLayout();
            gbTiros.ResumeLayout(false);
            gbTiros.PerformLayout();
            gbNombres.ResumeLayout(false);
            gbNombres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox tbCantJugadores;
        private Button btnAceptarCant;
        private GroupBox gbCantidad;
        private GroupBox gbTiros;
        private TextBox tbTiros;
        private Button btnVolverCant;
        private Button btnTiros;
        private GroupBox gbNombres;
        private ListBox lbNombres;
        private TextBox tbNombre;
        private Button btnLimpiar;
        private Button btnAgregar;
        private Button btnVolverTiros;
        private Button btnAceptarFin;
        private ErrorProvider errorProvider1;
    }
}