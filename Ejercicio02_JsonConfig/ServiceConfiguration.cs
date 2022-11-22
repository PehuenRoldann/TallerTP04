namespace Ejercicio02_JsonConfig
{
    public class ServiceConfiguration : ConfigurationBase
    {
        //FIELDS
        private string _baseUrl;
        private string _clientId;
        private string _clientSecret;
        private int _timeOut = 3000;

        //PROPERTYS
        public string BaseUrl { get => _baseUrl; set => _baseUrl = value; }
        public string ClientId { get => _clientId; set => _clientId = value; }
        public string ClientSecret { get => _clientSecret; set => _clientSecret = value; }
        public int TimeOut { get => _timeOut; set => _timeOut = value; }

        //METHODS
        /// <summary>
        /// Valida la configuración actual.
        /// </summary>
        /// <exception cref="ApplicationException">Si BaseUrl, ClientId o ClientSecret son nulos.</exception>
        public override void Validate()
        {
            //BaseUrl, ClientId y ClientSecret no pueden ser nulos:
            if ( (_baseUrl == null) || ( _clientId == null) || (_clientSecret == null) )
            {
                throw new ApplicationException("La configuración posee parámetros nulos.");
            }
        }

         
    }
}