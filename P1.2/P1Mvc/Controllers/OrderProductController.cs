using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1Mvc.Controllers
{
    public class OrderProductController : Controller
    {
        // GET: OrderProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderProductController/Create
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

        // GET: OrderProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderProductController/Edit/5
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

        // GET: OrderProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderProductController/Delete/5
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
