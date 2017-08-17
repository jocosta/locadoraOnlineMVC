using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CanalDoOvidio.Controllers
{                
    [Authorize]
    public class FilmeController : Controller
    {
        // GET: Filme
        public ActionResult Exibir(string id)
        {
            ViewBag.Titulo = id;
            switch (id)
            {
                case "Mulher Maravilha":
                    ViewBag.Url = "https://www.youtube.com/embed/Eg8qFkwUmOw";
                    break;
                case "Doutor Estranho":
                    ViewBag.Url = "https://www.youtube.com/embed/YUfWrIcX4zw";
                    break;
                case "Guardiões da Galaxia":
                    ViewBag.Url = "https://www.youtube.com/embed/8VN_l57QWyQ";
                    break;
            }

            return View();
        }
    }
}