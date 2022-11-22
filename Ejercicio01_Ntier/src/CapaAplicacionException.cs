using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_Ntier.src
{
    public class CapaAplicacionException : ApplicationException
    {
        public CapaAplicacionException(string pMensaje) : base (pMensaje) {}
    }
}
