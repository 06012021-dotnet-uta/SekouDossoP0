using BusinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1Mvc.Controllers
{
    public class CartProductController : Controller
    {
        // Istore var 
        private readonly ICartProduct _cp;
        private readonly ILogger<CartProductController> _logger;
        // controller's constructor
        public CartProductController(ICartProduct cp, ILogger<CartProductController> logger)
        {
            this._cp = cp;
            this._logger = logger;
        }


        // GET: CartProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CartProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CartController/AddProduct
        public async Task<ActionResult> AddProduct(Product p)
        {
            bool result = await _cp.AddProductAsync(p); // 

            if (result)
            {
                ViewBag.Welcome = "Hey guy, welcome to Shopping Bay!";
                var cartProducts = await _cp.CartProductsAsync();
                return View("CartProductList", cartProducts);
               
            }

            else
            {
                ViewBag.ErrorText = "Hey guy, there was an error!";
                return View("Error");
            }
        }

        // GET: CartProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartProductController/Create
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

        // GET: CartProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartProductController/Edit/5
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

        // GET: CartProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CartProductController/Delete/5
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
