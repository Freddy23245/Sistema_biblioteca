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
    public partial class Alumnos : Form
    {

        public string id_alumno1;
        public string nombre1;
        public bool flag;

        public Alumnos()
        {
            InitializeComponent();
            this.txt_id.Visible = false;
        }

        private void limpiar()
        {
            this.txt_nombre.Text = string.Empty;
            this.txt_apellido.Text = string.Empty;
            this.txt_dni.Text = string.Empty;
            this.txt_telefono.Text = string.Empty;
            this.txt_direccion.Text = string.Empty;
            this.txt_mail.Text = string.Empty;
        }
        private void mostrar()
        {
            this.dt_alumnos.DataSource = Lalumnos.mostrar();
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

        private void Alumnos_Load(object sender, EventArgs e)
        {
            this.mostrar();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_nombre.Text == "" || txt_apellido.Text == "" || txt_direccion.Text == "" || txt_dni.Text == "" || txt_telefono.Text == "")
                {
                    this.MensajeError("Por favor verifique que los campos esten llenos");
                }
                else
                {
                    string rpta = "";

                    rpta = Lalumnos.insertar(this.txt_nombre.Text.Trim(), this.txt_apellido.Text.Trim(), txt_dni.Text.Trim(), txt_telefono.Text, txt_direccion.Text, txt_mail.Text);

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text=="")
                {
                    this.MensajeError("Por favor seleccione el registro a modificar");
                }else
                {
                    if (txt_nombre.Text == "" || txt_apellido.Text == "" || txt_direccion.Text == "" || txt_dni.Text == "" || txt_telefono.Text == "")
                    {
                        this.MensajeError("Por favor verifique que los campos esten llenos");
                    }
                    else
                    {
                        string rpta = "";

                        rpta = Lalumnos.editar(Convert.ToInt32(this.txt_id.Text), this.txt_nombre.Text.Trim(), this.txt_apellido.Text.Trim(), txt_dni.Text.Trim(), txt_telefono.Text.Trim(), txt_direccion.Text.Trim(), txt_mail.Text.Trim());
                        if (rpta.Equals("OK"))
                        {

                            this.MensajeOk("Se Actualizo de forma correcta el registro");
                            this.mostrar();
                        }
                        else
                        {
                            this.MensajeError("No Actualizó de forma correcta el registro");
                        }
                    }
                }
              
               
              
             
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dt_alumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_id.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["id_alumno"].Value);
            this.txt_nombre.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["nombre"].Value);
            this.txt_apellido.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["apellido"].Value);
            this.txt_dni.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["dni"].Value);
            this.txt_telefono.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["telefono"].Value);
            this.txt_direccion.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["direccion"].Value);
            this.txt_mail.Text = Convert.ToString(this.dt_alumnos.CurrentRow.Cells["mail"].Value);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_id.Text == "")
                {
                    this.MensajeError("Por Favor Seleccione el registro a eliminar");
                }
                else
                {

                    string rpta = "";


                    rpta = Lalumnos.eliminar(Convert.ToInt32(this.txt_id.Text));


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
           
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dt_alumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dt_alumnos.Rows[e.RowIndex];
            if (flag == true)
            {
                this.id_alumno1 = dgv.Cells[0].Value.ToString();
                this.nombre1 = dgv.Cells[1].Value.ToString();
                this.Hide();
            }
          

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

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

        private void txt_nombre_Validating(object sender, CancelEventArgs e)
        {
            if (txt_nombre.Text.Length > 0)
            {
                error_alumnos.SetError(txt_nombre, "");
            }
            else
            {
                error_alumnos.SetError(txt_nombre, "El Nombre Esta Vacio");
            }
        }

        private void txt_apellido_Validating(object sender, CancelEventArgs e)
        {
            if (txt_apellido.Text.Length > 0)
            {
                error_alumnos.SetError(txt_apellido, "");
            }
            else
            {
                error_alumnos.SetError(txt_apellido, "El campo Apellido Esta Vacio");
            }
        }

        private void txt_dni_Validating(object sender, CancelEventArgs e)
        {
            if (txt_dni.Text.Length > 0)
            {
                error_alumnos.SetError(txt_dni, "");
            }
            else
            {
                error_alumnos.SetError(txt_dni, "El campo Dni Esta Vacio");
            }
        }

        private void txt_telefono_Validating(object sender, CancelEventArgs e)
        {
            if (txt_telefono.Text.Length > 0)
            {
                error_alumnos.SetError(txt_telefono, "");
            }
            else
            {
                error_alumnos.SetError(txt_telefono, "El Nombre Esta Vacio");
            }
        }

        private void txt_direccion_Validating(object sender, CancelEventArgs e)
        {
            if (txt_direccion.Text.Length > 0)
            {
                error_alumnos.SetError(txt_direccion, "");
            }
            else
            {
                error_alumnos.SetError(txt_direccion, "El campo Direccion Esta Vacio");
            }
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {

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

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
     
    }
}
