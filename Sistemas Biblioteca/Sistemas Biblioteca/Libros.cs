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
    public partial class Libros : Form
    {
        public string id_libro1;
        public string nombre1;
        public bool flag;
        public Libros()
        {
            InitializeComponent();
        }
        private void ocultarColumnas()
        {
            this.dt_libro.Columns[1].Visible = false;
            this.dt_libro.Columns[2].Visible = false;
            this.dt_libro.Columns[3].Visible = false;
        }
        private void mostrar()
        {
            dt_libro.DataSource = Llibros.mostrar();
            this.ocultarColumnas();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_traer_autor_Click(object sender, EventArgs e)
        {
            Autores frm_autor = new Autores();
            frm_autor.flag = true;
            frm_autor.ShowDialog();
            
           
            txt_id_autor.Text = frm_autor.id_autor1;
            txt_nombre_autor.Text = frm_autor.nombre1;
     
        }

        private void btn_traer_gen_Click(object sender, EventArgs e)
        {
            Genero gen = new Genero();
            gen.flag = true;
            gen.ShowDialog();
            txt_id_genero.Text = gen.id_genero1;
            txt_genero.Text = gen.nombre1;

        }

        private void btn_traer_edit_Click(object sender, EventArgs e)
        {
            Editoriales edit = new Editoriales();
            edit.flag = true;
            edit.ShowDialog();
           
            txt_id_editorial.Text = edit.id_editorial1;
            txt_editorial.Text = edit.nombre1;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (txt_nombre.Text=="" || txt_id_autor.Text==""||txt_id_editorial.Text=="" || txt_id_genero.Text=="")
                {
                    MessageBox.Show("Por favor verifique que todos los campos esten llenos");
                    
                    }else
                    {
                     rpta = Llibros.insetar(Convert.ToInt32(txt_id_autor.Text),Convert.ToInt32(txt_id_genero.Text),Convert.ToInt32(txt_id_editorial.Text),txt_nombre.Text,dtp_añop.Value);

                    }



                if(rpta.Equals("OK"))
                {
                    MensajeOk("Se Inserto Correctamente");
                        this.mostrar();
                }
                else
                {
                    MensajeError("El Libro Ya Existe");
                }




            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Libros_Load(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            string rpta = "";

            if (txt_idlibro.Text=="")
            {
                MessageBox.Show("Por Favor Seleccione el libro a modificar");
            }else
            {
                if (txt_nombre.Text=="" || txt_id_autor.Text==""||txt_id_editorial.Text=="" || txt_id_genero.Text=="")
                {
                    MessageBox.Show("Por Favor LLene todos los campos");
                }else
                {
                    rpta = Llibros.editar(Convert.ToInt32(txt_idlibro.Text), Convert.ToInt32(txt_id_autor.Text), Convert.ToInt32(txt_id_genero.Text), Convert.ToInt32(txt_id_editorial.Text), txt_nombre.Text, dtp_añop.Value);

                }
            }

           

            if(rpta.Equals("OK"))
            {
                MensajeOk("EL Libro Se Edito Correctamente");
                this.mostrar();
            }else
            {
                MensajeError("No Se Actualizo El Libro");
            }



        }

        private void dt_libro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_idlibro.Text = Convert.ToString(dt_libro.CurrentRow.Cells["id_libro"].Value);
            this.txt_id_autor.Text = Convert.ToString(dt_libro.CurrentRow.Cells["id_editor"].Value);
            this.txt_id_genero.Text = Convert.ToString(dt_libro.CurrentRow.Cells["id_genero"].Value);
            this.txt_id_editorial.Text = Convert.ToString(dt_libro.CurrentRow.Cells["id_editorial"].Value);
            this.txt_nombre.Text = Convert.ToString(dt_libro.CurrentRow.Cells["nombre"].Value);
            this.dtp_añop.Text = Convert.ToString(dt_libro.CurrentRow.Cells["año_publicacion"].Value);
            //this.cbx_estado.Text = Convert.ToString(dt_libro.CurrentRow.Cells["Estado"].Value);
            this.txt_nombre_autor.Text = Convert.ToString(dt_libro.CurrentRow.Cells["Autor"].Value);
            this.txt_genero.Text = Convert.ToString(dt_libro.CurrentRow.Cells["Genero"].Value);
            this.txt_editorial.Text = Convert.ToString(dt_libro.CurrentRow.Cells["Editorial"].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string rpta = "";

            if(txt_idlibro.Text=="")
            {
                MessageBox.Show("Por Favor Seleccione el libro a Eliminar");
            }
            else
            {
                rpta = Llibros.eliminar(Convert.ToInt32(txt_idlibro.Text));
            }

            

            if(rpta.Equals("OK"))
            {
                MensajeOk("El Libro Se Elimino Correctamente");
                this.mostrar();
            }else
            {
                MensajeError("EL Libro No Se Elimino");
            }


        }

        private void dt_libro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             DataGridViewRow dgv = dt_libro.Rows[e.RowIndex];
             if (this.flag == true)
             {
                 id_libro1 = dgv.Cells[0].Value.ToString();
                 nombre1 = dgv.Cells[4].Value.ToString();
           
                 //form.setAutor(par1, par2);
                 this.Hide();
        }
    }
}
    

}
