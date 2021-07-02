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
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        private readonly IAccount _a;

        // create a constructor for businesslayer
        public AccountController(IAccount a, ILogger<AccountController> logger)
        {
            this._a = a;
            this._logger = logger;

        }
        // GET: AccontController/Login
        public ActionResult Login()
        {

            //_logger.LogInformation("we are in userController/create");
            return View("UserLogin");
        }
        // login 
        public async Task<ActionResult> UserLogin(Account a)
        {
            bool r =  await _a.LoginAsync(a);
            if (r) { return View("MainLandingPage");}
             else { return View("HomeLandingPage"); }
            // await _a.LoginAsync(a);
            // List<Account> accountList = await _a.AccountListAsync();
            // List<Account> accounts = accountList.Where(x => x.UserName==a.UserName && x.UserPassWord==a.UserPassWord).ToList();
            // if (accounts.Count<1) { return View("HomeLandingPage");}
            //  else { return View("MainLandingPage"); }
        }

        // Account list 
        public async Task<ActionResult> AccountList()
        {
            List<Account> accountList = await _a.AccountListAsync();
            return View(accountList);
        }
        // GET: AccountController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Create
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

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
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

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
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
