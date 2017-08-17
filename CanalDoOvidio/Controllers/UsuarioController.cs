using CanalDoOvidio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CanalDoOvidio.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View(new Usuario());
        }


        [HttpPost]
        public ActionResult Cadastrar(Usuario model)
        {
            if (ModelState.IsValid)
            {
                Session[$"user.{model.Email}"] = model;


                return RedirectToAction("Index", "Catologo");
            }

            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Login model, string ulr)
        {
            var usuario = Session[$"user.{model.Email}"] as Usuario;

            if (usuario == null && usuario.Senha != model.Senha)
            {
                return View();
            }


            FormsAuthentication.SetAuthCookie(model.Email, true);

            if (!string.IsNullOrEmpty(ulr))
                return RedirectToAction(ulr);
            return RedirectToAction("Index", "Catalogo");

        }
    }
}