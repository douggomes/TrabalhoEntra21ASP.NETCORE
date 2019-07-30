using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaGerProjetos.Database;
using SistemaGerProjetos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace SistemaGerProjetos.Controllers
{
    [Authorize]
    public class ProjetoController : Controller
    {
        private DatabaseContext _db;

        public ProjetoController(DatabaseContext db)
        {
            _db = db;
        }
        //Listar todas as palavras do banco de dados
        public IActionResult Index(int? page)
        {

            var pageNumber = page ?? 1;

            var projetos = _db.Projetos.ToList();
            var resultadoPaginado = projetos.ToPagedList(pageNumber, 5);

            return View(resultadoPaginado);


        }

        //CRUD - CREATE, READ, UPDATE e DELETE
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Cadastrar()
        {
            var clienteDb = _db.Clientes.ToList();
            ViewBag.Cliente = clienteDb;

            return View(new Projeto());
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Cadastrar([FromForm]Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                _db.Projetos.Add(projeto);
                _db.SaveChanges();

                TempData["Mensagem"] = "O projeto '" + projeto.NomeProjeto + "' foi cadastrado com sucesso!";
                return RedirectToAction("Index");
            }
            return View(projeto);
        }
        //-------------------------------------------------------------
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Projeto projeto = _db.Projetos.Find(Id);
            var atualizarPeloId = _db.Projetos.Select(x => new { x.Id, x.NomeClienteProjeto }).Where(y => y.Id == Id).ToList();
            ViewBag.AtualizarClienteProjeto = atualizarPeloId;

            var clienteDb = _db.Clientes.ToList();
            ViewBag.Cliente = clienteDb;

            return View("Cadastrar", projeto);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Atualizar([FromForm]Projeto projeto)
        {
            var clienteDb = _db.Clientes.ToList();
            ViewBag.Cliente = clienteDb;

            if (ModelState.IsValid)
            {
                _db.Projetos.Update(projeto);
                _db.SaveChanges();

                TempData["Mensagem"] = "O projeto '" + projeto.NomeProjeto + "' foi alterado com sucesso!";
                return RedirectToAction("Index");
            }
            return View("Cadastrar", projeto);
        }
        //--------------------------------------------------------------

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            Projeto projeto = _db.Projetos.Find(Id);
            _db.Projetos.Remove(projeto);
            _db.SaveChanges();

            TempData["Mensagem"] = "O projeto '" + projeto.NomeProjeto + "' foi removido com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
