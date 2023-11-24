using CapaNegocio;
using CapaUI;
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
        private System.Windows.Forms.Button sesion;
        public Usuario usuario = new Usuario();

        public modal(System.Windows.Forms.Button iniciarSesionButton, System.Windows.Forms.Button sesion)
        {
            InitializeComponent();
            this.iniciarSesionButton = iniciarSesionButton;
            this.sesion = sesion;
        }

        //Btn iniciar sesión
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (usuario.getBandera() == 0) 
            {
                if (usuario.ValidarUsuario(inputCorreo.Text, inputContra.Text))
                {

                    MessageBox.Show("Ingreso correctamente");
                    this.Hide();
                    
                    if (iniciarSesionButton != null)
                    {
                        iniciarSesionButton.Text = "Ver Menú";
                        sesion.Hide();
                        
                    }



                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto");
                }

            }
            else
            {
                
                MessageBox.Show("Su sesión se encuentra activa");
            }


        }

        //Boton para cerrar el formulario de inicio de sesion- boton cruz
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
