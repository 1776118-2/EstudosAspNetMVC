using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Rodrigo Silva",
                Tipo = "Administrador"
            };

            //Usando ViewData
            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;

            //Usando ViewBag
            //ViewBag.id = pessoa.PessoaId;
            //ViewBag.nome = pessoa.Nome;
            //ViewBag.tipo = pessoa.Tipo;

            //return View();
            return View(pessoa);
        }

        public ActionResult Contatos()
        {
            return View();
        }
        //[HttpPost]
        //uma da maneiras
        //public ActionResult Lista(int PessoaId, string Nome, string Tipo)
        //{
        //    ViewData["PessoaId"] = PessoaId;
        //    ViewData["Nome"] = Nome;
        //    ViewData["Tipo"] = Tipo;

        //    return View();
        //}

            //view tipada
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            return View();
        }
    }
}