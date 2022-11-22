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
            iRepositorio[pUsuario.Codigo] = pUsuario;
        }

        public void Agregar(Usuario pUsuario)
        {
            iRepositorio.Add(pUsuario.Codigo, pUsuario);
        }


        public void Eliminar(string pCodigo)
        {
            iRepositorio.Remove(pCodigo);
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> lista = iRepositorio.Values.ToList();
            //Ordenamos usando la implementaíón de IComparer pasada como parámetro.
            lista.Sort(pComparador);
            return lista;
            
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            return iRepositorio[pCodigo];
        }

        public IList<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = iRepositorio.Values.ToList();
            lista.Sort();//Ordenamos por código, por defecto.
            return lista;
        }
    }
}
