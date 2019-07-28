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
    public class ClientesController : Controller
    {
        private DatabaseContext _db;

        public ClientesController(DatabaseContext db)
        {
            _db = db;
        }
        //Listar todas as palavras do banco de dados
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;

            var clientes = _db.Clientes.ToList();
            var resultadoPaginado = clientes.ToPagedList(pageNumber, 5);

            return View(resultadoPaginado);
        }

        //CRUD - CREATE, READ, UPDATE e DELETE
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new Cliente());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _db.Clientes.Add(cliente);
                _db.SaveChanges();

                TempData["Mensagem"] = "O cliente '" + cliente.Nome + "' foi cadastrado com sucesso!";
                return RedirectToAction("Index");
            }
            return View(cliente);
        }
        //-------------------------------------------------------------
        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Cliente cliente = _db.Clientes.Find(Id);
            return View("Cadastrar", cliente);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _db.Clientes.Update(cliente);
                _db.SaveChanges();

                TempData["Mensagem"] = "O cadastro do cliente '" + cliente.Nome + "' foi alterado com sucesso!";
                return RedirectToAction("Index");
            }
            return View("Cadastrar", cliente);
        }
        //--------------------------------------------------------------

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            Cliente cliente = _db.Clientes.Find(Id);
            _db.Clientes.Remove(cliente);
            _db.SaveChanges();

            TempData["Mensagem"] = "O cliente '" + cliente.Nome + "' foi removido com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
