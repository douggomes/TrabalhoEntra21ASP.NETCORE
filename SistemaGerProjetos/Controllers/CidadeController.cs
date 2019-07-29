using Microsoft.AspNetCore.Mvc;
using SistemaGerProjetos.Database;
using SistemaGerProjetos.Library;
using SistemaGerProjetos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace SistemaGerProjetos.Controllers
{
    [Login]
    public class CidadeController : Controller
    {
        private DatabaseContext _db;

        public CidadeController(DatabaseContext db)
        {
            _db = db;
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
            var estadoDb = _db.Estados.ToList();

            ViewBag.Estado = estadoDb;
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

            var NomeEstadoBuscaDB = _db.Cidades.Where(y => y.Id == Id).Select(x => new { x.NomeEstado }).ToList();

            ViewBag.NomeEstadoDB = NomeEstadoBuscaDB;

            var estadoDb = _db.Estados.ToList();

            ViewBag.Estado = estadoDb;

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
