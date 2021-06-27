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
    public class StoreProductController : Controller
    {
        // interface var 
        private readonly IStoreProduct _sp;
        private readonly ILogger<StoreProductController> _logger;
        // constructor
        public StoreProductController(IStoreProduct sp, ILogger<StoreProductController> logger)
        {
            this._sp = sp;
            this._logger = logger;
        }

        // GET: StoreProductController
        public ActionResult Index()
        {
            return View();
        }

        // StoreProduct list 
        public async Task<ActionResult> StoreProductList()
        {
            List<StoreProduct> storeProductList = await _sp.StoreProductListAsync();
            List<Product> products = await _sp.ProductListAsync();
            List<StoreProduct> productList = new List<StoreProduct>();

            // foreach (var  xx in storeProductList)
            // { 
            //         var product = products.Where(x => x.ProductId == xx.ProductId).FirstOrDefault();
            //     productList.Add(product);
            //     //Console.WriteLine($" Product name: {product.ProductName} -- product descrition: {product.ProductPrice}$ -- price: {sp.Quantity}");
            // }
            foreach (var xx in storeProductList)
            { 
                    //var product = products.Where(x => x.ProductId == xx.ProductId).FirstOrDefault();
                productList.Add(xx);
                //Console.WriteLine($" Product name: {product.ProductName} -- product descrition: {product.ProductPrice}$ -- price: {sp.Quantity}");
            }
            return View(productList);
        }


        // GET: StoreProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StoreProductController/Create
        public ActionResult Create()
        {
            _logger.LogInformation("we are in Controller/create");
            return View("CreateStoreProduct");
        }

        // create StoreProduct
        [HttpPost]
        public ActionResult CreateStoreProduct(StoreProduct sp)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }
            return View("VerifyCreateStoreProduct", sp);
        }

        // save new StoreProduct
        public async Task<ActionResult> CreateNewStoreProduct(StoreProduct sp) // this task will be waiting for Businesslayer/register task
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }

            bool registeredStoreProduct = await _sp.RegisterStoreProductAsync(sp); // Register within BusinessLayer

            if (registeredStoreProduct)
            {
                ViewBag.Welcome = "New product added added!";
                return View("StoreProductLandingPage");
            }
            else
            {
                ViewBag.ErrorText = "Hey guy, there was an error!";
                return View("Error");
            }
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
