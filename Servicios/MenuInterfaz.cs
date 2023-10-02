using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCompraYVenta.Servicios
{
    /// <summary>
    /// Interfaz con la relación de métodos de la funcionalidad menú
    /// 021023 - cmr
    /// </summary>
    internal interface MenuInterfaz
    {
       /// <summary>
       /// Método que muestra el menú y recoge la selección del usuario
       /// 021923 - cmr
       /// </summary>
        public void mostrarMensajeBienvenida();
        /// <summary>
        /// Método que muestra el menú y recoge la selección del usuario
        /// 02/1023 - cmr
        /// </summary>
        /// <returns>un entero con la opción seleccionada</returns>
        public int mostrarMenuYSeleccion();
    }
}
