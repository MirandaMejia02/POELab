using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //con esos caracteres detecta las letras y no las deja escribir
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //evaluar si no es una tecla de control o caracter
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                //nos permite el acceso de esas teclas
                e.Handled = true;
                label1.Text = "Solo se permiten numeros";
            }
            else
            {
                label1.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //darle color y cambiar cuando se toca el texto de la segunda caja
        private void label2_MouseEnter(object sender, EventArgs e)
        {           
            label2.BackColor = Color.BlueViolet;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Yellow;
        }

        //aca hace lo mismo que la primera, solo que al reves- no deja 
        //escribir numeros
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten caracteres");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //este estuvo un poco dificil para mi
        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            string email = textBox3.Text;

            if (!emailValido(email))
            {
                MessageBox.Show("El correo electronico no es valido");
            }
        }

        //usando try y catch podemos capturas errores y system para validar estructura
        private bool emailValido( string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch { return false; }
            
            
        }
    }
}
