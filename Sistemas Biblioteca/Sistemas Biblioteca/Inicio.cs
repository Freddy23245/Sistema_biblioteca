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
    
    public partial class Inicio : Form
    {
        private string _usu;

 

        public Inicio()
        {
            InitializeComponent();
        }

        

        public Inicio(string usu)
        {
            // TODO: Complete member initialization
                
            this._usu = usu;
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos alum = new Alumnos();
            alum.Show();
        }

        private void generosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genero gen = new Genero();
            gen.Show();

        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editoriales edit = new Editoriales();
            edit.Show();

        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autores autor = new Autores();
            autor.Show();
        }

        private void asignarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libros libro = new Libros();
            libro.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestamos prest = new Prestamos();
            prest.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usus = new Usuarios();
            usus.Show();
        }


        //void Activar()
        //{
            
           
        //    int i = 0;
        //    int j = 0;

        //    DataTable tabla;
        //    tabla = Lusuarios.LperMenu(_usu);

        //    j = tabla.Rows.Count;


        //    usuariosToolStripMenuItem.Enabled = false;
        //    prestamosToolStripMenuItem.Enabled = false;
        //    alumnosToolStripMenuItem.Enabled = false;
        //    generosToolStripMenuItem.Enabled = false;
        //    autoresToolStripMenuItem.Enabled = false;
        //    editorialesToolStripMenuItem.Enabled = false;
        //    asignarLibrosToolStripMenuItem.Enabled = false;


        //    //while((i<j))
        //    //{
        //    //    if (tabla.Rows[i]("permisos").ToString().Equals("Ventas")) usuariosToolStripMenuItem.Enabled = true;

        //    //    i = i + 1;
        //    //}







        //}






        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void gruposPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void gruposUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void gestionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
