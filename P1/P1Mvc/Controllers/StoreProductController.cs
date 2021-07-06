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
        public async Task<ActionResult> StoreProductList(string sortOrder, string searchString)
        {
            var lacationList = await _sp.LocationListAsync();
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            if (!String.IsNullOrEmpty(searchString))
            {
                //List<User> userList = await _register.UserListAsync();
                lacationList = lacationList.Where(l => l.LocationName.Contains(searchString)
                            || l.City.Contains(searchString)).ToList();
                //return View(locations);
            }

            switch (sortOrder)
            {
                case "name_desc":
                    //List<User> lacationList = await _register.lacationListAsync();
                    lacationList = lacationList.OrderBy(l => l.LocationName).ToList();
                    break;
                default:
                    //lacationList = await _register.lacationListAsync();
                    lacationList = lacationList.OrderByDescending(l => l.ZipCode).ToList();
                    break;            
            }
            List<Store> storeList = await _sp.StoreListAsync();
            List<StoreProduct> storeProductList = await _sp.StoreProductListAsync();
            List<Product> products = await _sp.ProductListAsync();
            List<StoreProduct> productList = new List<StoreProduct>();

            foreach (var xx in lacationList)
            {
                var stores= storeList.Where(x => x.LocationId == xx.LocationId).ToList();
                foreach (var s in stores)
                {
                    var storeProducts = storeProductList.Where(x => x.StoreId == s.StoreId).ToList();
                    foreach (var spdt in storeProducts)
                    {
                        productList.Add(spdt);
                    }
                }
            }
            return View(productList);
        }

        // users filter 
        public async Task<ActionResult> InventoryFilter(string sortOrder, string searchString)
        {

            List<Location> lacationList = await _sp.LocationListAsync();
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            if (!String.IsNullOrEmpty(searchString))
            {
                //List<User> userList = await _register.UserListAsync();
                var locations = lacationList.Where(l => l.LocationName.Contains(searchString)
                            || l.City.Contains(searchString));
                return View(locations);
            }

            switch (sortOrder)
            {
                case "name_desc":
                    //List<User> lacationList = await _register.lacationListAsync();
                    var locations = lacationList.OrderBy(l => l.LocationName);
                    return View(locations);
                default:
                    //lacationList = await _register.lacationListAsync();
                    locations = lacationList.OrderByDescending(l => l.LocationState);
                    return View(locations);
            }
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
