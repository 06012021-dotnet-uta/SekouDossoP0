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
    public class OrderProductController : Controller
    {
        // instance of IOrderProduct
        private readonly ILogger<OrderProductController> _logger;
        private readonly IOrderProduct _orderProduct;
        // constructor
        public OrderProductController (IOrderProduct orderProduct, ILogger<OrderProductController> logger)
        {
            this._orderProduct = orderProduct;
            this._logger = logger;
        }
        // GET: OrderProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderProduct list
        public async Task<ActionResult> OrderProductList()
        {
            List<OrderProduct> orderProductList = await _orderProduct.OrderProductListAsync();
            return View(orderProductList);
        }

        // GET: OrderProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderProductController/Create
        public ActionResult Create()
        {
            _logger.LogInformation("we are in OrderProductController/create");
            return View("CreateOrderProduct");
        }

        // Create OrderProduct
        [HttpPost]
        public ActionResult CreateOrderProduct(OrderProduct op )
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }
            return View("VerifyCreateLocation", op);
        }

        // save  new OrderProduct
        public async Task<ActionResult> CreateNewOrderProduct(OrderProduct op) // this task will be waiting for Businesslayer/register task
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Create");
            }

            bool registeredOrderProduct = await _orderProduct.RegisterOrderProductAsync(op); // Register within BusinessLayer

            if (registeredOrderProduct)
            {
                ViewBag.Welcome = "New order added!";
                return View("OrderProductLandingPage");
            }

            else
            {
                ViewBag.ErrorText = "Hey guy, there was an error!";
                return View("Error");
            }
        }



        // POST: OrderProductController/Create
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

        // GET: OrderProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderProductController/Edit/5
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

        // GET: OrderProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderProductController/Delete/5
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
