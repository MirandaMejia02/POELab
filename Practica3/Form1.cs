namespace Practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text;
            string letra = txtLetra.Text;

            if (string.IsNullOrEmpty(letra) ||
                string.IsNullOrWhiteSpace(letra))
              {
                MessageBox.Show("Escribe un texto");
              }

            if (int.TryParse(numero, out int n))
            {
                MessageBox.Show("Es un numero!");
            }
            else
            {
                MessageBox.Show("No es un numero!");
            }
        }
    }
}