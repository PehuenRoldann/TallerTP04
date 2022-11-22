using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_Ntier.src
{
    internal class CapaAplicacion
    {
        public void Ejecutar()
        {
            CapaDominio capaDominio = new CapaDominio();

            try
            {
                capaDominio.Ejecutar();
            } catch (ErrorPuntualException error)
            {
                throw new CapaAplicacionException("Error de aplicación;" + error.Message);
            }
        }
    }
}
