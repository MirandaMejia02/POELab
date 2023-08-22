namespace practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double montoInicial, porcentaje, interesCompuesto;

            montoInicial = Convert.ToDouble(txtMonto.Text);
            porcentaje = Convert.ToDouble(txtPorcentaje.Text);

            interesCompuesto = montoInicial + (montoInicial * (porcentaje / 100));

            lblMensaje.Text = "El interes compuesto es: " + interesCompuesto.ToString();
        }
    }
}