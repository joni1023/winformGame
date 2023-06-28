using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameForm
{
    public partial class JugarForm : Form
    {
        int cantJugador;
        int tiros;
        string[] vecNombres;
        int eleccion;
        int eleccionPc;
        public JugarForm(int cantJugador, int tiros, string[] vecNombres)
        {
            InitializeComponent();
            this.cantJugador = cantJugador;
            this.tiros = tiros;
            this.vecNombres = vecNombres;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void JugarForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"jugador {vecNombres[0]}";
            label2.Text = "tiro numero 1";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            eleccion = miEleccion("R");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            eleccion = miEleccion("P");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            eleccion = miEleccion("T");
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            eleccionPc = random.Next(1, 4);
            lbEleccionPc.Text = miEleccionString(eleccionPc);
            lbGanador.Text = $"El ganador es : {definirGanador()}";
        }

        private string definirGanador()
        {
            string aux = "";
            if (eleccionPc==1 && eleccion == 3)
            {
                aux = "PC";
            }else if (eleccionPc == 3 && eleccion == 1)
            {
                aux = "vos";
            }else if (eleccionPc < eleccion)
            {
                aux = "vos";
            }
            else if(eleccion == eleccionPc)
            {
                aux = "Empate";
            }
            else
            {
                aux = "Pc";
            }
            return aux;
        }

        private string miEleccionString(int eleccionPc)
        {
            string aux = "";
            switch (eleccionPc)
            {
                case 1:
                    aux = "Piedra";
                    break;
                case 2:
                    aux = "Papel";
                    break;
                case 3:
                    aux = "Tijera";
                    break;
            }
            return aux;
        }

        private int miEleccion(string s)
        {
            int aux = 0;
            switch (s)
            {
                case "R":
                    aux = 1;
                    break;
                case "P":
                    aux = 2;
                    break;
                case "T":
                    aux = 3;
                    break;
            }
            return aux;
        }
    }
}
