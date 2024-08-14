using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarPantalla();
            textid.Enabled = false;
        }

        public void ActualizarPantalla()
        {
           dataGridView1.DataSource = PersonaDAL.PresentarRegistro();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            DBPersona persona = new DBPersona();
            persona.Nombre = textNombre.Text;
            persona.Edad = Convert.ToInt32(textEdad.Text);
            persona.Celular = textCelular.Text;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            if (id != null)
            {

                persona.id = id;
                int result = PersonaDAL.ModificarPersona(persona);

                if (result > 0)
                {
                    MessageBox.Show("Exito al Modificar");
                }
                else
                {
                    MessageBox.Show("Error al Modificar");
                }
            }
            else
            {
                
                 int result = PersonaDAL.AgregarPersona(persona);

                if (result > 0)
                {
                    MessageBox.Show("Guardado Exitosamente");
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                }
          
            }

          ActualizarPantalla();
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textid.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
            textNombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Nombre"].Value);
            textEdad.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Edad"].Value);
            textCelular.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["Celular"].Value);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Textid_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {

                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                int resultado = PersonaDAL.EliminarPersona(id);
                 if(resultado > 0)
                {
                    MessageBox.Show("Eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al Eliminar");
                }
                    
            }
            ActualizarPantalla();

        }
    }
}
