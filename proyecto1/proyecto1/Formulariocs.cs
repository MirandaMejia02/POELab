using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class Formulariocs : Form
    {
        Calculadora zoom = new Calculadora(5, 6);
        public Formulariocs()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(zoom.suma().ToString());
        }
    }
}
