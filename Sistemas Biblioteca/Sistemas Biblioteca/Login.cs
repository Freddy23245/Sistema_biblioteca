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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        
        
        void Logueo ()
    {

        string usu;
        string contraseña;
        string msj;
        Seguridad seg = new Seguridad();

        usu = txt_usuario.Text;
        contraseña =seg.SHA1Encrypt(txt_contraseña.Text);

        msj = Lusuarios.logL(usu, contraseña);

        MessageBox.Show(msj);

            if(msj.Equals("Bienvenido"))
            {
                Inicio ini = new Inicio();
             
                  ini.Show();

              
                
            }
           


    }



        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Logueo();
         
        }

        private void Login_Load(object sender, EventArgs e)
        {
            


        }

        private void LinkREc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
