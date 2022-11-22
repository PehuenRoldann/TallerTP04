using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_Ntier.src
{
    public class ErrorPuntualException : ApplicationException
    {
        public ErrorPuntualException(string mensaje) : base (mensaje+"; Tiempo del error: "+DateTime.Now.ToString()) { }
    }
}
