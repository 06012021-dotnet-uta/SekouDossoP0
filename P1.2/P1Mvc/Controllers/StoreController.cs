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
    public class StoreController : Controller
    {
        // Istore var 
        private readonly IStore _store;
        private readonly ILogger<StoreController> _logger;
        // controller's constructor
        public StoreController(IStore store, ILogger<StoreController> logger)
        {
            this._store = store;
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
        // Store list 
        public async Task<ActionResult> StoreList()
        {
            List<Store> storeList = await _store.StoreListAsync();
            return View(storeList);
        }

        // GET: StoreController/Create
        public ActionResult Create()
        {
            return View("CreateStore");
        }
        // Create Store  
        [HttpPost]
        public ActionResult CreateStore(Store store)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }
            return View("VerifyCreateStore", store);
        }

        // save new store 

        public async Task<ActionResult> CreateNewStore(Store store) 
            // this task will be waiting for Businesslayer/register task
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }

            bool registeredStore = await _store.RegisterStoreAsync(store); // Register within BusinessLayer

            if (registeredStore)
            {
                ViewBag.Welcome = "Hey guy, welcome to Shopping Bay!";
                return View("StoreLandingPage");
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
