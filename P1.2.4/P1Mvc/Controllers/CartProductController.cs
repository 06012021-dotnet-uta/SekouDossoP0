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
        private readonly ILogger<CartProductController> _logger;

        private readonly ICartProduct _cp;

        // create a constructor for businesslayer
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

        // GET: CartProductController/Create
        public ActionResult Create()
        {
            return View("BackLandingPage");
        }
        // Post: CartProductController/CreateNewCartProduct
        //[HttpPost]
        public async Task<ActionResult> CreateNewCartProduct(Product p) // this task will be waiting for Businesslayer
        //public async Task<ActionResult> CreateNewUser(User user) // this task will be waiting for Businesslayer/register task
        {
            //if (!ModelState.IsValid)
            //{
            //    RedirectToAction("Create");
            //}
            await _cp.AddProductAsync(p);
           // bool registeredUser = await _cp.AddProductAsync(p); // Register within BusinessLayer

            //if (registeredUser)
            //{
            //   RedirectToAction("Create");
                ViewBag.Welcome = "Product added to shopping cart!";
                return View("BackLandingPage");
            //}

            // else
            // {
            //     ViewBag.ErrorText = "Hey guy, there was an error!";
            //     return View("Error");
            // }
        }

        // list of cart product 
        public async Task<ActionResult> ListCartProduct()
        {
            //var listCartProduct = await _cp.ListOfCartProductsAsync();
            //return View(listCartProduct);
            var listCartProduct = await _cp.ListOfCartProductsAsync();
            var listProduct = await _cp.ListOfProductsAsync();
            List<Product> productList = new List<Product>();
            int total = 0;
            foreach (var cp in listCartProduct)
            {
                var products = listProduct.Where(x => x.ProductId == cp.ProductId).ToList();
                foreach (var p in products)
                {
                    total += p.ProductPrice;
                    productList.Add(p);
                }
            }
            ViewBag.data = total ;
            return View(productList);

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
