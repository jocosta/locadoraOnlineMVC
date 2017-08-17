using CanalDoOvidio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CanalDoOvidio.Controllers
{
    public class CatalogoController : Controller
    {
        // GET: Catalogo
        public ActionResult Index()
        {
            var listaCatalogo = new List<Catalogo>();

            var item1 = new Catalogo();
            item1.Titulo = "Mulher Maravilha";
            item1.Sinopse = "simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos. Lorem Ipsum sobreviveu não só a cinco séculos, como também ao salto para a editoração eletrônica";
            item1.Duracao = 157;
            item1.Diretor = "João F P";
            item1.AnoLancamento = "2017";
            item1.Imagem = "/Images\\mulhermaravilha.jpg ";        

            listaCatalogo.Add(item1);

            var item2 = new Catalogo();
            item2.Titulo = "Doutor Estranho";
            item2.Sinopse = "simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos. Lorem Ipsum sobreviveu não só a cinco séculos, como também ao salto para a editoração eletrônica";
            item2.Duracao = 200;
            item2.Diretor = "Pedro S A";
            item2.AnoLancamento = "2016";
            item2.Imagem = @"/Images/drestranho.jpg";                

            listaCatalogo.Add(item2);

            var item3 = new Catalogo();
            item3.Titulo = "Guardiões da Galaxia";
            item3.Sinopse = "simplesmente uma simulação de texto da indústria tipográfica e de impressos, e vem sendo utilizado desde o século XVI, quando um impressor desconhecido pegou uma bandeja de tipos e os embaralhou para fazer um livro de modelos de tipos. Lorem Ipsum sobreviveu não só a cinco séculos, como também ao salto para a editoração eletrônica";
            item3.Duracao = 180;
            item3.Diretor = "José R C";
            item3.AnoLancamento = "2018";
            item3.Imagem = @"/Images/guardioesdagalaxia.jpg";        

            listaCatalogo.Add(item3);


            return View(listaCatalogo);
        }

        // GET: Catalogo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Catalogo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Catalogo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalogo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Catalogo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Catalogo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Catalogo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
