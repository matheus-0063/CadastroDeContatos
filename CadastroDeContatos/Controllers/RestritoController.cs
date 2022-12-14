using CadastroDeContatos.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CadastroDeContatos.Controllers
{
    [PaginaParaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
