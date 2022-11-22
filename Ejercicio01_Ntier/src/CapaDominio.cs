using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_Ntier.src
{
    internal class CapaDominio
    {
        public void Ejecutar()
        {
            CapaPersistencia capaPersistencia = new CapaPersistencia();
            capaPersistencia.Ejecutar();
        }
    }
}
