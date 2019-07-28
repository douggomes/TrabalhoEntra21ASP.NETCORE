﻿using Microsoft.AspNetCore.Mvc;
using SistemaGerProjetos.Database;
using SistemaGerProjetos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace SistemaGerProjetos.Controllers
{
    public class EstadoController : Controller
    {
        private DatabaseContext _db;

        public EstadoController(DatabaseContext db)
        {
            _db = db;
        }
        //Listar todas as palavras do banco de dados
        public IActionResult Index(int? page)
        {
            
            var pageNumber = page ?? 1;

            var estados = _db.Estados.ToList();
            var resultadoPaginado = estados.ToPagedList(pageNumber, 5);

            return View(resultadoPaginado);
           
           
        }

        //CRUD - CREATE, READ, UPDATE e DELETE
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new Estado());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Estado estado)
        {
            if (ModelState.IsValid)
            {
                _db.Estados.Add(estado);
                _db.SaveChanges();

                TempData["Mensagem"] = "O estado '" + estado.NomeEstado + "' foi cadastrado com sucesso!";
                return RedirectToAction("Index");
            }
            return View(estado);
        }
        //-------------------------------------------------------------
        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Estado estado = _db.Estados.Find(Id);
            return View("Cadastrar", estado);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Estado estado)
        {
            if (ModelState.IsValid)
            {
                _db.Estados.Update(estado);
                _db.SaveChanges();

                TempData["Mensagem"] = "O estado '" + estado.NomeEstado + "' foi alterado com sucesso!";
                return RedirectToAction("Index");
            }
            return View("Cadastrar", estado);
        }
        //--------------------------------------------------------------

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            Estado estado = _db.Estados.Find(Id);
            _db.Estados.Remove(estado);
            _db.SaveChanges();

            TempData["Mensagem"] = "O Estado '" + estado.NomeEstado + "' foi removido com sucesso!";

            return RedirectToAction("Index");
        }
    }
}
