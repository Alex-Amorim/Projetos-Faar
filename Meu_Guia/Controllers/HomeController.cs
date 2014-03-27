using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meu_Guia.Models;

namespace Meu_Guia.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Pesquisa pesquisa)
        {
            return View("ResultadoPesquisa",pesquisa);
        }
        public ActionResult cadastro ()
        {
            return View();
        }
        public ActionResult DetalhesEmpresa()
        {
            return View();
        }
        public ActionResult ResultadoPesquisa()
        {
            return View();
        }

        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            if (usuario.User.Equals("Amorim") && usuario.Senha.Equals("12345"))
            {
                return View("~/Areas/Painel/Views/Home_Painel/_painel_adm.cshtml", usuario);
            }
            return View();
        }
	}
}