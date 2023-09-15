namespace WebApplication1.Models
{
    public class usuario
    {
        public int IdUser { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string apellido { get; set; }

        public string ConfirmarClave { get; set; }
    }
}
