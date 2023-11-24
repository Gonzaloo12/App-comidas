using CapaNegocio;
using CapaUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP_FINAL
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        
        }

        private void Menu_Click(object sender, EventArgs e)
        {

            // MUESTRA CATEGORIAS
            var nuevoMenu = new Categoria();
            nuevoMenu.TopLevel = false;
            nuevoMenu.FormBorderStyle = FormBorderStyle.None;
            nuevoMenu.Dock = DockStyle.Fill;
            menu_cate.Controls.Clear();
            menu_cate.Controls.Add(nuevoMenu);
            this.iniciarSesion.Hide();
            nuevoMenu.Show();

        }

        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            if (iniciarSesion.Text == "Iniciar Sesión")
            {
                var modalForm = new modal(iniciarSesion, sesion);
                modalForm.StartPosition = FormStartPosition.Manual;
                modalForm.Location = new Point(
                    this.Location.X + (this.Width - modalForm.Width) / 2,
                    this.Location.Y + (this.Height - modalForm.Height) / 2);
                modalForm.Show();
            }
            else
            {
                var nuevoMenu = new Categoria();
                nuevoMenu.TopLevel = false;
                nuevoMenu.FormBorderStyle = FormBorderStyle.None;
                nuevoMenu.Dock = DockStyle.Fill;
                menu_cate.Controls.Clear();
                menu_cate.Controls.Add(nuevoMenu);
                this.iniciarSesion.Hide();
                nuevoMenu.Show();

            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            menu_cate.Controls.Clear();

        }

        private void sesion_Click(object sender, EventArgs e)
        {
            if (iniciarSesion.Text == "Iniciar Sesión")
            {
                var modalSesion = new modal(iniciarSesion, sesion);


                modalSesion.StartPosition = FormStartPosition.Manual;
                modalSesion.Location = new Point(
                    this.Location.X + (this.Width - modalSesion.Width) / 2,
                    this.Location.Y + (this.Height - modalSesion.Height) / 2);
                modalSesion.Show();

            }
            else
            {

                MessageBox.Show("Su usuario ya se encuentra activo");
            }


        }

    }
}
