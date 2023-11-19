using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUI
{
    public partial class Menu : Form
    {
        private Label[] labelsPlatos;
        public Menu()
        {
            InitializeComponent();
            labelsPlatos = new Label[] { plato1, plato2, plato3, plato4, plato5, plato6 };

        }

        private void bebidas_Click(object sender, EventArgs e)
        {
            var bebida = new Bebida("bebida", "precio");
            var i = 0;
            foreach (var bebidaNombre in bebida.GetBebidas())
            {
                labelsPlatos[i].Text = bebidaNombre;
                i++;
            }
        }

        private void burger_Click(object sender, EventArgs e)
        {
            var burger = new Burger("burger", "precio");
            var i = 0;
            foreach (var burgerNombre in burger.GetBebidas())
            {
                labelsPlatos[i].Text = burgerNombre;
                i++;
            }
        }
    }
}
