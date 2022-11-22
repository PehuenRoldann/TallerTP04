using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_Ntier.src
{
    internal class CapaPersistencia
    {
        public void Ejecutar()
        {
            throw new ErrorPuntualException("Error en la capa de persistencia");
        }
    }
}
