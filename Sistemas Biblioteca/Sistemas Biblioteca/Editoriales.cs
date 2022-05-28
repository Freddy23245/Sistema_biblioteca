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
    public partial class Editoriales : Form
    {
        public string id_editorial1;
        public string nombre1;
        public bool flag;
        public Editoriales()
        {
            InitializeComponent();
        }
            
        private void mostrar()
        {
            this.dataGridView1.DataSource=Leditoriales.mostrar();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistemas Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Editoriales_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if (txt_nombre_ed.Text=="")
            {
                MensajeError("Por Favor agregue el nombre de la editorial");
            }else
            {
                string rpta = "";



                rpta = Leditoriales.insertar(txt_nombre_ed.Text.Trim());


                if (rpta.Equals("OK"))
                {

                    this.MensajeOk("Se Insertó de forma correcta el registro");
                    this.mostrar();
                }
                else
                {
                    this.MensajeError("No se Inserto de forma correcta el registro");
                }


            }
            }
            
            
          

        private void btn_editar_Click(object sender, EventArgs e)
        {

            if (txt_id.Text=="")
            {
                MensajeError("Por Favor Seleccione el registro a modificar");
            }else
            {
                if(txt_nombre_ed.Text=="")
                {
                    MensajeError("Por Favor agregue el nombre de la editorial");
                }
                else
                {
                    string rpta = "";
                    rpta = Leditoriales.editar(Convert.ToInt32(txt_id.Text), txt_nombre_ed.Text);

                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Edito de Forma Correcta el Registro");
                        this.mostrar();
                    }
                    else
                    {
                        this.MensajeError("No se Edito El Registro");
                    }
                }
            }

           



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_id.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id_editorial"].Value);
            this.txt_nombre_ed.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (txt_id.Text=="")
            {
                MensajeError("Por Favor Seleccione EL registro a modificar");
            }else
            {
                string rpta = "";

                rpta = Leditoriales.eliminar(Convert.ToInt32(txt_id.Text));

                if (rpta.Equals("OK"))
                {
                    MensajeOk("Se Elimino Correctamente");
                    this.mostrar();
                }
                else
                {
                    MensajeError("Error Al Eliminar");
                }

            }
            
            
            


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
            if(this.flag==true)
            {
                id_editorial1 = dgv.Cells[0].Value.ToString();
                nombre1 = dgv.Cells[1].Value.ToString();
            this.Hide();
            }
            

        }

        private void txt_nombre_ed_Validating(object sender, CancelEventArgs e)
        {
            if (txt_nombre_ed.Text.Length > 0)
            {
                error_editorial.SetError(txt_nombre_ed, "");
            }
            else
            {
                error_editorial.SetError(txt_nombre_ed, "El Nombre de la editorial Esta Vacio");
            }
        }



        }
    }

