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
        
        public Menu(string nombre, string precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
        public abstract List<string> GetBebidas();
    }

    public class Bebida : Menu
    {

        private List<string> listaBebidas;

        public Bebida(string n, string precio) : base(n, precio)
        {



        }
        public override List<string> GetBebidas()
        {
            listaBebidas = new List<string>();


            var coca = new Bebida("Cocal cola 500ml", "$1200");
            listaBebidas.Add(coca.nombre + " " + coca.precio);

            var fanta = new Bebida("Fanta 500ml", "$1200");
            listaBebidas.Add(fanta.nombre + " " + fanta.precio);

            var toros = new Bebida("Paso de los Toros 500ml", "$1200");
            listaBebidas.Add(toros.nombre + " " + toros.precio);

            var sprite = new Bebida("Sprite 500ml", "$1200");
            listaBebidas.Add(sprite.nombre + " " + sprite.precio);

            var agua = new Bebida("Agua 500ml", "$1200");
            listaBebidas.Add(agua.nombre + " " + agua.precio);

            var cerveza = new Bebida("Brahma 473ml", "$1200");
            listaBebidas.Add(cerveza.nombre + " " + cerveza.precio);
            return listaBebidas;
        }
    }

    public class Burger : Menu
    {

        private List<string> listaBebidas;

        public Burger(string n, string precio) : base(n, precio)
        {



        }
        public override List<string> GetBebidas()
        {
            listaBebidas = new List<string>();


            var opcion1 = new Burger("Hamburguesa simple con queso", "3300");
            listaBebidas.Add(opcion1.nombre + " " + opcion1.precio);

            var opcion2 = new Burger("Hamburguesa lechuga y toma", "$3500");
            listaBebidas.Add(opcion2.nombre + " " + opcion2.precio);

            var opcion3 = new Burger("Hamburguesa doble carne panceta y queso", "$4000");
            listaBebidas.Add(opcion3.nombre + " " + opcion3.precio);

            var opcion4 = new Burger("Hamburguesa doble carne jamon, queso y huevo", "$4300");
            listaBebidas.Add(opcion4.nombre + " " + opcion4.precio);

            var opcion5 = new Burger("Hamburguesa vegana NotCarne", "$3500");
            listaBebidas.Add(opcion5.nombre + " " + opcion5.precio);

            var opcion6 = new Burger("Hamburguesa vegana doble NotCarne", "$4000");
            listaBebidas.Add(opcion6.nombre + " " + opcion6.precio);
            return listaBebidas;
        }
    }
}
