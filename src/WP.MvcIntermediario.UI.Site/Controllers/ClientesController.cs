using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WP.MvcIntermediario.Application.Interfaces;
using WP.MvcIntermediario.Application.Services;
using WP.MvcIntermediario.Application.ViewModels;
using WP.MvcIntermediario.UI.Site.Models;

namespace WP.MvcIntermediario.UI.Site.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService _clienteAppService;
        public ClientesController()
        {
            _clienteAppService = new ClienteAppService();
        }
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View(_clienteAppService.ObterAtivos());
        }

        public ActionResult Details(Guid id)
        {
            var cliente = _clienteAppService.ObterPorId(id);

            if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            if (ModelState.IsValid)
            {
                _clienteAppService.Adicionar(clienteEnderecoViewModel);
                return RedirectToAction("Index");
            }

            return View(clienteEnderecoViewModel);
        }

        public ActionResult Edit(Guid id)
        {
            var cliente = _clienteAppService.ObterPorId(id);

            if (cliente == null)
                return HttpNotFound();

            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                _clienteAppService.Atualizar(clienteViewModel);
            }
            return View(clienteViewModel);
        }

        public ActionResult Delete(Guid id)
        {

            var clienteViewModel = _clienteAppService.ObterPorId(id);
            if (clienteViewModel == null)
            {
                return HttpNotFound();
            }
            return View(clienteViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _clienteAppService.Remover(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _clienteAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
