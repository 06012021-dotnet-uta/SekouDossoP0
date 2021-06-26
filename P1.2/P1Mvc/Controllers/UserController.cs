using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelsLayer;
//using P1Mvc.Models;
using RepositoryLayer;

namespace P1Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        private readonly IRegisterUser _register;

        // create a constructor for businesslayer
        public UserController (IRegisterUser register, ILogger<UserController> logger)
        {
            this._register = register;
            this._logger = logger;

        }
        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }
         // user List 
        public async Task<ActionResult> UserList()
        {
            List<User> userList = await _register.UserListAsync();
            return View(userList);
        }

        public async Task<ActionResult> UserListFilter(string sortOrder, string searchString)
        {

            List<User> userList = await _register.UserListAsync();
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            if (!String.IsNullOrEmpty(searchString))
            {
                //List<User> userList = await _register.UserListAsync();
                var users = userList.Where(u => u.LastName.Contains(searchString) 
                            || u.FirstName.Contains(searchString));
                return View(users);
            }

            switch (sortOrder)
            {
                case "name_desc":
                    //List<User> userList = await _register.UserListAsync();
                    var users = userList.OrderBy(u => u.FirstName);
                    return View(users);
                default:
                    //userList = await _register.UserListAsync();
                    users = userList.OrderByDescending(u => u.LastName);
                    return View(users);
            }    
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // Log in 
        // GET: UserController/Login
        public ActionResult Login()
        {

            _logger.LogInformation("we are in userController/create");
            return View("UserLogin");
        }

        public async Task<ActionResult> UserLogin( Account a)
        // public void Login(User u)
        {
            
            var result = await _register.LoginAsync();
            var currentAccount = result.Where(x => x.UserName == a.UserName && x.UserPassWord == a.UserPassWord).ToList(); 
            if (currentAccount.Count>0){
                return View("MainLandingPage");
            }
            // if (result){
            //     // RedirectToAction("Index", "Main");
            else { return View("LoggedInLandingPage"); }
            // }
            // else
            // {
            //     ViewBag.ErrorText = "Hey guy, there was an error!";
            //     //return RedirectToAction("Index", "Home");
            //     return View("LoggedInLandingPage");
            //     //return View("UserLogin");
            // }
        }

        // GET: UserController/Create
        public ActionResult Create()
        {

            _logger.LogInformation("we are in userController/create");
            return View("CreateUser");
        }

        // GET: UserController/CreateUser
        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }
            return View("VerifyCreateUser", user);
        }
        // Post: UserController/CreateNewUser
        public async Task<ActionResult> CreateNewUser(User user) // this task will be waiting for Businesslayer/register task
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }

            bool registeredUser = await _register.RegisterUserAsync(user); // Register within BusinessLayer

            if (registeredUser)
            {
                ViewBag.Welcome = "Hey guy, welcome to Shopping Bay!";
                return View("LoggedInLandingPage");
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
