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
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;

        private readonly IOrder _order;

        // create a constructor for businesslayer
        public OrderController(IOrder order, ILogger<OrderController> logger)
        {
            this._order = order;
            this._logger = logger;

        }
        // GET: OrderController
        public ActionResult Index()
        {
            return View();
        }

        // orders list
        public async Task<ActionResult> OrderList()
        {
            List<Order> orderList = await _order.OrderListAsync();
            return View(orderList);
        }

        // filter order 
       // public async Task<ActionResult> OrderListFilter(string sortOrder)
        //{

        //    List<Order> orderList = await _order.OrderListAsync();
        //    ViewBag.DateSortParm = sortOrder == "Date" ?  "date_desc" : "Date";
            //if (!String.IsNullOrEmpty(orderId))
            //{
                //List<User> userList = await _register.UserListAsync();
           //     var orders = orderList.Where(o => o.OrderId = orderId );
           //     return View(orders);
           // }

        //    switch (sortOrder)
        //    {
        //        case "Date":
        //            var orders = orderList.OrderBy(o => o.OrderDate);
        //            View(orders);
        //        case "date_desc":
        //            orders = orderList.OrderByDescending(o => o.OrderDate);
        //            View(orders);
                    //userList = await _register.UserListAsync();
        //            orders = orderList.OrderByDescending(o => o.OrderId);
         //           return View(orders);
         //   }
      //  }


        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {

            _logger.LogInformation("we are in userController/create");
            return View("CreateOrder");
        }

        // GET: UserController/CreateUser
        [HttpPost]
        public ActionResult CreateOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }
            return View("VerifyCreateOrder", order);
        }
        // Post: UserController/CreateNewUser
        public async Task<ActionResult> CreateNewOrder(Order order) // this task will be waiting for Businesslayer/register task
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }

            bool registeredOrder = await _order.CreateOrderAsync(order); // Register within BusinessLayer

            if (registeredOrder)
            {
                ViewBag.Welcome = "Thanks for your shopping!";
                return View("OrderLandingPage");
            }

            else
            {
                ViewBag.ErrorText = "Hey guy, there was an error!";
                return View("Error");
            }
        }




        // POST: OrderController/Create
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

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
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
