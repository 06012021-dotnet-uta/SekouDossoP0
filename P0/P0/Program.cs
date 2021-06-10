using System;
using System.Collections;
using System.Collections.Generic;

namespace P0
{
    class Program
    {
        static void Main(string[] args)
        {
            // location
            Location Soho = new Location("Soho", "New York", "NY", 10100);
            Location Brooklyn = new Location("Brooklyn", "New York", "NY", 20000);
            // store 
            Store Berluti = new Store("berluti",Soho);
            Store Rolex = new Store("Rolex", Soho);
            Store Dsquared2 = new Store("Dsquared2", Brooklyn);
            // products 
            Product p1 = new Product("Fast track", "Sport shoe", 1000, true, Berluti);
            Product p2 = new Product("Play time", "cusual shoe", 1400, true, Berluti);
            Product p3 = new Product("DateJust", "Sport watch", 40000, true, Rolex);
            Product p4 = new Product("Cellini", "Dress watch", 5000, true, Rolex);
            Product p5 = new Product(" Ripped wash", "Denim Jacket", 500, true, Dsquared2);
            Product p6 = new Product("Dark 3", "Staker Jeans", 300, true, Dsquared2);
            // users
            User fakeUser = new User("", "", "");
            User user = new User("Sekou", "Dosso", "qwer");
            User user1 = new User("Alex", "Max", "1234");

            // cart 
            Cart cart = new Cart();
            // add to shoppingCart 
            // Console.WriteLine(typeof(cart));
            cart.AddProduct(p1);
            cart.AddProduct(p3);
            cart.AddProduct(p6);
            


            Console.WriteLine("Welcome to Shopping bay");
            fakeUser.Register();
            // select store 
            Console.WriteLine("Please select a store");
            // User.StoreSelection();
            int selectedStore = User.StoreSelection();
            Console.WriteLine($"Please start your shopping at {(StoreChoice.StoreList)selectedStore}");



            

        }
    }
}
