using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_RepositorioUsuarios
{
    internal interface IRepositorioUsuarios
    {
        public void Agregar(Usuario pUsuario);
        public void Actualizar(Usuario pUsuario);
        public void Eliminar(String pCodgo);
        public IList<Usuario> ObtenerTodos();
        public Usuario ObtenerPorCodigo(string pCodigo);
        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador);
    }
}
