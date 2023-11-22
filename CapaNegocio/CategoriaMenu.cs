using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        public itemCarrito(decimal cantidad, decimal precio)
        {

            this.cantidad = cantidad;
            this.precio = precio;

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
        List<itemCarrito> ListaPedido;
        
        public Carrito()
        {
            ListaPedido = new List<itemCarrito> ();
            
        }

        public void agregarAlCarrito(itemCarrito pedido)
        {
            ListaPedido.Add (pedido);
        }

        public decimal getTotalCarrito()
        {
            totalCarrito = 0;

            foreach (var item in ListaPedido)
            {
                totalCarrito += item.getTotal();
            }

            return totalCarrito;
        }

        public decimal borrarTodo()
        {
            ListaPedido.Clear();
            return totalCarrito = 0;
            
        }

    }

    //VALIDACION DE USUARIO
    public class Usuario
    {
        public bool ValidarUsuario(string usuario, string contrasenia)
        {
            if (usuario == "UsuarioTp" && contrasenia == "ContraseñaTp")
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }



    
}
