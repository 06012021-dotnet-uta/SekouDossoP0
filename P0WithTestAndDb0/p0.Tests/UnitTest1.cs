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

        [Fact] // test5
        public void DisplayStoreProduct() // Berluti store has 2 products in their store
        {
            //Arrange
            int store_id = 1; // Berluti
            // Act
            int storeProducts = context.StoreProducts.Where(x => x.StoreId == store_id).ToList().Count();
            // Assert 
            Assert.Equal(2, storeProducts);
        }// end 

        
        [Fact] // test4 
        public void LocationInventory() // Broklyn has no order history result
        {
            //Arrange
            int location_id = 1;
            int numberOfProduct = 0;
            // Act
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
            }            
            // Assert 
            Assert.Equal(20, numberOfProduct);
        }// end 

        [Fact]  // test3
        public void LocationOrderHistory() // Broklyn has no order history result
        {
            //Arrange
            int y = 2;
            string result = "";
            // Act
            var BrooklynOrders = context.Orders.Where(x => x.LocationId == y).ToList();
            if (BrooklynOrders.Count < 1) result = "This location have no order history.";
            else  result = "This location has an order history";
            // Assert 
            Assert.Equal("This location have no order history.", result);
        }// end 

        [Theory] //test2
        [InlineData(1)]
        public void UserOrderHistory(int y)
        {
            //Arrange 
            y = 1;
            // Act 
            var orders = context.Orders.Where(x => x.UserId == y).ToList();
            // Assert
            Assert.Equal(1 , orders.Count());
        } // end

        // [Fact]// test1
        // public void CreateUser() // create a new user
        // {
        //     // Arrange
        //     var newUser = new P0DbContext.User();

        //         newUser.FisrtName = "Mark";
        //         newUser.LastName = "Moore";
        //         newUser.Email = "test@gmail.com";
        //         newUser.UserPassWord = "1234";
        //         context.Add(newUser); 
        //         context.SaveChanges();
        //     // Act 
        //         var registeredUser = context.Users.ToList().Where(x => x.Email == "m@gmail.com").FirstOrDefault().FisrtName;
        //     // Assert
        //     Assert.Equal("Mark",registeredUser);
        // } // end

        [Fact]// test1
        public void CheckForUserFirsName() // 
        {
            // Arrange
                string userFisrtName = "";
            // Act 
                userFisrtName = context.Users.ToList().FirstOrDefault().FisrtName;
            // Assert
            Assert.Equal("Sekou",userFisrtName);
        } // end

        [Fact]// test1
        public void CheckForUserLastName() // 
        {
            // Arrange
                string userLastName = "";
            // Act 
                userLastName = context.Users.ToList().FirstOrDefault().LastName;
            // Assert
            Assert.Equal("Dosso",userLastName);
        } // end

        [Fact]// test1
        public void CheckForUserEmail() // 
        {
            // Arrange
                string userEmail = "";
            // Act 
                userEmail = context.Users.ToList().FirstOrDefault().Email;
            // Assert
            Assert.Equal("s@",userEmail);
        } // end
        
        [Fact]// test1
        public void CheckForUserPassWordLength() // 
        {
            // Arrange
                var userPasswordLength = 0;
            // Act 
                userPasswordLength = context.Users.ToList().FirstOrDefault().UserPassWord.Length;
            // Assert
            Assert.True(userPasswordLength > 2, "Excepted userPasswordLength to be greater than 2.");
        } // end

        [Fact]// test1
        public void CheckForUseruniqueEmail() // 
        {
            // Arrange
                var user_email = "s@";
            // Act 
                var userEmailCount = context.Users.Where(x => x.Email == user_email).ToList();
            // Assert
            Assert.Equal(1, userEmailCount.Count());
        } // end
      
    }
}
