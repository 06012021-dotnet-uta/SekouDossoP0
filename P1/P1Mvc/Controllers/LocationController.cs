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
    public class LocationController : Controller
    {
        private readonly ILogger<LocationController> _logger;

        private readonly ILocation _location;

        // create a constructor 
        public LocationController(ILocation location, ILogger<LocationController> logger)
        {
            this._location = location;
            this._logger = logger;

        }
        // GET: LocationController
        public ActionResult Index()
        {
            return View();
        }

        // locations list 
        public async Task<ActionResult> LocationList()
        {
            List<Location> locationList = await _location.LocationListAsync();
            return View(locationList);
        }

        // GET: LocationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LocationController/Create
        public ActionResult Create()
        {

            _logger.LogInformation("we are in Controller/create");
            return View("CreateLocation");
        }

        // create Location
        [HttpPost]
        public ActionResult CreateLocation(Location location )
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }
            return View("VerifyCreateLocation", location);
        }

        // crreate new Location
        public async Task<ActionResult> CreateNewLocation(Location location ) // this task will be waiting for Businesslayer/register task
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }

            bool registeredLocation = await _location.RegisterLocationAsync(location); // Register within BusinessLayer

            if (registeredLocation)
            {
                ViewBag.Welcome = "New Location added!";
                return View("LocationLandingPage");
            }

            else
            {
                ViewBag.ErrorText = "Hey guy, there was an error!";
                return View("Error");
            }
        }


        // POST: LocationController/Create
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

        // GET: LocationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LocationController/Edit/5
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

        // GET: LocationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LocationController/Delete/5
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
