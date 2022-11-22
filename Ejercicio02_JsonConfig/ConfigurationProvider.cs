using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json; //Librería utilizada en vez de Newtonsoft
//using Newtonsoft.Json; problemas con la librería

namespace Ejercicio02_JsonConfig
{
    public class ConfigurationProvider : IProvideConfiguration
    {
        //FIELDS
        private Dictionary<string, ConfigurationBase> iCache = new Dictionary<string, ConfigurationBase>();

        //METHODS
        /// <summary>
        /// Devuelve una instancia de una subclase de la clase ConfigurationBase, pasando la subclase como parámetro. 
        /// </summary>
        /// <typeparam name="T">Subclase de ConfigurationBase</typeparam>
        /// <returns>Instancia de T</returns>
        /// <exception cref="ApplicationException"></exception>
        public T Provide<T> () where T : ConfigurationBase
        {

            ConfigurationBase configuration;

            try
            {
                //Buscamos la configuración en el caché
                configuration = iCache[typeof(T).ToString()];
                configuration.Validate();
                return (T)configuration;
            }
            catch (KeyNotFoundException)
            {
                try
                {
                    //Buscamos la configuración en directorio
                    configuration = ProvideFromFile<T>();
                    configuration.Validate();
                    //Si la configuración es válida la guardamos en el caché.
                    iCache[typeof(T).ToString()] = configuration;
                    return (T)configuration;

                } catch (Exception error)
                {
                    throw new ApplicationException("Ha ocurrido un error: "+ error.Message);
                }
                
            }
            
        }

        /// <summary>
        /// Devuelve una configuración leyendo un archivo.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pFilePath"></param>
        /// <returns></returns>
        private T ProvideFromFile <T> () where T : ConfigurationBase
        {
            string path = @"D:\programacion\taller-de-programacion\TP04\Ejercicio02_JsonConfig\config\"
                + typeof(T).Name
                + ".json";

            string fileText = File.ReadAllText(path);
            T jsonObject = JsonSerializer.Deserialize<T>(fileText);
            return jsonObject;
        }
    }
}
