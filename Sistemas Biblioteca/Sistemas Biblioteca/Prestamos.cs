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
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }

        private void ocultarColumnas()
        {
            this.dt_prestamo.Columns[1].Visible = false;
            this.dt_prestamo.Columns[2].Visible = false;
        }


        private void mostrarse()
        {
            this.dt_prestamo.DataSource = Lprestar.mostrar();
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

        private void btn_traer_alumno_Click(object sender, EventArgs e)
        {
            Alumnos alumno = new Alumnos();
            alumno.flag = true;
            alumno.ShowDialog();

            txt_id_alumno.Text = alumno.id_alumno1;
            txt_alumno.Text = alumno.nombre1;

        }

        private void dt_prestamo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dt_prestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_id_prestamo.Text = Convert.ToString(dt_prestamo.CurrentRow.Cells["id_prestamo"].Value);
            this.txt_id_alumno.Text = Convert.ToString(dt_prestamo.CurrentRow.Cells["id_alumno"].Value);
            this.txt_alumno.Text = Convert.ToString(dt_prestamo.CurrentRow.Cells["Alumno"].Value);
            this.txt_id_libro.Text = Convert.ToString(dt_prestamo.CurrentRow.Cells["id_libro"].Value);
            this.txt_libro.Text = Convert.ToString(dt_prestamo.CurrentRow.Cells["Libro"].Value);
           
            this.dtp_max_prest.Text = Convert.ToString(dt_prestamo.CurrentRow.Cells["fecha_max_dev"].Value);

        


        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {




            if (txt_id_alumno.Text == string.Empty || txt_id_libro.Text == string.Empty)
            {
                MensajeError("Faltan ingresar Datos ");
            }
            else
            {
                if (dtp_prestamo.Value > dtp_max_prest.Value)
                {
                    MessageBox.Show("Asegurese que la fecha del prestamo no se mayor a la devolucion");

                }
                else
                {


                    try
                    {
                        if (VerificarLector() == true)
                        {
                            DialogResult res = MessageBox.Show("El ALumno Tiene Libros Pendientes ¿Desea Prestarle el Libro de Todas Formas?", "Prestamos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (res == DialogResult.Yes)
                            {
                                agregarLibro();
                            }
                        }
                        else
                        {
                            agregarLibro();
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }

        }
            
                
            

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txt_id_prestamo.Text == string.Empty)
            {
                MensajeError("Seleccione Prestamo Para Retornar");
            }else
            {
                string rpta = "";

                try
                {
                    rpta = Lprestar.editar(Convert.ToInt32(txt_id_prestamo.Text), Convert.ToInt32(txt_id_alumno.Text), Convert.ToInt32(txt_id_libro.Text), dtp_max_prest.Value);

                    if (rpta.Equals("OK"))
                    {
                        MensajeOk("El Prestamo Se Edito Correctamente");
                        this.mostrarse();
                    }
                    else
                    {
                        MensajeError("El Prestamo No Se Edito Correcatamente");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           

        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            this.mostrarse();
        }

        private void btn_traer_libro_Click(object sender, EventArgs e)
        {
            Libros libro = new Libros();
            libro.flag = true;
            libro.ShowDialog();

            txt_id_libro.Text = libro.id_libro1;
            txt_libro.Text = libro.nombre1;


        }
   

        private void btn_retornar_Click(object sender, EventArgs e)
        {

            if (txt_id_prestamo.Text == string.Empty)
            {
                MensajeError("Seleccione Prestamo Para Retornar");
            }else
            {
                string rpta = "";

            rpta = Lprestar.retornar(Convert.ToInt32(txt_id_prestamo.Text),Convert.ToInt32(txt_id_libro.Text));
          
            if (rpta.Equals("OK"))
            {

                MensajeOk("Se Retorno Correctamente");
                this.mostrarse();

            }
            else
            {
                MensajeError("Error Al Retornar");
              
            }
            }



            
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(txt_id_prestamo.Text==string.Empty)
            {
                MensajeError("Seleccione Prestamo Para Eliminar");
            }else
            {

                string rpta = "";

                rpta = Lprestar.eliminar(Convert.ToInt32(txt_id_prestamo.Text));

                if (rpta.Equals("OK"))
                {
                    MensajeOk("El Prestamo Se Elimino Correcatamente");
                    this.mostrarse();



                }
                else
                {
                    MensajeError("El Prestamo No Se ELimino");
                }
            }
            
           

        }

        private void btn_deuda_Click(object sender, EventArgs e)
        {




        }


        public bool VerificarLector()
        {
            
                Lalumnos lec=new Lalumnos();
                DataTable resultado;
            

                resultado = Lalumnos.Deuda2(Convert.ToInt32(txt_id_alumno.Text));

                if (resultado.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
          
        }

        void agregarLibro()
        {

            if (txt_libro.Text == "" || txt_id_alumno.Text == "")
            {
                MensajeError("Asegurese de que esten todos los campos completos");
            }
            else
            {

                string rpta = "";
                rpta = Lprestar.insertar(Convert.ToInt32(txt_id_alumno.Text), Convert.ToInt32(txt_id_libro.Text), dtp_max_prest.Value);


                if (rpta.Equals("OK"))
                {
                    MensajeOk("El Prestamo SE Inserto Correctamente");
                    this.mostrarse();


                }
                else
                {
                    MensajeError("El Prestamo No Se Inserto O el Libro Esta Prestado");
                }
            }
        }
    }
}
