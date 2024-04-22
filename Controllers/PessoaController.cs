using Microsoft.AspNetCore.Mvc;

namespace WebCadastro.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Cadastrar()
        {
            return View();
        }
    }
}
