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
    public class TarefaController : Controller
    {
        private DatabaseContext _db;

        public TarefaController(DatabaseContext db)
        {
            _db = db;
        }

        //Listar todas as palavras do banco de dados
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;

            var tarefas = _db.Tarefas.ToList();
            var resultadoPaginado = tarefas.ToPagedList(pageNumber, 5);

            return View(resultadoPaginado);
        }

        //CRUD - CREATE, READ, UPDATE e DELETE
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Cadastrar()
        {
            var categoriaDb = _db.Categorias.ToList();
            ViewBag.Categoria = categoriaDb;

            var projetoDb = _db.Projetos.ToList();
            ViewBag.Projeto = projetoDb;

            var usuarioDb = _db.Usuarios.ToList();
            ViewBag.Usuario = usuarioDb;

            return View(new Tarefa());
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Cadastrar([FromForm]Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                _db.Tarefas.Add(tarefa);
                _db.SaveChanges();

                TempData["Mensagem"] = "A tarefa '" + tarefa.TituloTarefa+ "' foi cadastrada com sucesso!";
                return RedirectToAction("Index");
            }
            return View(tarefa);
        }
        //-------------------------------------------------------------
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Tarefa tarefa = _db.Tarefas.Find(Id);

            //Categoria
            var nomeCategoriaBuscaDB = _db.Categorias.Where(y => y.Id == Id).Select(x => new { x.NomeCategoria }).ToList();
            ViewBag.NomeCategoriaDB = nomeCategoriaBuscaDB;

            var categoriaDb = _db.Categorias.ToList();
            ViewBag.Categoria = categoriaDb;

            //Projeto
            var nomeProjetoBuscaDB = _db.Projetos.Where(y => y.Id == Id).Select(x => new { x.NomeProjeto }).ToList();
            ViewBag.NomeProjetoDB = nomeProjetoBuscaDB;

            var projetoDb = _db.Projetos.ToList();
            ViewBag.Projeto = projetoDb;

            //Usuário
            var nomeUsuarioBuscaDB = _db.Usuarios.Where(y => y.IdUsuario == Id).Select(x => new { x.NomeUsuario }).ToList();
            ViewBag.NomeUsuarioDB = nomeUsuarioBuscaDB;

            var usuarioDb = _db.Usuarios.ToList();
            ViewBag.Usuario = usuarioDb;

            return View("Cadastrar", tarefa);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Atualizar([FromForm]Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                _db.Tarefas.Update(tarefa);
                _db.SaveChanges();

                TempData["Mensagem"] = "O estado '" + tarefa.TituloTarefa + "' foi alterado com sucesso!";
                return RedirectToAction("Index");
            }
            return View("Cadastrar", tarefa);
        }
        //--------------------------------------------------------------
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            Tarefa tarefa = _db.Tarefas.Find(Id);
            _db.Tarefas.Remove(tarefa);
            _db.SaveChanges();

            TempData["Mensagem"] = "O Estado '" + tarefa.TituloTarefa + "' foi removido com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
