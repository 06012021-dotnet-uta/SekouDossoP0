using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1Mvc.Controllers
{
    public class StoreProductController : Controller
    {
        // GET: StoreProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StoreProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoreProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StoreProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
