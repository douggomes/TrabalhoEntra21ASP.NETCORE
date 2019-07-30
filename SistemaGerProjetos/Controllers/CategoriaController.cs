using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaGerProjetos.Database;
using SistemaGerProjetos.Models;
using X.PagedList;

namespace SistemaGerProjetos.Controllers
{
    public class CategoriaController : Controller
    {
        private DatabaseContext _db;

        public CategoriaController(DatabaseContext db)
        {
            _db = db;
        }
        //Listar todas as palavras do banco de dados
        public IActionResult Index(int? page)
        {

            var pageNumber = page ?? 1;

            var categorias = _db.Categorias.ToList();
            var resultadoPaginado = categorias.ToPagedList(pageNumber, 5);

            return View(resultadoPaginado);


        }

        //CRUD - CREATE, READ, UPDATE e DELETE
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new Categoria());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _db.Categorias.Add(categoria);
                _db.SaveChanges();

                TempData["Mensagem"] = "A categoria '" + categoria.NomeCategoria + "' foi cadastrado com sucesso!";
                return RedirectToAction("Index");
            }
            return View(categoria);
        }
        //-------------------------------------------------------------
        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Categoria categoria = _db.Categorias.Find(Id);
            return View("Cadastrar", categoria);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _db.Categorias.Update(categoria);
                _db.SaveChanges();

                TempData["Mensagem"] = "A categoria '" + categoria.NomeCategoria + "' foi alterado com sucesso!";
                return RedirectToAction("Index");
            }
            return View("Cadastrar", categoria);
        }
        //--------------------------------------------------------------

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            Categoria categoria = _db.Categorias.Find(Id);
            _db.Categorias.Remove(categoria);
            _db.SaveChanges();

            TempData["Mensagem"] = "A categoria '" + categoria.NomeCategoria + "' foi removida com sucesso!";

            return RedirectToAction("Index");
        }
    }
}