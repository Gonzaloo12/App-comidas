using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_FINAL;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace CapaUI
{
    public partial class Categoria : Form
    {
        private Label[] labelsPlatos, labelsPrecios;
        private PictureBox[] pictureImagenes;
        private Carrito nuevaListaPedido;
        private Ticket nuevoTicket;             
        
        public string MedioPago;

        public string getMedioPago()
        {
            return MedioPago;
        }
        
        public void setMedioPago()
        {
            if(listaMedios.SelectedItem!= null)
            {
                MedioPago = listaMedios.SelectedItem.ToString();
            }
          
        }
  
        
        
        public string ImporteTotal
        {
            get;set;
        }


        public DataGridViewRowCollection DatosDataGridView
        {
            get { return dataGridView2.Rows; }
        }

        public Categoria()
        {
            InitializeComponent();

            labelsPlatos = new Label[] { plato1, plato2, plato3, plato4, plato5, plato6 };
            labelsPrecios = new Label[] { precio1, precio2, precio3, precio4, precio5, precio6 };
            pictureImagenes = new PictureBox[] { imagen1, imagen2, imagen3, imagen4, imagen5, imagen6 };
            nuevaListaPedido = new Carrito();


            Font btnSeleccionado = new Font(btnBurger.Font, FontStyle.Bold | FontStyle.Underline);
            btnBurger.Font = btnSeleccionado;

            Font btnDeseleccionado = new Font(btnBebida.Font, FontStyle.Regular | FontStyle.Regular);
            btnBebida.Font = btnDeseleccionado;

            Font btnDeseleccionado1 = new Font(btnPostre.Font, FontStyle.Regular | FontStyle.Regular);
            btnPostre.Font = btnDeseleccionado1;

            var burger = new MenuComida();

            var i = 0;


            this.imagen6.Show();
            this.plato6.Show();
            this.checkBox6.Show();
            this.cantidad6.Show();
            this.precio6.Show();

            foreach (var burgerNombre in burger.GetListaBurger())
            {

                labelsPlatos[i].Text = burgerNombre.GetProducto();
                labelsPrecios[i].Text = (burgerNombre.GetPrecio()).ToString();
                pictureImagenes[i].Image = System.Drawing.Image.FromFile(burgerNombre.GetPicture());
                i++;

            }

        }

        //CLIC BEBIDA
        private void bebidas_Click(object sender, EventArgs e)
        {
            Font btnSeleccionado = new Font(btnBebida.Font, FontStyle.Bold | FontStyle.Underline);
            btnBebida.Font = btnSeleccionado;

            Font btnDeseleccionado = new Font(btnBurger.Font, FontStyle.Regular | FontStyle.Regular);
            btnBurger.Font = btnDeseleccionado;

            Font btnDeseleccionado1 = new Font(btnPostre.Font, FontStyle.Regular | FontStyle.Regular);
            btnPostre.Font = btnDeseleccionado1;

            var bebida = new MenuComida();

            var i = 0;

            this.imagen6.Show();
            this.plato6.Show();
            this.checkBox6.Show();
            this.cantidad6.Show();
            this.precio6.Show();

            foreach (var bebidaNombre in bebida.GetListaBebida())
            {
                labelsPlatos[i].Text = bebidaNombre.GetProducto();
                labelsPrecios[i].Text = (bebidaNombre.GetPrecio()).ToString();
                pictureImagenes[i].Image = System.Drawing.Image.FromFile(bebidaNombre.GetPicture());
                i++;
            }

        }

        //CLIC BURGER

        private void burger_Click(object sender, EventArgs e)
        {
            Font btnSeleccionado = new Font(btnBurger.Font, FontStyle.Bold | FontStyle.Underline);
            btnBurger.Font = btnSeleccionado;

            Font btnDeseleccionado = new Font(btnBebida.Font, FontStyle.Regular | FontStyle.Regular);
            btnBebida.Font = btnDeseleccionado;

            Font btnDeseleccionado1 = new Font(btnPostre.Font, FontStyle.Regular | FontStyle.Regular);
            btnPostre.Font = btnDeseleccionado1;

            var burger = new MenuComida();

            var i = 0;


            this.imagen6.Show();
            this.plato6.Show();
            this.checkBox6.Show();
            this.cantidad6.Show();
            this.precio6.Show();

            foreach (var burgerNombre in burger.GetListaBurger())
            {
                labelsPlatos[i].Text = burgerNombre.GetProducto();
                labelsPrecios[i].Text = (burgerNombre.GetPrecio()).ToString();
                pictureImagenes[i].Image = System.Drawing.Image.FromFile(burgerNombre.GetPicture());
                i++;

            }
        }

        //CLIC POSTRE
        private void postre_Click(object sender, EventArgs e)
        {
            Font btnSeleccionado = new Font(btnPostre.Font, FontStyle.Bold | FontStyle.Underline);
            btnPostre.Font = btnSeleccionado;

            Font btnDeseleccionado = new Font(btnBurger.Font, FontStyle.Regular | FontStyle.Regular);
            btnBurger.Font = btnDeseleccionado;

            Font btnDeseleccionado1 = new Font(btnBebida.Font, FontStyle.Regular | FontStyle.Regular);
            btnBebida.Font = btnDeseleccionado1;

            var postre = new MenuComida();

            var i = 0;

            this.imagen6.Hide();
            this.plato6.Hide();
            this.checkBox6.Hide();
            this.cantidad6.Hide();
            this.precio6.Hide();
            this.label8.Hide();

            foreach (var postreNombre in postre.GetListaPostre())
            {
                labelsPlatos[i].Text = postreNombre.GetProducto();
                labelsPrecios[i].Text = (postreNombre.GetPrecio()).ToString();
                pictureImagenes[i].Image = System.Drawing.Image.FromFile(postreNombre.GetPicture());
                i++;

            }
        }

        ///CARRITO//

        public void ActualizarDataGridView()
        {
            dataGridView2.Rows.Clear();

            for (int i = 0; i < nuevaListaPedido.getDetalleLista().Count; i++)
            {
                dataGridView2.Rows.Add(nuevaListaPedido.getCantxProd()[i], nuevaListaPedido.getDetalleLista()[i].getDetalle(), nuevaListaPedido.getDetalleLista()[i].getPrecio(), nuevaListaPedido.getDetalleLista()[i].getPrecio() * nuevaListaPedido.getCantxProd()[i]);
            }

        }
        public void actualizarCarrito()
        {
            var total = nuevaListaPedido.getTotalCarrito();
            totalnumero.Text = total.ToString();
            ImporteTotal = totalnumero.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            itemCarrito nuevoItem = new itemCarrito(cantidad1.Value, decimal.Parse(precio1.Text), plato1.Text);
            nuevaListaPedido.agregarAlCarrito(nuevoItem);
            ActualizarDataGridView();
            actualizarCarrito();

        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            itemCarrito nuevoItem = new itemCarrito(cantidad2.Value, decimal.Parse(precio2.Text), plato2.Text);
            nuevaListaPedido.agregarAlCarrito(nuevoItem);
            ActualizarDataGridView();
            actualizarCarrito();

        }



        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            itemCarrito nuevoItem = new itemCarrito(cantidad3.Value, decimal.Parse(precio3.Text), plato3.Text);
            nuevaListaPedido.agregarAlCarrito(nuevoItem);
            ActualizarDataGridView();
            actualizarCarrito();

        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            itemCarrito nuevoItem = new itemCarrito(cantidad4.Value, decimal.Parse(precio4.Text), plato4.Text);
            nuevaListaPedido.agregarAlCarrito(nuevoItem);
            ActualizarDataGridView();
            actualizarCarrito();

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            itemCarrito nuevoItem = new itemCarrito(cantidad5.Value, decimal.Parse(precio5.Text), plato5.Text);
            nuevaListaPedido.agregarAlCarrito(nuevoItem);
            ActualizarDataGridView();
            actualizarCarrito();

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (cantidad1.Value > 0)
            {
                itemCarrito nuevoItem = new itemCarrito(cantidad6.Value, decimal.Parse(precio6.Text), plato6.Text);
                nuevaListaPedido.agregarAlCarrito(nuevoItem);
                ActualizarDataGridView();
                actualizarCarrito();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            DialogResult limpiar;
            limpiar = MessageBox.Show("¿Está seguro que quiere eliminar todo?", "Sistema de Restauratedecomidasrapiddas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (limpiar == DialogResult.Yes)
            {
                totalnumero.Text = nuevaListaPedido.borrarTodo().ToString();
                nuevaListaPedido.setDetalleLista();
                nuevaListaPedido.setCantxProd();
                dataGridView2.Rows.Clear();

            }

        }

        //set medio pago

        private void hacerPedido_Click(object sender, EventArgs e)
        {
            DialogResult hacerPedido;
            setMedioPago();

                if (dataGridView2.RowCount == 1)
                {
                    MessageBox.Show("Todavía no agregaste ningún producto al carrito", "Mi carrito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (listaMedios.SelectedIndex == -1)
                    {
                        MessageBox.Show("Por favor, seleccione una forma de pago", "Forma de pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        setMedioPago();
                    }
                    else
                    {
                        hacerPedido = MessageBox.Show("¿Está seguro que quiere hacer el pedido?", "Sistema de Restauratedecomidasrapiddas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (hacerPedido == DialogResult.Yes)
                        {
                            var nuevoTicket = new FormTicket(this);

                            nuevoTicket.Show();

                        }
                    }


                }
            
           
            
           

        }

    }
}
