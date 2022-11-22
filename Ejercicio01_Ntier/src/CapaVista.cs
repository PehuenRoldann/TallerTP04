using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01_Ntier.src
{
    public class CapaVista
    {
        static public void Main(string[] args)
        {
            CapaControlador capaControlador = new CapaControlador();

            try
            {
                capaControlador.Ejecutar();

            }catch(CapaAplicacionException error)
            {
                Console.WriteLine(error.Message);
                Console.ReadKey();
            }
        }
    }
}
