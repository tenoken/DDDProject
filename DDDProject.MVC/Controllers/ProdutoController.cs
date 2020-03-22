using AutoMapper;
using DDDProject.Application.Interface;
using DDDProject.Domain.Entities;
using DDDProject.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DDDProject.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoAppService _produtoService;
        private readonly IClienteAppService _clienteService;

        public ProdutoController(IProdutoAppService produtoService, IClienteAppService clienteService)
        {
            _produtoService = produtoService;
            _clienteService = clienteService;
        }
        // GET: Produto
        public ActionResult Index()
        {
            IEnumerable<ProdutoViewModel> produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoService.GetAll());
            return View(produtoViewModel);
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            var produto = _produtoService.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(_clienteService.GetAll(), "ClienteId","Nome");
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(ProdutoViewModel produto)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                    _produtoService.Add(produtoDomain);

                    return RedirectToAction("Index");
                }

                return View(produto);
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = _produtoService.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            ViewBag.ClienteId = new SelectList(_clienteService.GetAll(), "ClienteId", "Nome");

            return View(produtoViewModel);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProdutoViewModel produto)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                    _produtoService.Update(produtoDomain);

                    return RedirectToAction("Index");
                }
                return View(produto);
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoService.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {

            // TODO: Add delete logic here
            var produto = _produtoService.GetById(id);
            _produtoService.Remove(produto);

            return RedirectToAction("Index");
        }
    }
}
