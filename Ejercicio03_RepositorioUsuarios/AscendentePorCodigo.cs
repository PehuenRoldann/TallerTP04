using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_RepositorioUsuarios
{
    internal class AscendentePorCodigo : IComparer<Usuario>
    {
        public int Compare(Usuario? x, Usuario? y)
        {
            return x.CompareTo(y);
        }
    }
}
