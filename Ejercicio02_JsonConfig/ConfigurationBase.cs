using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02_JsonConfig
{
    public abstract class ConfigurationBase
    {
        /// <summary>
        /// Comprueba si la configuración es correcta. En caso de no serlo, lanza una excepción.
        /// </summary>
        public abstract void Validate();
    }
}
