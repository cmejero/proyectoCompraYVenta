using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCompraYVenta.Servicios
{
    internal class Menuimplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            string mensaje = "Bienvenidos a CmejeroVentas";

            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {

            int opcionIntroducida;

            Console.WriteLine("#####################");
            Console.WriteLine("0. Cerrar aplicación");
            Console.WriteLine("1. Comprar productos");
            Console.WriteLine("2. Vender productos");
            Console.WriteLine("#####################");
            Console.WriteLine("Seleccione una opción");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;

        }

    }

    




}

