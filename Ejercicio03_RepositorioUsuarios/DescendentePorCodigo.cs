using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_RepositorioUsuarios
{
    internal class DescendentePorCodigo : IComparer<Usuario>
    {
        public int Compare(Usuario? x, Usuario? y)
        {
            return y.CompareTo(x);
        }
    }
}
