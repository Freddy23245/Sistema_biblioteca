using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Logica;
namespace Sistemas_Biblioteca
{
    public partial class Genero : Form
    {
        public string id_genero1;
        public string nombre1;
        public bool flag;

        public Genero()
        {
            InitializeComponent();
        }

        private void mostrar()
        {
            this.dataGridView1.DataSource = Lgenero.mostrar();
        }
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje,"Sistema Biblioteca",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void Genero_Load(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if (txt_nombre.Text == "")
            {
                MensajeError("Por Favor Agregue El nombre del genero");
            }
            else
            {

                string rpta = "";


                rpta = Lgenero.insertar(txt_nombre.Text.Trim());

                if (rpta.Equals("OK"))
                {
                    this.MensajeOK("El Genero Se Inserto Correctamente");
                    this.mostrar();
                }
                else
                {
                    MensajeError("El Genero No Se Inserto Correctamente");
                }

            }


        }

        private void btn_editar_Click(object sender, EventArgs e)
        {


            if (txt_id_genero.Text == "")
            {
                MensajeError("Por favor seleccione de el registro a modificar");
            }
            else
            {
                if(txt_nombre.Text=="")
                {
                    MensajeError("Por Favor Agregue el nombre del genero");
                }
                else
                {
                    string rpta = "";

                    rpta = Lgenero.editar(Convert.ToInt32(txt_id_genero.Text), txt_nombre.Text);

                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("El Genero Se Edito Correctamente");
                        this.mostrar();
                    }
                    else
                    {
                        MensajeError("EL Genero No Se Edito Correctamente");
                    }
                }
                
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_id_genero.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id_genero"].Value);
            this.txt_nombre.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (txt_id_genero.Text == "")
            {
                MensajeError("Por Favor seleccione el registro a eliminar");
            }
            else
            {



                string rpta = "";

                rpta = Lgenero.eliminar(Convert.ToInt32(txt_id_genero.Text));

                if (rpta.Equals("OK"))
                {
                    MensajeOK("El Genero Se Elimino Correctamente");
                    this.mostrar();
                }
                else
                {
                    MensajeError("El Genero No Se Elimino Correctamente");
                }

            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
            if (this.flag == true)
            {
                id_genero1 = dgv.Cells[0].Value.ToString();
                nombre1 = dgv.Cells[1].Value.ToString();
                this.Hide();
            }
           
        }
    }
}
