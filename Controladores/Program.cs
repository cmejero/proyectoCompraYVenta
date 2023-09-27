using proyectoCompraYVenta.Servicios;

namespace proyectoCompraYVenta.Controladores
{
   /// <summary>
   /// Clase principal de la aplicación
   /// 270923 - cmr
   /// </summary>
    internal class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// 270923 - cmr
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new Menuimplementacion();
            mi.mostrarMensajeBienvenida();

            // variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;
            //contener la opción del usuario
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0");
                        cerrarMenu = true;  
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Se ejecuta caso 1");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Se ejecuta caso 2");
                        break;
                    default:
                        Console.WriteLine("[INFO] - Esta opción no coincide con ninguna");
                        break;
                }
            }
        }
    }
}