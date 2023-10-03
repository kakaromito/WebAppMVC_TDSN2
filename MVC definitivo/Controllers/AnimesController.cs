using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_definitivo.Models;

namespace MVC_definitivo.Controllers
{
    public class AnimesController : Controller
    {
        // GET: Animes
        public ActionResult Index()
        {
            return View(AnimesModel.CriarList());

        }

        // GET: Animes/Details/5
        public ActionResult Details(int id)
        {


            var animes = AnimesModel.CriarList()[id];
            return View(animes);
        }

        // GET: Animes/Create
        public ActionResult Create(int id)
        {
            var animes = AnimesModel.CriarList()[id];
            return View(animes);
        }

        // POST: Animes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Animes/Edit/5
        public ActionResult Edit(int id)
        {
            var animes = AnimesModel.CriarList()[id];
            return View(animes);
        }

        // POST: Animes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Animes/Delete/5
        public ActionResult Delete(int id)
        {
            var animes = AnimesModel.CriarList()[id];
            return View(animes);
        }

        // POST: Animes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}