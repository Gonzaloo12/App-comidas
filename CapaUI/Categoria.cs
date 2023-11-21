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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaUI
{
    public partial class Categoria : Form
    {
        private Label[] labelsPlatos;
        private PictureBox[] pictureImagenes;
        private Carrito nuevoCarrito;
        private pantallaCarrito formCarrito;


        public Categoria()
        {
            InitializeComponent();
            labelsPlatos = new Label[] { plato1, plato2, plato3, plato4, plato5, plato6 };
            pictureImagenes = new PictureBox[] { imagen1, imagen2, imagen3, imagen4, imagen5, imagen6 };
            formCarrito = new pantallaCarrito();


            Font btnSeleccionado = new Font(btnBurger.Font, FontStyle.Bold | FontStyle.Underline);
            btnBurger.Font = btnSeleccionado;

            Font btnDeseleccionado = new Font(btnBebida.Font, FontStyle.Regular | FontStyle.Regular);
            btnBebida.Font = btnDeseleccionado;

            Font btnDeseleccionado1 = new Font(btnPostre.Font, FontStyle.Regular | FontStyle.Regular);
            btnPostre.Font = btnDeseleccionado1;

            var burger = new Burger("burger", "precio");
            var burgerImagen = new Burger("imagen");
            var i = 0;


            this.imagen6.Show();
            this.plato6.Show();
            this.btncarrito6.Show();

            foreach (var burgerNombre in burger.GetProducto())
            {
                labelsPlatos[i].Text = burgerNombre;
                i++;
            }

            i = 0;

            foreach (var imagen in burgerImagen.GetPicture())
            {
                pictureImagenes[i].Image = Image.FromFile(imagen);
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

            var bebida = new Bebida("bebida", "precio");
            var bebidaImagen = new Bebida("imagen");
            var i = 0;

            this.imagen6.Show();
            this.plato6.Show();
            this.btncarrito6.Show();

            foreach (var bebidaNombre in bebida.GetProducto())
            {
                labelsPlatos[i].Text = bebidaNombre;
                i++;
            }

            i = 0;

            foreach (var imagen in bebidaImagen.GetPicture())
            {
                pictureImagenes[i].Image = Image.FromFile(imagen);
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

            var burger = new Burger("burger", "precio");
            var burgerImagen = new Burger("imagen");
            var i = 0;


            this.imagen6.Show();
            this.plato6.Show();
            this.btncarrito6.Show();

            foreach (var burgerNombre in burger.GetProducto())
            {
                labelsPlatos[i].Text = burgerNombre;
                i++;
            }

            i = 0;

            foreach (var imagen in burgerImagen.GetPicture())
            {
                pictureImagenes[i].Image = Image.FromFile(imagen);
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

            Console.WriteLine("funciona");

            var postre = new Postre("postre", "precio");
            var postreImagen = new Postre("imagen");
            var i = 0;

            this.imagen6.Hide();
            this.plato6.Hide();
            this.btncarrito6.Hide();

            foreach (var postreNombre in postre.GetProducto())
            {
                labelsPlatos[i].Text = postreNombre;
                i++;
            }

            i = 0;

            foreach (var imagen in postreImagen.GetPicture())
            {
                pictureImagenes[i].Image = Image.FromFile(imagen);
                i++;
            }
        }



        private void btncarrito1_Click(object sender, EventArgs e)
        {
            var nuevoProducto = plato1.Text;
            nuevoCarrito.AgregarAlCarrito(nuevoProducto);

        }


        private void btn_carrito2_Click(object sender, EventArgs e)
        {
            var nuevoProducto = plato2.Text;
            nuevoCarrito.AgregarAlCarrito(nuevoProducto);
        }

        private void btn_carrito3_Click(object sender, EventArgs e)
        {
            var nuevoProducto = plato3.Text;
            nuevoCarrito.AgregarAlCarrito(nuevoProducto);
        }

        private void btn_carrito4_Click(object sender, EventArgs e)
        {
            var nuevoProducto = plato4.Text;
            nuevoCarrito.AgregarAlCarrito(nuevoProducto);
        }

        private void btn_carrito5_Click(object sender, EventArgs e)
        {
            var nuevoProducto = plato5.Text;
            nuevoCarrito.AgregarAlCarrito(nuevoProducto);
        }

        private void btn_carrito6_Click(object sender, EventArgs e)
        {
            var nuevoProducto = plato6.Text;
            nuevoCarrito.AgregarAlCarrito(nuevoProducto);
        }

        private void ActualizarCarrito()
        {

            if (nuevoCarrito == null)
            {
                nuevoCarrito = new Carrito();
            }

            // Crear una instancia del formulario de Carrito
            //pantallaCarrito nuevoFormulario = new pantallaCarrito();

            // Obtener los productos del carrito
            List<string> productosEnCarrito = nuevoCarrito.GetCarrito();


            // Actualizar el ListBox en el formulario de Carrito
            foreach (var producto in productosEnCarrito)
            {
                formCarrito.listBox1.Items.Add(producto);
            }


            // Mostrar el formulario de Carrito
            if (!formCarrito.Visible)
            {
                formCarrito.Show();

            }
        }
    }


}

