using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using System.Threading.Tasks;
using System.Linq;
using System;
using Xunit;
using ModelsLayer;
//you can give the page an alias to differentiate between ambiguously named duos.

using BCartProduct  = BusinessLayer.CartProductService;


namespace P1.Tests
{

	public class AddProdutToCart
	{
		//create the in-memory Db //  installed EF Core
			DbContextOptions<P1Db> options = new DbContextOptionsBuilder<P1Db>()
			.UseInMemoryDatabase(databaseName: "TestingDb")
			.Options;

		[Fact]
		public async Task RegisterUserInsertsUserCorrectly()
		{
			// arrange
			Product p = new Product()
			{
				ProductName = "ProductName",
            	ProductDescription = "ProductDescription",
				ProductPrice = 10,
			};

			Cart c = new Cart(){ UserId = 2, };

			CartProduct cp = new CartProduct()
			{
				CartId = 1,
            	ProductId = 1,
			};

			bool result = false;
			//CartProduct test;

			using (var context = new P1Db(options))
			{
				context.Database.EnsureDeleted();// delete any Db fro a previous test
				context.Database.EnsureCreated();// create anew the Db... you will need ot seed it again.
				context.Products.Add(p);
				context.Carts.Add(c);
				context.CartProducts.Add(cp);
				context.SaveChanges();
				//test = context.CartProducts.Where(x => x.ProductId == 2).FirstOrDefault();
			}

			// act
			// add to the In-Memory Db
			//instantiate the inmemory db
			using (var context = new P1Db(options))
			{
				//verify that the db was deleted and created anew
				context.Database.EnsureDeleted();// delete any Db fro a previous test
				context.Database.EnsureCreated();// create anew the Db... you will need ot seed it again.

				//instantiate the RpsGameClass that we are going to unit test
				BCartProduct addP = new BCartProduct(context);
				result = await addP.AddProductAsync(p);

				context.SaveChanges();
				//}

				//assert
				// verify the the result was as expected

				Assert.NotNull(p);
				Assert.NotNull(c);
				Assert.NotNull(cp);
				Assert.True(result);
			}
		}
	}
}
