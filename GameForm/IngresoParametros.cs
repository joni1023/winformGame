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
    public partial class IngresoParametros : Form
    {
        int cantJugadores;
        int tiros;
        string[] vecNombres = new string[3];
        int indice = 0;

        public IngresoParametros()
        {
            InitializeComponent();
        }

        private void IngresoParametros_Load(object sender, EventArgs e)
        {
            gbTiros.Enabled = false;
            gbNombres.Enabled = false;
            btnAceptarFin.Enabled = false;
            tbCantJugadores.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAceptarCant_Click(object sender, EventArgs e)
        {
            
            cantJugadores = Convert.ToInt32(tbCantJugadores.Text);
            if (cantJugadores <1 || cantJugadores >10 )
            {
                errorProvider1.SetError(tbCantJugadores,"Ingrese un numero entre 1 y 10");
                tbCantJugadores.Clear();
                tbCantJugadores.Focus();
            }
            else
            {
                errorProvider1.Clear();
                gbCantidad.Enabled = false;
                gbTiros.Enabled = true;
                tbTiros.Focus();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbTiros.Enabled = false;
            tbTiros.Clear();
            gbCantidad.Enabled = true;
            tbCantJugadores.Focus();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNombre.Text))
            {
                errorProvider1.SetError(tbNombre, "Debe ingresar un nombre");
                tbNombre.Focus();
            }
            else
            {
                errorProvider1.Clear();
                tbNombre.Focus();
                lbNombres.Items.Add(tbNombre.Text);

                if (lbNombres.Items.Count < cantJugadores)
                {
                    vecNombres[indice] = tbNombre.Text;
                    indice++;
                    tbNombre.Focus();
                }
                else
                {
                    tbNombre.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnAceptarFin.Enabled = true;
                }
                tbNombre.Text = "";
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lbNombres.Items.Clear();
            indice= 0;
            tbNombre.Enabled= true;
            btnAgregar.Enabled= true;
            btnAceptarFin.Enabled= false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            tiros = Convert.ToInt32(tbTiros.Text);
            if(tiros <1 || tiros > 10)
            {
                errorProvider1.SetError(tbTiros, "Ingrese un numero entre 1 y 10");
                tbTiros.Clear();
                tbTiros.Focus();
            }
            else
            {
                errorProvider1.Clear();
                gbTiros.Enabled = false;
                gbNombres.Enabled = true;
                tbNombre.Focus();
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolverTiros_Click(object sender, EventArgs e)
        {
            gbNombres.Enabled = false;
            gbTiros.Enabled = true;
            tbTiros.Focus();
            lbNombres.Items.Clear();
        }
    }
}
