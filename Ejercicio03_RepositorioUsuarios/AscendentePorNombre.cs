using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_RepositorioUsuarios
{
    internal class AscendentePorNombre : IComparer<Usuario>
    {
        public int Compare(Usuario? x, Usuario? y)
        {
            return x.NombreCompleto.CompareTo(y.NombreCompleto);
        }
    }
}
