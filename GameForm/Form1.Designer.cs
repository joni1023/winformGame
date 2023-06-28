namespace GameForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            labelTitle = new Label();
            btnAceptar = new Button();
            labelDeveloper = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com;
            pictureBox1.Location = new Point(303, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(309, 285);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(341, 240);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(115, 15);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Piedra , Papel , Tijera";
            labelTitle.Click += label1_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(408, 285);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Jugar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // labelDeveloper
            // 
            labelDeveloper.AutoSize = true;
            labelDeveloper.Location = new Point(309, 414);
            labelDeveloper.Name = "labelDeveloper";
            labelDeveloper.Size = new Size(174, 15);
            labelDeveloper.TabIndex = 4;
            labelDeveloper.Text = "Desarrollado - Jonathan fuentes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDeveloper);
            Controls.Add(btnAceptar);
            Controls.Add(labelTitle);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Pantalla Principal";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnSalir;
        private Label labelTitle;
        private Button btnAceptar;
        private Label labelDeveloper;
    }
}