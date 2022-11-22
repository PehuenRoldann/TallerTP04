namespace Ejercicio03_RepositorioUsuarios
{
    public class Usuario : IComparable
    {
        //FIELDS
        private string iCodigo;//Código de identificación del usuario
        private string iNombreCompleto;//Nombre y apellido
        private string iCorreoElectronico;//Correo electrónico personal del usuario

        //PROPERTYS
        public string Codigo { get => iCodigo; set => iCodigo = value; }
        public string NombreCompleto { get => iNombreCompleto; set => iNombreCompleto = value; }
        public string CorreoElectronico { get => iCorreoElectronico; set => iCorreoElectronico = value; }
        //METHODS
        public int CompareTo(object? obj)
        {
            return Codigo.CompareTo(obj);
        }
    }
}