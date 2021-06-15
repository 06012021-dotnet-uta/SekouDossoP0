using System;
using Xunit;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P0DbContext;

namespace p0.Tests
{
    public class UnitTest1
    {
        P0DBContext context = new P0DBContext();
        // test10
        // test9
        // test8
        // test7
        // test6
        [Fact] // test5
        public void DisplayStoreProduct() // Berluti store has 2 products in their store
        {
            //arrange
            int store_id = 1; // Berluti
            // act
            int storeProducts = context.StoreProducts.Where(x => x.StoreId == store_id).ToList().Count();
            // assert 
            Assert.Equal(2, storeProducts);
        }// end LocationInventory

        
        [Fact] // test4 
        public void LocationInventory() // Broklyn has no order history result
        {
            //arrange
            int location_id = 1;
            int numberOfProduct = 0;
            // act
            var storesCount = context.Stores.Where(x => x.LocationId == location_id).ToList().Count();
            var stores = context.Stores.Where(x => x.LocationId == location_id).ToList();
            foreach (var store in stores)
            {
                var storeProducts = context.StoreProducts.Where(x => x.StoreId == store.StoreId).ToList();
                foreach (var storeProduct in storeProducts)
                {
                    var productsCount = context.Products.Where(x => x.ProductId == storeProduct.StoreProductId).ToList().Count();
                    var products = context.Products.Where(x => x.ProductId == storeProduct.StoreProductId).ToList();
                    foreach(var p in products)
                    {
                        int productQuantity =  storeProduct.StoreProductQuantity;
                        numberOfProduct += productQuantity;
                    }
                }
            }            // assert 
            Assert.Equal(20, numberOfProduct);
        }// end LocationInventory

        [Fact]  // test3
        public void LocationOrderHistory() // Broklyn has no order history result
        {
            //arrange
            int y = 2;
            string result = "";
            // act
            var BrooklynOrders = context.Orders.Where(x => x.LocationId == y).ToList();
            if (BrooklynOrders.Count < 1) result = "This location have no order history.";
            else  result = "This location has an order history";
            // assert 
            Assert.Equal("This location have no order history.", result);
        }// end OrderHistory

        [Theory] //test2
        [InlineData(1)]
        public void UserOrderHistory(int y)
        {
            //arrange ('Mark','Moore', 'mark@gmail.com', '1234');
            y = 1;
            // act 
            var orders = context.Orders.Where(x => x.UserId == y).ToList();
            // assert
            Assert.Equal(1 , orders.Count());
        }

        // [Fact]// test1
        // public void CreateUser() // create a new user
        // {
            // var newUser = new P0DbContext.User();

            //     newUser.FisrtName = "Mark";
            //     newUser.LastName = "Moore";
            //     newUser.Email = "test@gmail.com";
            //     newUser.UserPassWord = "1234";
            //     context.Add(newUser); 
            //     context.SaveChanges();
            // // act 
            //     var registeredUser = context.Users.ToList().Where(x => x.Email == "m@gmail.com").FirstOrDefault().FisrtName;
            // // assert
            // Assert.Equal("Mark",registeredUser);
        //}
      
    }
}
