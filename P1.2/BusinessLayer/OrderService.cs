﻿using Microsoft.EntityFrameworkCore;
using ModelsLayer;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderService : IOrder 
    {
        // first define the context 
        private readonly P1Db _context;

        // create a constructor
        public OrderService(P1Db context) { this._context = context; }

        public async Task<bool> CreateOrderAsync(Order order)
        {
             //create a try/catch  to save user
            await _context.Orders.AddAsync(order);
            try { await _context.SaveChangesAsync(); }
            catch (DbUpdateConcurrencyException ex)
            {
                Console.WriteLine($"There was a problem updating the Db => {ex.InnerException}");
                return false;
            }
            catch (DbUpdateException ex)
            {       //change this to logging
                Console.WriteLine($"There was a problem updating the Db => {ex.InnerException}");
                return false;
            }

            return true;

        }

         //userList 
        public async Task<List<Order>> OrderListAsync()
        {
            List<Order> ps = null;
            try
            {
                ps = _context.Orders.ToList();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"There was a problem gettign the players list => {ex.InnerException}");
            }
            return ps;
        }
       
    }
}