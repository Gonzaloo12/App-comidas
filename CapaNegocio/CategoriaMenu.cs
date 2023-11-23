using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using static iTextSharp.text.pdf.AcroFields;

namespace CapaNegocio
{
    //CAMBIO DE CATEGORÍAS
    public abstract class Comida
    {
        protected string nombre;
        protected double precio;
        protected string imagen;
        public Comida(string nombre, double precio, string imagen)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.imagen = imagen;   

        }
        public abstract string GetProducto();
        public abstract string GetPicture();
        public abstract double GetPrecio();

    }

    public class Bebida : Comida
    {
        public Bebida(string n, double precio, string imagen) : base(n, precio, imagen)
        {

        }

        public override string GetProducto()
        {
            return nombre;
        }

        public override double GetPrecio()
        {
            return precio;
        }

        public override string GetPicture()
        {
            return imagen;
        }

       
    }

    public class Burger : Comida
    {
        public Burger(string n, double precio, string imagen) : base(n, precio, imagen)
        {

        }

        public override string GetProducto()
        {
            return nombre;
        }

        public override double GetPrecio()
        {
            return precio;
        }

        public override string GetPicture()
        {
            return imagen;
        }
    
    }

    public class Postre : Comida
    {
        public Postre(string n, double precio, string imagen) : base(n, precio, imagen)
        {

        }

        public override string GetProducto()
        {
            return nombre;
        }

        public override double GetPrecio()
        {
            return precio;
        }

        public override string GetPicture()
        {
            return imagen;
        }

    }

    public class MenuComida
    {
        protected List<Bebida> ListaBebidas = new List<Bebida>();
        protected List<Burger> ListaBurger = new List<Burger>();
        protected List<Postre> ListaPostre = new List<Postre>();

        public List<Bebida> GetListaBebida()
        {
            return ListaBebidas;
        }

        public List<Burger> GetListaBurger()
        {
            return ListaBurger;
        }

        public List<Postre> GetListaPostre()
        {
            return ListaPostre;
        }
        public MenuComida()
        {

            //LISTA BEBIDA/////////////////////

            var coca = new Bebida("Cocal cola 500ml", 1200, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\bebidas\\cocacola.jpg");

            ListaBebidas.Add(coca);

            var fanta = new Bebida("Fanta 500ml", 1200, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\bebidas\\fanta.png");
            ListaBebidas.Add(fanta);

            var toros = new Bebida("Paso de los Toros 500ml", 1200, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\bebidas\\paso de los toros.jpg");
            ListaBebidas.Add(toros);


            var sprite = new Bebida("Sprite 500ml", 1200, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\bebidas\\sprite.jpeg");
            ListaBebidas.Add(sprite);


            var agua = new Bebida("Agua 500ml", 1000, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\bebidas\\agua.jpg");
            ListaBebidas.Add(agua);

            var cerveza = new Bebida("Brahma 473ml", 1500, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\bebidas\\brahma.jpg");
            ListaBebidas.Add(cerveza);


            //LISTA BURGER//////////////////

            var opcion1 = new Burger("Hamburguesa simple con queso", 3300, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\hamburguesas\\sabrosa-hamburguesa-aislada-sobre-fondo-blanco-comida-rapida-hamburguesa-fresca-carne-queso.jpg");
            ListaBurger.Add(opcion1);

            var opcion2 = new Burger("Hamburguesa lechuga y tomate", 3500, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\hamburguesas\\sabrosa-hamburguesa-aislada-sobre-fondo-blanco-comida-rapida-hamburguesa-fresca-carne-queso.jpg");
            ListaBurger.Add(opcion2);

            var opcion3 = new Burger("Hamburguesa doble carne panceta y queso", 4000, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\hamburguesas\\sabrosa-hamburguesa-aislada-sobre-fondo-blanco-comida-rapida-hamburguesa-fresca-carne-queso.jpg");
            ListaBurger.Add(opcion3);

            var opcion4 = new Burger("Hamburguesa doble carne jamon, queso y huevo", 4300, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\hamburguesas\\sabrosa-hamburguesa-aislada-sobre-fondo-blanco-comida-rapida-hamburguesa-fresca-carne-queso.jpg");
            ListaBurger.Add(opcion4);

            var opcion5 = new Burger("Hamburguesa vegana NotCarne", 3500, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\hamburguesas\\sabrosa-hamburguesa-aislada-sobre-fondo-blanco-comida-rapida-hamburguesa-fresca-carne-queso.jpg");
            ListaBurger.Add(opcion5);

            var opcion6 = new Burger("Hamburguesa vegana doble NotCarne", 4000, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\hamburguesas\\sabrosa-hamburguesa-aislada-sobre-fondo-blanco-comida-rapida-hamburguesa-fresca-carne-queso.jpg");
            ListaBurger.Add(opcion6);


            //LISTA POSTRE//////////////////

            var postre1 = new Postre("Cono de DDL", 500, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\postre\\ddl.jpg");
            ListaPostre.Add(postre1);

            var postre2 = new Postre("Cono de limon", 500, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\postre\\limon.jpg");
            ListaPostre.Add(postre2);

            var postre3 = new Postre("Cono de chocolate", 500, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\postre\\chocolate.jpg");
            ListaPostre.Add(postre3);

            var postre4 = new Postre("Cono de frutilla", 500, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\postre\\frutilla.jpg");
            ListaPostre.Add(postre4);

            var postre5 = new Postre("Alfajor vegano", 500, "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\postre\\alfajorvegano.jpg");
            ListaPostre.Add(postre5);
            
        }

    }

    public class itemCarrito
    {
        decimal total;
        decimal cantidad;
        decimal precio;
        string detalle;

        public itemCarrito(decimal cantidad, decimal precio, string detalle)
        {

            this.cantidad = cantidad;
            this.precio = precio;
            this.detalle = detalle;
            
        }

        public decimal getCantidad()
        {
            return cantidad;
        }
        public decimal getPrecio()
        {
            return precio;
        }

        public string getDetalle()
        {
            return detalle;
        }
        public decimal getTotal()
        {
            total = 0;
            total = (precio * cantidad);
            return total;
        }
    }
    public class Carrito
    {
        decimal totalCarrito;
        int nroOrden;
        List<itemCarrito> ListaPedido;
        List<decimal> cantxProd;
        
        public Carrito()
        {
            ListaPedido = new List<itemCarrito> ();
            cantxProd = new List<decimal> ();
            nroOrden = 0;
        }

        public List<itemCarrito> getDetalleLista()
        {
            return ListaPedido;
        }

        public List<decimal> getCantxProd()
        {
            return cantxProd;
        }

        public void setCantxProd()
        {
            cantxProd.Clear();
        }
        public void setDetalleLista()
        {
            ListaPedido.Clear ();
        }
        public void agregarAlCarrito(itemCarrito pedido)
        {
            int posicion = -1;

            for (int i=0; i< ListaPedido .Count; i++)
            {
                if (ListaPedido[i].getDetalle() == pedido.getDetalle())
                {
                    posicion = i;
                    break;
                }
            }
            if(posicion != -1)
            {
                 cantxProd[posicion]+=pedido.getCantidad();

            }
            else
            {
                ListaPedido.Add(pedido);
                cantxProd.Add(pedido.getCantidad());

            }

         

        }

       
        public decimal getTotalCarrito()
        {
            totalCarrito = 0;

            for(int i=0;i< ListaPedido.Count; i++)
            {
                totalCarrito += ListaPedido[i].getPrecio() * cantxProd[i];
            }
            foreach (var item in ListaPedido)
            {
                
            }

            return totalCarrito;
        }


        public decimal borrarTodo()
        {
            ListaPedido.Clear();
            return totalCarrito = 0;
            
        }

        public void setFactura()
        {
            for (int i=0; i< ListaPedido.Count; i++)
            {
                var producto= ListaPedido[i].getDetalle();
                var pu = ListaPedido[i].getPrecio();
                var totalProducto = ListaPedido[i].getPrecio() * cantxProd[i];
                
            }
        }

    }

    ///GENERACIÓN DE FACTURA/

    public class Ticket
    {
        public void CrearPdf()
        {
            //string filePath = "D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR";  

            //Document doc = new Document();
            //PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            //doc.Open();

            //doc.Add(new Paragraph((float)fecha.ToOADate()));
            //doc.Add(new Paragraph(cliente));
            //doc.Add(new Paragraph(formaPago));
            //doc.Add(new Paragraph(nroOrden));
            
        }
    }

    //VALIDACION DE USUARIO
    public class Usuario
    {
        string usuario;
        string contrasenia;
        int bandera;

        public Usuario()
        {
            usuario = "UsuarioTp";
            contrasenia = "ContraseniaTp";
            bandera = 0;
        }

        public int getBandera()
        {
            return bandera;
        }
        public bool ValidarUsuario(string usuario, string contrasenia)
        {
            if (usuario == this.usuario && contrasenia == this.contrasenia)
            {
                bandera = 1;
                return true;
            }
            else
            {
                return false;

            }
        }

        public string getUsuario()
        {
            return usuario;
        }
    }

    

    
}
