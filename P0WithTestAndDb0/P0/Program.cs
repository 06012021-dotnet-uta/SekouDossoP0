using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using P0DbContext;

namespace P0
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <sammary>
            /// The user should login or register
            /// Then user will make a decision for UserOrderHistory, LocationOrderHistory, LocationInventory, StartShopping or Logout
            /// The app will keeps running after the user logout
            /// </summary>
            Choice.RegisterLogin(); 
        }
    }
}






















            // Console.WriteLine($" You selected : {(Choice.MainMenu)selection}.\n");

            // view location inventory 
            // log out 


            // users
            // User user = new User("Sekou", "Dosso", "sekou@gmail.com", "qwer");
            // User user1 = new User("Alex", "Max", "mark@gmail.com", "1234");

            // P0DBContext context = new P0DBContext();
            // var users = context.Users.ToList();
            // foreach(var user in users) { Console.WriteLine(user.FisrtName);  }
            // using ( var db = new P0DBContext())
            // {
            //    var currentUser = db.Users
            //       .Where(x => x.FisrtName == "Sekou");
            //    Console.WriteLine($"the current user is : {currentUser.FirstOrDefault().FisrtName}");
            //}

            // location
            // Location Soho = new Location("Soho", "New York", "NY", 10100);
            // Location Brooklyn = new Location("Brooklyn", "New York", "NY", 20000);
            // store 
            // Store Berluti = new Store("berluti",Soho);
            // Store Rolex = new Store("Rolex", Soho);
            // Store Dsquared2 = new Store("Dsquared2", Brooklyn);
            // products 
            // Product p1 = new Product("Fast track", "Sport shoe", 1000, true);
            // Product p2 = new Product("Play time", "cusual shoe", 1400, true);
            // Product p3 = new Product("DateJust", "Sport watch", 40000, true);
            // Product p4 = new Product("Cellini", "Dress watch", 5000, true);
            // Product p5 = new Product(" Ripped wash", "Denim Jacket", 500, true);
            // Product p6 = new Product("Dark 3", "Staker Jeans", 300, true);

            // cart 
            // Cart cart = new Cart();


            // add to shoppingCart 
            // Console.WriteLine(typeof(cart));
            // cart.AddProduct(p1);
            // cart.AddProduct(p3);
            // cart.AddProduct(p6);



            // User fakeUser = new User("firstName", "lastName", "email", "userPassWord");
            // fakeUser.Register();
            // select store 
            // Console.WriteLine("Please select a store");
            // User.StoreSelection();
            // int selectedStore = User.StoreSelection();
            // Console.WriteLine($"Please start your shopping at {(StoreChoice.StoreList)selectedStore}");
            // select * from products where x.name == (StoreChoice.StoreList)selectedStore