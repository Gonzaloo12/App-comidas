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
    public partial class FormTicket : Form
    {
        private Categoria categoria;
        public FormTicket(Categoria datos)
        {
            InitializeComponent();
            categoria = datos;
            
            var usuarioActual = new Usuario();
            traerDatos();

            labelNroTotal.Text = datos.ImporteTotal;
            labelDatoCliente.Text = usuarioActual.getUsuario();
            labelFecha.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            medioPago.Text = datos.getMedioPago();
            
        }

        public void traerDatos()
        {
            DataGridViewRowCollection datosOrigen = categoria.DatosDataGridView;

            dataGridView2.Rows.Clear();

            foreach (DataGridViewRow filaOrigen in datosOrigen)
            {
                DataGridViewRow nuevaFila = (DataGridViewRow)filaOrigen.Clone();
                for (int i = 0; i < filaOrigen.Cells.Count; i++)
                {
                    nuevaFila.Cells[i].Value = filaOrigen.Cells[i].Value;
                }
                dataGridView2.Rows.Add(nuevaFila);
            }

            //labelNroTotal.Text = categoriada
        }


    }
}
