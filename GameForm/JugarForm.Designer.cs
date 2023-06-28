namespace GameForm
{
    partial class JugarForm
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnJugar = new Button();
            labelSub = new Label();
            lbEleccionPc = new Label();
            lbGanador = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 40);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "juagdor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 65);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "tiros";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(101, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 203);
            panel1.TabIndex = 2;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(24, 150);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(53, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Tijera";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(24, 96);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Papel";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(25, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Piedra";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // btnJugar
            // 
            btnJugar.Location = new Point(369, 225);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(75, 23);
            btnJugar.TabIndex = 3;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = true;
            btnJugar.Click += btnJugar_Click;
            // 
            // labelSub
            // 
            labelSub.AutoSize = true;
            labelSub.Location = new Point(487, 137);
            labelSub.Name = "labelSub";
            labelSub.Size = new Size(78, 15);
            labelSub.TabIndex = 4;
            labelSub.Text = "LA Pc Eleigio:";
            // 
            // lbEleccionPc
            // 
            lbEleccionPc.AutoSize = true;
            lbEleccionPc.Location = new Point(502, 229);
            lbEleccionPc.Name = "lbEleccionPc";
            lbEleccionPc.Size = new Size(22, 15);
            lbEleccionPc.TabIndex = 5;
            lbEleccionPc.Text = "PC";
            lbEleccionPc.UseMnemonic = false;
            // 
            // lbGanador
            // 
            lbGanador.AutoSize = true;
            lbGanador.Location = new Point(333, 282);
            lbGanador.Name = "lbGanador";
            lbGanador.Size = new Size(83, 15);
            lbGanador.TabIndex = 6;
            lbGanador.Text = "El ganador es :";
            // 
            // JugarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbGanador);
            Controls.Add(lbEleccionPc);
            Controls.Add(labelSub);
            Controls.Add(btnJugar);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "JugarForm";
            Text = "JugarForm";
            Load += JugarForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnJugar;
        private Label labelSub;
        private Label lbEleccionPc;
        private Label lbGanador;
    }
}