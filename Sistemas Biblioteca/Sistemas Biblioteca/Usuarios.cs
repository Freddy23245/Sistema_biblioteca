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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        Seguridad seg = new Seguridad();
        private void mostrar()
        {
            this.dt_usuarios.DataSource = Lusuarios.mostrar();
        }

        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.mostrar();

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if (txt_nombre.Text=="" || txt_usuario.Text=="" || txt_contraseña.Text=="" || txt_email.Text=="")
            {
                MensajeError("Verifique que todos los campos esten llenos");
            }else
            {


            string rpta = "";
            
            rpta = Lusuarios.insertar(txt_nombre.Text, txt_usuario.Text,seg.SHA1Encrypt( txt_contraseña.Text), chk_habilitado.Checked,txt_email.Text);

            if(rpta.Equals("OK"))
            {
                MensajeOK("Se Inserto Correctamente");
                this.mostrar();
            }else
            {
                MensajeError("No Se Inserto Correctamente");
            }
            }


        }

        private void dt_usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_usuario.Text = Convert.ToString(dt_usuarios.CurrentRow.Cells["id_usuario"].Value);
            txt_nombre.Text = Convert.ToString(dt_usuarios.CurrentRow.Cells["nombre"].Value);
            txt_usuario.Text = Convert.ToString(dt_usuarios.CurrentRow.Cells["usuario"].Value);
            txt_contraseña.Text = Convert.ToString(dt_usuarios.CurrentRow.Cells["contraseña"].Value);
            chk_habilitado.Checked = Convert.ToBoolean(dt_usuarios.CurrentRow.Cells["habilitado"].Value);
            txt_email.Text = Convert.ToString(dt_usuarios.CurrentRow.Cells["Email"].Value);
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (txt_id_usuario.Text == "")
            {
                MensajeError("Por Favor Seleccione El registro a Eliminar");
            }
            else
            {

                string rpta = "";


                rpta = Lusuarios.eliminar(Convert.ToInt32(txt_id_usuario.Text));

                if (rpta.Equals("OK"))
                {
                    MensajeOK("Se Elimino Correctamente");
                    this.mostrar();
                }
                else
                {
                    MensajeError("No Se ELimino Nada");
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            if (txt_id_usuario.Text=="")
            {
                MensajeError("Por Favor Seleccione el registro a modificar");
            }else
            {
                if (txt_nombre.Text == "" || txt_usuario.Text == "" || txt_contraseña.Text == "" || txt_email.Text == "")
                {
                    MensajeError("Verifique que todos los campos esten llenos");

                }else
                {

                    string rpta = "";


                    rpta = Lusuarios.editar(Convert.ToInt32(txt_id_usuario.Text), txt_nombre.Text, txt_usuario.Text, seg.SHA1Encrypt(txt_contraseña.Text), chk_habilitado.Checked, txt_email.Text);

                    if (rpta.Equals("OK"))
                    {
                        MensajeOK("Se Edito Correctamente");
                        this.mostrar();
                    }
                    else
                    {
                        MensajeError("No Se Edito Nada");
                    }

                }
            }



        }
    }
}
