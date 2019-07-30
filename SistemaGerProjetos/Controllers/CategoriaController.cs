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
    public class CategoriaController : Controller
    {
        private DatabaseContext _db;

        public CategoriaController(DatabaseContext db)
        {
            _db = db;
        }
        //Listar todas as palavras do banco de dados
        [Authorize(Roles = "Admin")]
        public IActionResult Index(int? page)
        {

            var pageNumber = page ?? 1;

            var categorias = _db.Categorias.ToList();
            var resultadoPaginado = categorias.ToPagedList(pageNumber, 5);

            return View(resultadoPaginado);

        }

        //CRUD - CREATE, READ, UPDATE e DELETE
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new Categoria());
        }

        //[Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Categoria categoria = _db.Categorias.Find(Id);
            return View("Cadastrar", categoria);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Atualizar([FromForm]Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                _db.Categorias.Update(categoria);
                _db.SaveChanges();

                TempData["Mensagem"] = "A categoria '" + categoria.NomeCategoria + "' foi alterada com sucesso!";
                return RedirectToAction("Index");
            }
            return View("Cadastrar", categoria);
        }
        //--------------------------------------------------------------
        [Authorize(Roles = "Admin")]
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
