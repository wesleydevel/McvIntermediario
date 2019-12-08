using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WP.MvcIntermediario.UI.Site.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            ViewBag.AlertaErro = "Ocorreu um erro";
            ViewBag.MensagemErro = "Ocorreu um erro, tente novamente ou contrate um administrador";
            return View("Error");
        }
        public ActionResult NotFound()
        {
            ViewBag.AlertaErro = "Não encontrado";
            ViewBag.MensagemErro = "Não existe pagina para a URL informada";
            return View("Error");
        }
        public ActionResult AccessDenied()
        {
            ViewBag.AlertaErro = "Acesso negado";
            ViewBag.MensagemErro = "Você não tem permissão para executar isso!";
            return View("Error");
        }
    }
}