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
        // Location order list 
        public async Task<ActionResult> LocationOrder()
        {
            List<Location> locations = await _order.LocationOrderListAsync();
            List<Order> orders = await _order.OrderListAsync();
            List<Order> orderList = new List<Order>();
            
            foreach (var  xx in locations)
            { 
                    var matchOrders = orders.Where(x => x.LocationId == xx.LocationId).ToList();
                    try{
                        foreach(var x in matchOrders)
                        orderList.Add(x);
                    }
                    catch (Exception ex){
                        Console.WriteLine(ex);
                    }
            }
            return View(orderList);
        }

        // user order list
        public async Task<ActionResult> UserOrder()
        {
            List<User> users = await _order.UserOrderListAsync();
            List<Order> orders = await _order.OrderListAsync();
            List<Order> orderList = new List<Order>();
            foreach (var  xx in users)
            { 
                    var matchOrders = orders.Where(x => x.UserId == xx.UserId).ToList();
                    try{
                        foreach(var x in matchOrders)
                        orderList.Add(x);
                    }
                    catch (Exception ex){
                        Console.WriteLine(ex);
                    }
            }
            return View(orderList);
        }
       
       // filter order 
       public async Task<ActionResult> OrderListFilter(string sortOrder, int searchString)
        {

            List<Order> orderList = await _order.OrderListAsync();
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            if (searchString > 0)
            {
                //List<User> orderList = await _register.orderListAsync();
                var orders = orderList.Where(x => x.UserId == searchString);
                            
                return View(orders);
            }

            switch (sortOrder)
            {
                case "name_desc":
                    //List<User> orderList = await _register.orderListAsync();
                    var orders = orderList.OrderBy(u => u.OrderId);
                    return View(orders);
                default:
                    //orderList = await _register.orderListAsync();
                    orders = orderList.OrderByDescending(u => u.OrderDate);
                    return View(orders);
            }    
        }



        // GET: OrderController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            List<Order> orders = await _order.OrderListAsync();
            var targetOrder = orders.Where(x => x.OrderId == id).FirstOrDefault();
            var orderProducts = await _order.OrderProductListAsync();
            var orderProds = orderProducts.Where(x => x.OrderId == id).ToList();
            List<Product> prodList = new List<Product>();
            var products = await _order.ProductListAsync();
            int total = 0;
            foreach (var xx in orderProds)
            {
                var targetProds = products.Where(x => x.ProductId == xx.ProductId).ToList();
                foreach( var p in targetProds) {
                    total += p.ProductPrice;
                    prodList.Add(p); 
                }        
            }
            ViewBag.OrderId = id;
            ViewBag.total = total;
            return View(prodList);
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
