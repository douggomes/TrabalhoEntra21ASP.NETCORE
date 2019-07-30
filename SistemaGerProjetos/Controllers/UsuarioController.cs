using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGerProjetos.Database;
using SistemaGerProjetos.Models;
using X.PagedList;

namespace SistemaGerProjetos.Controllers
{
    public class UsuarioController : Controller
    {
        private DatabaseContext _db;
        public UsuarioController(DatabaseContext db)
        {
            _db = db;
        }

        [Authorize(Roles ="Admin")]
        public IActionResult ListaUsuarios(int? page)
        {
            var pageNumber = page ?? 1;

            var usuarios = _db.Usuarios.ToList();
            var resultadoPaginado = usuarios.ToPagedList(pageNumber, 5);

            return View(resultadoPaginado);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] string login, string senha)
        {
            if (ModelState.IsValid)
            {
                var usuarioExiste = _db.Usuarios.Select(x => new
                {
                    x.Login,
                    x.Senha
                })
                .Where(x => x.Login == login && x.Senha == senha).ToList();


                if (usuarioExiste.Count == 1)
                {
                    Usuario usuario = new Usuario();
                    usuario.Login = login;

                    var roleUsuario = _db.Usuarios.Where(x => x.Login == login && x.Role == "Admin").Select(y => y.Role).ToList();

                    if(roleUsuario.Count == 1)
                    {
                        usuario.Role = "Admin";
                    }
                    else
                    {
                        usuario.Role = "User";
                    }

                    var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, usuario.Login),
                    new Claim(ClaimTypes.Role, usuario.Role)
                    }, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    var logar = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    //HttpContext.Session.SetString("Login", "true");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.MensagemErro = "Usuário e senha não identificados!";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    _db.Usuarios.Add(usuario);
                    _db.SaveChanges();

                    string login = HttpContext.Session.GetString("Login");

                    TempData["Mensagem"] = "O usuário '" + usuario.NomeUsuario + "' foi cadastrado com sucesso!";

                    if (login == null)
                    {
                        return RedirectToAction("Login", "Usuario");
                    }
                    else
                    {
                        return RedirectToAction("ListaUsuarios", "Usuario");
                    }
                }
                return View(usuario);
            }

            ViewBag.MensagemErro = "Não foi possivel cadastrar o usuário!";
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Usuario usuario = _db.Usuarios.Find(Id);
            return View("Cadastrar", usuario);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm]Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _db.Usuarios.Update(usuario);
                _db.SaveChanges();

                TempData["Mensagem"] = "O usuario '" + usuario.NomeUsuario + "' foi alterado com sucesso!";
                return RedirectToAction("Index");
            }
            return View("Cadastrar", usuario);
        }

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            Usuario usuario = _db.Usuarios.Find(Id);
            _db.Usuarios.Remove(usuario);
            _db.SaveChanges();

            TempData["Mensagem"] = "O Estado '" + usuario.NomeUsuario + "' foi removido com sucesso!";

            return RedirectToAction("Index");
        }

        public ActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            HttpContext.Session.Clear();

            return RedirectToAction("Login", "Usuario");
        }


    }
}