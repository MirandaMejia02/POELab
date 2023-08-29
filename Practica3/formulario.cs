using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class formulario : Form
    {
        Calculadora maquina = new Calculadora(4, 5);
        public formulario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maquina.suma().ToString());
            MessageBox.Show(maquina.resta().ToString());
            MessageBox.Show(maquina.multiplicacion().ToString()); 
            MessageBox.Show(maquina.division().ToString());
        }
    }
}
