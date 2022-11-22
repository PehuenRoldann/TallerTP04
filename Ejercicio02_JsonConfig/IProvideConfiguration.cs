using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_JsonConfig
{
    public interface IProvideConfiguration
    {
        /// <summary>
        /// Provee una configuración del sistema,<br></br> cuya clase sea una subclase de 
        /// "ConfigurationBase"
        /// </summary>
        /// <returns>Instancia de una subclase de ConfigurationBase</returns>
        public T Provide<T>() where T : ConfigurationBase;
    }
}
