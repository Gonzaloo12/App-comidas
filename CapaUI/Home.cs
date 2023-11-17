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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void AboutUs_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            var nuevoMenu = new Menu();
            nuevoMenu.Show();
        }

        private void iniciarSesion_Click(object sender, EventArgs e)
        {
            var modalSesion = new modal();

            modalSesion.StartPosition = FormStartPosition.Manual;
            modalSesion.Location = new Point(
                this.Location.X + (this.Width - modalSesion.Width) / 2,
                this.Location.Y + (this.Height - modalSesion.Height) / 2);
            modalSesion.Show();

        }
    }
}
