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
        // GET: ProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // Store product
        public async Task<ActionResult> ProductList(string searchString)
        {
            ViewBag.searchString = "";
            var productList = await _product.ProductListAsync();
            var lacationList1 = await _product.LocationListAsync();
            if (!String.IsNullOrEmpty(searchString))
            {
                await _product.GetLocationAsync(searchString);
                var lacationList = lacationList1.Where(u => u.LocationName.Contains(searchString));
                ViewBag.searchString = lacationList.FirstOrDefault().LocationName;
                List<Store> storeList = await _product.StoreListAsync();
                List<StoreProduct> storeProductList = await _product.StoreProductListAsync();
                List<Product> products = await _product.ProductListAsync();
                productList = new List<Product>();

                foreach (var xx in lacationList)
                {
                    var stores = storeList.Where(x => x.LocationId == xx.LocationId).ToList();
                    foreach (var s in stores)
                    {
                        var storeProducts = storeProductList.Where(x => x.StoreId == s.StoreId).ToList();
                        foreach (var spdt in storeProducts)
                        {
                            var product = products.Where(x => x.ProductId == spdt.ProductId).FirstOrDefault();
                            productList.Add(product);
                        }
                    }
                }
            }
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
            return View("VerifyCreateProduct", product);
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




        // POST: ProductController/Create
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

        // POST: ProductController/Edit/5
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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
