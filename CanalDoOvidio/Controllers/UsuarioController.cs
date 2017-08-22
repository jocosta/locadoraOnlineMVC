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


                return RedirectToAction("Index", "Catalogo");
            }

            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            if (Request.IsAjaxRequest())
                return PartialView();

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Login model, string url)
        {
            var usuario = Session[$"user.{model.Email}"] as Usuario;

            if (usuario == null || usuario.Senha != model.Senha)
            {
                return PartialView();
            }


            FormsAuthentication.SetAuthCookie(model.Email, true);

            if (!string.IsNullOrEmpty(url))
                return RedirectToAction(url);
            else
                return RedirectToAction("Index", "Catalogo");
        }
    }
}