using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Meu_Guia.Areas.Painel.Models;
using Meu_Guia.Models;

namespace Meu_Guia.Areas.Painel.Controllers
{
    public class Home_PainelController : Controller
    {
        //
        // GET: /Painel/Home_Painel/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastro(Empresa empresa,Usuario usuario)
        {
            return View("~/Areas/Painel/Views/Home_Painel/_painel_adm.cshtml",usuario);
        }

        public ActionResult Detalhes_Empresa()
        {
            return View();
        }

        public ActionResult Excluir()
        {
            return View();
        }
         [HttpPost]
        public ActionResult Excluir(Empresa empresa)
        {
            return View("~/Areas/Painel/Views/Home_Painel/_painel_adm.cshtml");
        }

        public ActionResult Editar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Editar(Empresa empresa)
        {
            return View("~/Areas/Painel/Views/Home_Painel/_painel_adm.cshtml");
        }
	}
}