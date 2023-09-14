using Microsoft.AspNetCore.Mvc;
using login_c_.Models;
using System.Text;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace login_c_.Controllers;

public class AccesoController1 : Controller
{
    static string cadena = "Data Source=DESKTOP-7LDGQBD;Initial Catalog=DB_ACCESO;Integrated Security=True";
    //get accesp
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Registrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Registrar(usuario Ousuario)
    {
        bool registrado;
        string mensaje;

        if(Ousuario.Clave == Ousuario.ConfirmarClave)
        {
            Ousuario.Clave = ConvertirSha256(Ousuario.Clave);
        }
        else
        {
            ViewData["Mensaje"] = "LAS CONTRASEÑAS NO EXISTEN";
            return View();
        }

        using (SqlConnection cn = new SqlConnection(cadena)) 
        {
         
        }


            return View();
    }
    public static string ConvertirSha256(string texto)
    {
        //using System.Text;
        //USAR LA REFERENCIA DE "System.Security.Cryptography"

        StringBuilder Sb = new StringBuilder();
        using (SHA256 hash = SHA256Managed.Create())
        {
            Encoding enc = Encoding.UTF8;
            byte[] result = hash.ComputeHash(enc.GetBytes(texto));

            foreach (byte b in result)
                Sb.Append(b.ToString("x2"));
        }

        return Sb.ToString();
    }

}
