using Microsoft.AspNetCore.Mvc;

namespace WebMail.Controllers
{
    public class MailController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Enviar(string user, string password)
        {
            try
            {
                return Content("1");
            }
            catch (Exception ex) {

                return Content("Error de usuario o contraseña");

            }
        }


    }
}
