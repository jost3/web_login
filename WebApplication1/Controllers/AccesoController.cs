using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;
using WebApplication1.Models;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication1.Controllers
{

    public class AccesoController : Controller
    {
        static string cadena = "Data Source=LAPTOP-T23LMH5E;Initial Catalog=DB_ACCESO;Integrated Security=True";
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(usuario Lusuario)
        {
            bool registrado;
            string mensaje;

            if (Lusuario.Clave == Lusuario.ConfirmarClave)
            {
                Lusuario.Clave = ConvertirSha256(Lusuario.Clave);
            }
            else
            {
                ViewData["Mensaje"] = "LAS CONTRASEÑAS NO EXISTEN";
                return View();
            }

            using (SqlConnection cn = new SqlConnection(cadena))´{

            }
            return View();
        }
        public static string ConvertirSha256(string texto)
        {
            //using System.Text;
            //USAR LA REFERENCIA DE "System.Security.Cryptography"

            StringBuilder Sb = new StringBuilder();
            using (SHA256 hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

    }
}
