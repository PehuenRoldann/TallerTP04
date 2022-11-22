using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03_RepositorioUsuarios
{
    internal class RepositorioUsuariosImp : IRepositorioUsuarios
    {
        //FIELDS
        Dictionary<string, Usuario> iRepositorio = new Dictionary<string, Usuario>();

        //METHODS
        public void Actualizar(Usuario pUsuario)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Usuario pUsuario)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(string pCodgo)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            throw new NotImplementedException();
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
