using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public abstract class Menu
    {
        protected string nombre;
        protected string precio;
        protected string imagen;
        public Menu(string nombre, string precio)
        {
            this.nombre = nombre;
            this.precio = precio;

        }

        public Menu( string imagen)
        {
            this.imagen = imagen;
        }


        public abstract List<string> GetProducto();
        public abstract List<string> GetPicture();

    }

    public class Bebida : Menu
    {

        private List<string> listaBebidas;
        private List<string> listaImagenes;

        public Bebida(string n, string precio) : base(n, precio)
        {



        }
        public Bebida(string imagen) : base(imagen)
        {



        }

        public override List<string> GetProducto()
        {
            listaBebidas = new List<string>();

            var coca = new Bebida("Cocal cola 500ml", "$1200");
            listaBebidas.Add(coca.nombre);

            var fanta = new Bebida("Fanta 500ml", "$1200");
            listaBebidas.Add(fanta.nombre);

            var toros = new Bebida("Paso de los Toros 500ml", "$1200");
            listaBebidas.Add(toros.nombre);


            var sprite = new Bebida("Sprite 500ml", "$1200");
            listaBebidas.Add(sprite.nombre);


            var agua = new Bebida("Agua 500ml", "$1000");
            listaBebidas.Add(agua.nombre);

            var cerveza = new Bebida("Brahma 473ml", "$1500");
            listaBebidas.Add(cerveza.nombre);            


            return listaBebidas;
        }

        public override List<string> GetPicture()
        {
            listaImagenes = new List<string>();

            var coca = new Bebida("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\bebidas\\cocacola.jpg");
            listaImagenes.Add(coca.imagen);

            var fanta = new Bebida("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\bebidas\\fanta.png");
            listaImagenes.Add(fanta.imagen);

            var toros = new Bebida("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\bebidas\\paso de los toros.jpg");
            listaImagenes.Add(toros.imagen);

            var sprite = new Bebida("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\bebidas\\sprite.jpeg");

            listaImagenes.Add(sprite.imagen);

            var agua = new Bebida("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\bebidas\\agua.jpg");

            listaImagenes.Add(agua.imagen);

            var cerveza = new Bebida("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\bebidas\\brahma.jpg");
            listaImagenes.Add(cerveza.imagen);

            return listaImagenes;
        }
    }

    public class Burger : Menu
    {

        private List<string> listaBurger;
        private List<string> listaImagenes;

        public Burger(string n, string precio) : base(n, precio)
        {

        }

        public Burger(string imagen) : base(imagen)
        {

        }
        public override List<string> GetProducto()
        {
            listaBurger = new List<string>();


            var opcion1 = new Burger("Hamburguesa simple con queso", "$3300");
            listaBurger.Add(opcion1.nombre + " " + opcion1.precio);

            var opcion2 = new Burger("Hamburguesa lechuga y tomate", "$3500");
            listaBurger.Add(opcion2.nombre + " " + opcion2.precio);

            var opcion3 = new Burger("Hamburguesa doble carne panceta y queso", "$4000");
            listaBurger.Add(opcion3.nombre + " " + opcion3.precio);

            var opcion4 = new Burger("Hamburguesa doble carne jamon, queso y huevo", "$4300");
            listaBurger.Add(opcion4.nombre + " " + opcion4.precio);

            var opcion5 = new Burger("Hamburguesa vegana NotCarne", "$3500");
            listaBurger.Add(opcion5.nombre + " " + opcion5.precio);

            var opcion6 = new Burger("Hamburguesa vegana doble NotCarne", "$4000");
            listaBurger.Add(opcion6.nombre + " " + opcion6.precio);

            return listaBurger;
        }

        public override List<string> GetPicture()
        {
            listaImagenes = new List<string>();

            var opcion1 = new Burger("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\hamburguesas\\sabrosa-hamburguesa-aislada-sobre-fondo-blanco-comida-rapida-hamburguesa-fresca-carne-queso.jpg");
            listaImagenes.Add(opcion1.imagen);

            var opcion2 = new Burger("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\hamburguesas\\sabrosa-hamburguesa-aislada-sobre-fondo-blanco-comida-rapida-hamburguesa-fresca-carne-queso.jpg");
            listaImagenes.Add(opcion2.imagen);

            var opcion3 = new Burger("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\hamburguesas\\sabrosa-hamburguesa-aislada-sobre-fondo-blanco-comida-rapida-hamburguesa-fresca-carne-queso.jpg");
            listaImagenes.Add(opcion3.imagen);

            var opcion4 = new Burger("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\hamburguesas\\sabrosa-hamburguesa-aislada-sobre-fondo-blanco-comida-rapida-hamburguesa-fresca-carne-queso.jpg");

            listaImagenes.Add(opcion4.imagen);

            var opcion5 = new Burger("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\hamburguesas\\sabrosa-hamburguesa-aislada-sobre-fondo-blanco-comida-rapida-hamburguesa-fresca-carne-queso.jpg");

            listaImagenes.Add(opcion5.imagen);

            var opcion6 = new Burger("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\hamburguesas\\sabrosa-hamburguesa-aislada-sobre-fondo-blanco-comida-rapida-hamburguesa-fresca-carne-queso.jpg");
            listaImagenes.Add(opcion6.imagen);

            return listaImagenes;
        }
    }

    public class Postre : Menu
    {

        private List<string> listaPostre;
        private List<string> listaImagenes;

        public Postre(string n, string precio) : base(n, precio)
        {

        }

        public Postre(string imagen) : base(imagen)
        {

        }
        public override List<string> GetProducto()
        {
            listaPostre = new List<string>();


            var opcion1 = new Postre("Cono de DDL", "500");
            listaPostre.Add(opcion1.nombre + " " + opcion1.precio);

            var opcion2 = new Postre("Cono de limon", "$500");
            listaPostre.Add(opcion2.nombre + " " + opcion2.precio);

            var opcion3 = new Postre("Cono de chocolate", "$500");
            listaPostre.Add(opcion3.nombre + " " + opcion3.precio);
                
            var opcion4 = new Postre("Cono de frutilla", "$500");
            listaPostre.Add(opcion4.nombre + " " + opcion4.precio);

            var opcion5 = new Postre("Alfajor vegano", "$500");
            listaPostre.Add(opcion5.nombre + " " + opcion5.precio);
            return listaPostre;
        }

        public override List<string> GetPicture()
        {
            listaImagenes = new List<string>();

            var opcion1 = new Postre("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\postre\\ddl.jpg");
            listaImagenes.Add(opcion1.imagen);

            var opcion2 = new Postre("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\postre\\limon.jpg");
            listaImagenes.Add(opcion2.imagen);

            var opcion3 = new Postre("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\postre\\chocolate.jpg");
            listaImagenes.Add(opcion3.imagen);

            var opcion4 = new Postre("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\postre\\frutilla.jpg");
            listaImagenes.Add(opcion4.imagen);

            var opcion5 = new Postre("D:\\PROGRAMACIÓN\\IFTS11\\SEGUNDO CUATRIMESTRE\\LUN Desarrollo OO\\TP FINAL INTEGRADOR\\TPCAPAS\\CapaNegocio\\postre\\alfajorvegano.jpg");
            listaImagenes.Add(opcion5.imagen);

            return listaImagenes;
        }
    }
  
}
