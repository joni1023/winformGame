namespace GameForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSalir.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            btnSalir.Enabled = true;
            IngresoParametros ventanaIngreso = new IngresoParametros();
            ventanaIngreso.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}