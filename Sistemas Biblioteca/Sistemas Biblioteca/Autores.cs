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
    public partial class Autores : Form
    {
      
 public string id_autor1;
        public string nombre1;
        public bool flag;
        public Autores()
        {
            InitializeComponent();
        }
       
        private void mostrar()
        {
            this.dt_autores.DataSource = lAutores.mostrar();
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


        private void btn_agregar_Click(object sender, EventArgs e)
        {
           

            try
            {

                if (txt_nombre.Text == "" || txt_apellido.Text == "")
                {
                    this.MensajeError("Por Favor Verifique que Todos los Campos esten Completados");
                }
                else
                {

                    string rpta = "";

                    rpta = lAutores.insertar(this.txt_nombre.Text.Trim(), this.txt_apellido.Text.Trim(), this.txt_mail.Text).Trim();





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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Autores_Load(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void dt_autores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_id_autor.Text = Convert.ToString(dt_autores.CurrentRow.Cells["id_autor"].Value);
            this.txt_nombre.Text = Convert.ToString(dt_autores.CurrentRow.Cells["nombre"].Value);
            this.txt_apellido.Text = Convert.ToString(dt_autores.CurrentRow.Cells["apellido"].Value);
            this.txt_mail.Text = Convert.ToString(dt_autores.CurrentRow.Cells["mail"].Value);
               
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id_autor.Text=="")
                {
                    this.MensajeError("Por favor seleccione el registro a modificar");
                }else
                {
                    if (txt_nombre.Text == "" || txt_apellido.Text == "")
                    {
                        this.MensajeError("Por Favor Verifique que Todos los Campos esten Completados");
                    }
                    else
                    {
                        string rpta = "";

                        rpta = lAutores.editar(Convert.ToInt32(txt_id_autor.Text), txt_nombre.Text.Trim(), txt_apellido.Text, txt_mail.Text);



                        if (rpta.Equals("OK"))
                        {

                            this.MensajeOk("Se Edito Correctamente");
                            this.mostrar();
                        }
                        else
                        {
                            MensajeError("No Se edito correctamente");
                        }
                
                    }
                }



              
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
             try
            {

                if (txt_id_autor.Text == "")
                {
                    this.MensajeError("Por Favor Seleccione el registro a eliminar");
                }else
                {
                    string rpta = "";


                    rpta = lAutores.eliminar(Convert.ToInt32(this.txt_id_autor.Text));


                    if (rpta.Equals("OK"))
                    {

                        this.MensajeOk("Se elimino de forma correcta el registro");
                        this.mostrar();

                        //this.MensajeError("No se elimino de forma correcta el registro");

                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                   
                }


                
        }
            catch(Exception ex)
             {
                MessageBox.Show(ex.Message);
            }
    }

        private void dt_autores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Libros form = new Libros();
             DataGridViewRow dgv = dt_autores.Rows[e.RowIndex];
             if (this.flag == true)
             {
                 id_autor1 = dgv.Cells[0].Value.ToString();
                 nombre1 = dgv.Cells[1].Value.ToString();
           
                 //form.setAutor(par1, par2);
                 this.Hide();
             }
             
         
        }

        private void txt_nombre_Validating(object sender, CancelEventArgs e)
        {
            if (txt_nombre.Text.Length > 0)
            {
                error_autor.SetError(txt_nombre, "");
            }
            else
            {
                error_autor.SetError(txt_nombre, "El campo Direccion Esta Vacio");
            }
        }

        private void txt_apellido_Validating(object sender, CancelEventArgs e)
        {
            if (txt_apellido.Text.Length > 0)
            {
                error_autor.SetError(txt_apellido, "");
            }
            else
            {
                error_autor.SetError(txt_apellido, "El campo Direccion Esta Vacio");
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
}}
