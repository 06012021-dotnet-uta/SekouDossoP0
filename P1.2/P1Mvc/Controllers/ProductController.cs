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
    public class ProductController : Controller
    {
        // Istore var 
        private readonly IProduct _product;
        private readonly ILogger<ProductController> _logger;
        // controller's constructor
        public ProductController(IProduct product, ILogger<ProductController> logger)
        {
            this._product = product;
            this._logger = logger;
        }
        // GET: StoreController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StoreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // Store product
        public async Task<ActionResult> ProductList()
        {
            List<Product> productList = await _product.ProductListAsync();
            return View(productList);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View("CreateProduct");
        }
        // Create Product  
        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }
            return View("VerifyCreateStore", product);
        }

        // save new store 

        public async Task<ActionResult> CreateNewProduct(Product product)
        // this task will be waiting for Businesslayer/register task
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }

            bool registeredProduct = await _product.RegisterProductAsync(product); // Register within BusinessLayer

            if (registeredProduct)
            {
                ViewBag.Welcome = "Hey guy, welcome to Shopping Bay!";
                return View("ProductLandingPage");
            }

            else
            {
                ViewBag.ErrorText = "Hey guy, there was an error!";
                return View("Error");
            }
        }




        // POST: StoreController/Create
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

        // GET: StoreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreController/Edit/5
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

        // GET: StoreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreController/Delete/5
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
