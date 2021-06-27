using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using System.Threading.Tasks;
using System.Linq;
using System;
using Xunit;
using ModelsLayer;
//you can give the page an alias to differentiate between ambiguously named duos.

using BRegister = BusinessLayer.Register;


namespace P1.Tests
{

	public class UnitTest1
	{
		//create the in-memory Db //  installed EF Core
			DbContextOptions<P1Db> options = new DbContextOptionsBuilder<P1Db>()
			.UseInMemoryDatabase(databaseName: "TestingDb")
			.Options;

		[Fact]
		public async Task RegisterUserInsertsUserCorrectly()
		{
			// arrange
			//createa a user to inset into the inmemory db.
			User user = new User()
			{

				FirstName = "FirstName",
				LastName = "LastName",
				Email = "Email",
				UserPassWord = "UserPassWord",
			};
			bool result = false;
			User user1;

			using (var context = new P1Db(options))
			{
				context.Database.EnsureDeleted();// delete any Db fro a previous test
				context.Database.EnsureCreated();// create anew the Db... you will need ot seed it again.
				context.Users.Add(user);
				context.SaveChanges();
				user1 = context.Users.Where(x => x.FirstName == "FirstName").FirstOrDefault();
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
				BRegister register = new BRegister(context);
				result = await register.RegisterUserAsync(user);

				context.SaveChanges();
				//}

				//assert
				// verify the the result was as expected
				//using (var context = new RpsGameDb(options))
				//{
				int allUsersInP1Db = await context.Users.CountAsync();
				user.UserId = 1;
				var u = context.Users.Where(x => x.FirstName == "FirstName").FirstOrDefault();
				Assert.True(result);
				Assert.Equal(1, allUsersInP1Db);
				Assert.NotNull(u);
				Assert.Equal(1, u.UserId);
				Assert.Contains(user1, context.Users);
				Assert.Equal(user1, u);
				Assert.Equal("LastName", user1.LastName);

			}
		}
	}
}
