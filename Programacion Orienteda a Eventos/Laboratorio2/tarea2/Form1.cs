
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;



namespace POEllaboratorio_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO Hospital (NOMBRE,MATERIAL,EQUIPO,MEDICINA,CANTIDAD_MEDICINA,CANTIDAD_MATERIAL,CANTIDAD_EQUIPO)VALUES(@NOMBRE,@MATERIAL,@EQUIPO,@MEDICINA,@CANTIDAD_MEDICINA,@CANTIDAD_MATERIAL,@CANTIDAD_EQUIPO)";
           SqlCommand cmd1 = new SqlCommand(insertar,Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@NOMBRE", txtnombre.Text);
            cmd1.Parameters.AddWithValue("@MATERIAL", combomaterial.Text);
            cmd1.Parameters.AddWithValue("@EQUIPO", comboequipo.Text);
            cmd1.Parameters.AddWithValue("@MEDICINA", combomedicina.Text);
            cmd1.Parameters.AddWithValue("@CANTIDAD_MEDICINA", txt1.Text);
            cmd1.Parameters.AddWithValue("@CANTIDAD_MATERIAL", txt2.Text);
            cmd1.Parameters.AddWithValue("@CANTIDAD_EQUIPO", txt3.Text);

            cmd1.ExecuteNonQuery();
            MessageBox.Show("Los datos han sido registrado correctamente");
            dataGridView1.DataSource = llenar_grid();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = Conexion.Conectar())
                {
                    string actualizar = "UPDATE Hospital SET MATERIAL=@MATERIAL,EQUIPO=@EQUIPO,MEDICINA=@MEDICINA,CANTIDAD_MEDICINA=@CANTIDAD_MEDICINA,CANTIDAD_MATERIAL=@CANTIDAD_MATERIAL,CANTIDAD_EQUIPO=@CANTIDAD_EQUIPO";
                    SqlCommand cmd2 = new SqlCommand(actualizar, connection);

                    cmd2.Parameters.AddWithValue("@NOMBRE", txtnombre.Text);
                    cmd2.Parameters.AddWithValue("@MATERIAL", combomaterial.Text);
                    cmd2.Parameters.AddWithValue("@EQUIPO", comboequipo.Text);
                    cmd2.Parameters.AddWithValue("@MEDICINA", combomedicina.Text);
                    cmd2.Parameters.AddWithValue("@CANTIDAD_MEDICINA", txt1.Text);
                    cmd2.Parameters.AddWithValue("@CANTIDAD_MATERIAL", txt2.Text);
                    cmd2.Parameters.AddWithValue("@CANTIDAD_EQUIPO", txt3.Text);

                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido actualizados correctamente");
                    dataGridView1.DataSource = llenar_grid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboequipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void coombomaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combomedicina_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");

            dataGridView1.DataSource = llenar_grid();

        }
        public DataTable llenar_grid()
        {
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Hospital";
            SqlCommand cmd = new SqlCommand(consulta,Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            da.Fill(dt);
            return dt;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                txtnombre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                combomaterial.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboequipo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                combomedicina.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch { 
            
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string eliminar = "DELETE FROM Hospital WHERE NOMBRE = @NOMBRE";  // Agregar la condición WHERE
            using (SqlConnection connection = Conexion.Conectar())
            {
                SqlCommand cmd3 = new SqlCommand(eliminar, connection);
                cmd3.Parameters.AddWithValue("@NOMBRE", txtnombre.Text);

                cmd3.ExecuteNonQuery();

                MessageBox.Show("Los datos han sido eliminados");

                dataGridView1.DataSource = llenar_grid();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
        }
    }
}
