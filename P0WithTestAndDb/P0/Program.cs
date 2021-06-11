using System;
using System.Collections;
using System.Collections.Generic;
// using P0DbContext;

namespace P0
{
    class Program
    {
        static void Main(string[] args)
        {
            // users
            User user = new User("Sekou", "Dosso", "sekou@gmail.com", "qwer");
            User user1 = new User("Alex", "Max", "mark@gmail.com", "1234");
            // location
            Location Soho = new Location("Soho", "New York", "NY", 10100);
            Location Brooklyn = new Location("Brooklyn", "New York", "NY", 20000);
            // store 
            Store Berluti = new Store("berluti",Soho);
            Store Rolex = new Store("Rolex", Soho);
            Store Dsquared2 = new Store("Dsquared2", Brooklyn);
            // products 
            Product p1 = new Product("Fast track", "Sport shoe", 1000, true);
            Product p2 = new Product("Play time", "cusual shoe", 1400, true);
            Product p3 = new Product("DateJust", "Sport watch", 40000, true);
            Product p4 = new Product("Cellini", "Dress watch", 5000, true);
            Product p5 = new Product(" Ripped wash", "Denim Jacket", 500, true);
            Product p6 = new Product("Dark 3", "Staker Jeans", 300, true);

            // cart 
            Cart cart = new Cart();

            // register or login 
            // select a store 
            // display store's products
            // add product to cart
            // checkout cart if possible 
            // view user order history 
            // view location order history 
            // view location inventory 
            // log out 

            // add to shoppingCart 
            // Console.WriteLine(typeof(cart));
            cart.AddProduct(p1);
            cart.AddProduct(p3);
            cart.AddProduct(p6);
            


            Console.WriteLine("Welcome to Shopping bay");
            User fakeUser = new User("firstName", "lastName", "email", "userPassWord");
            fakeUser.Register();
            // select store 
            Console.WriteLine("Please select a store");
            // User.StoreSelection();
            int selectedStore = User.StoreSelection();
            Console.WriteLine($"Please start your shopping at {(StoreChoice.StoreList)selectedStore}");
            // select * from products where x.name == (StoreChoice.StoreList)selectedStore



            

        }
    }
}
