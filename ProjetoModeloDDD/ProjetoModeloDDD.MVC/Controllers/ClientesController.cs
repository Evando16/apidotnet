using System.Web.Mvc;
using AutoMapper;
using ProjetoModeloDDD.MVC.ViewModels;
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Application.Interface;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteAppService clienteAppService;

        public ClientesController(IClienteAppService clienteAppService)
        {
            this.clienteAppService = clienteAppService;
        }

        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(this.clienteAppService.GetAll());
            return View(clienteViewModel);
        }

        public ActionResult Especiais()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(clienteAppService.ObterClientesEspeciais());
            return View(clienteViewModel);
        }

        public ActionResult Details(int id)
        {
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(clienteAppService.GetById(id));

            return View(clienteViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                clienteAppService.Add(clienteDomain);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public ActionResult Edit(int id)
        {

            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(clienteAppService.GetById(id));

            return View(clienteViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                this.clienteAppService.Update(clienteDomain);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public ActionResult Delete(int id)
        {
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(clienteAppService.GetById(id));

            return View(clienteViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = this.clienteAppService.GetById(id);
            this.clienteAppService.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}