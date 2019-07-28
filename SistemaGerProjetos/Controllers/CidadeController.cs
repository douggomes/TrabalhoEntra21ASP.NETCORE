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
    public class CidadeController : Controller
    {
        List<Estado> estados = new List<Estado>();
        Estado estado = new Estado();
        private DatabaseContext _db;

        public CidadeController(DatabaseContext db)
        {
            _db = db;

            estados.Add(new Estado() {Id = estado.Id, Nome = estado.Nome, Sigla = estado.Sigla });
        }
        //Listar todas as palavras do banco de dados
        public IActionResult Index(int? page)
        {

            var pageNumber = page ?? 1;

            var cidades = _db.Cidades.ToList();
            var resultadoPaginado = cidades.ToPagedList(pageNumber, 5);

            return View(resultadoPaginado);


        }

        //CRUD - CREATE, READ, UPDATE e DELETE
        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Estado = estados;
            return View(new Cidade());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                _db.Cidades.Add(cidade);
                _db.SaveChanges();

                TempData["Mensagem"] = "A cidade '" + cidade.Nome + "' foi cadastrado com sucesso!";
                return RedirectToAction("Index");
            }
            return View(cidade);
        }
        //-------------------------------------------------------------
        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Cidade cidade = _db.Cidades.Find(Id);
            return View("Cadastrar", cidade);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                _db.Cidades.Update(cidade);
                _db.SaveChanges();

                TempData["Mensagem"] = "A cidade '" + cidade.Nome + "' foi alterado com sucesso!";
                return RedirectToAction("Index");
            }
            return View("Cadastrar", cidade);
        }
        //--------------------------------------------------------------

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            Cidade cidade = _db.Cidades.Find(Id);
            _db.Cidades.Remove(cidade);
            _db.SaveChanges();

            TempData["Mensagem"] = "A cidade '" + cidade.Nome + "' foi removido com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
