﻿using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class ClientesController : Controller
    {
        private DatabaseContext _db;

        public ClientesController(DatabaseContext db)
        {
            _db = db;
        }
        //Listar todas as palavras do banco de dados
        [Authorize(Roles = "Admin")]
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;

            var clientes = _db.Clientes.ToList();
            var resultadoPaginado = clientes.ToPagedList(pageNumber, 5);

            return View(resultadoPaginado);
        }

        //CRUD - CREATE, READ, UPDATE e DELETE
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new Cliente());
        }

        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Cliente cliente = _db.Clientes.Find(Id);
            return View("Cadastrar", cliente);
        }

        [Authorize(Roles = "Admin")]
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

        [Authorize(Roles = "Admin")]
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
