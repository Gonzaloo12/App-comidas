using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_FINAL
{
    public partial class modal : Form
    {
        private System.Windows.Forms.Button iniciarSesionButton;
        public modal(System.Windows.Forms.Button iniciarSesionButton)
        {
            InitializeComponent();
            this.iniciarSesionButton = iniciarSesionButton;
        }

        //public System.Windows.Forms.Button IniciarSesionButton
        //{
        //    get; set;
        //}

        private void modalSesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Usuario usuario = new Usuario();

            if (usuario.ValidarUsuario(inputCorreo.Text, inputContra.Text))
            {

                MessageBox.Show("Ingreso correctamente");

                this.Hide();
               
                if (iniciarSesionButton != null)
                {
                    iniciarSesionButton.Text = "Ver Menú";
                }



            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }

        }

        //Boton para cerrar el formulario de inicio de sesion- boton cruz
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
