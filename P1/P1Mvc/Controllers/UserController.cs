using BusinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1Mvc.Controllers
{
    public class UserController : Controller
    {

        // create a constructor for newUser
        readonly IRegister _register;
        public UserController (IRegister register)
        {
            this._register = register;
        }
        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }
        // GET: UserController/CreateUser
        public ActionResult CreateUser(User user)
        {
            if (!ModelState.IsValid) RedirectToAction("Create");
            return View("VerifyCreateuser", user);
        }
        // Post: UserController/CreateNewUser
        [HttpPost]
        public async Task<ActionResult> CreateNewUser(User user) // this task will be waiting for Businesslayer/register task
        {
            if (!ModelState.IsValid) RedirectToAction("Create");

            bool registeredUser = await _register.RegisterUser(user); // Register within BusinessLayer

            if (registeredUser)
            {
                ViewBag.Welcome = "Hey guy, welcome to R-P-S!";
                return View(registeredUser);
            }

            else
            {
                ViewBag.ErrorText = "Hey guy, there was an error!";
                return View("Error");
            }
        }

        // POST: UserController/Create
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

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
