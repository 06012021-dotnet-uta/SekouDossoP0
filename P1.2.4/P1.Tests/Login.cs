// using Microsoft.EntityFrameworkCore;
// using RepositoryLayer;
// using System.Threading.Tasks;
// using System.Linq;
// using System;
// using Xunit;
// using ModelsLayer;
// //you can give the page an alias to differentiate between ambiguously named duos.
// using System.Collections.Generic;

// using BAccountService = BusinessLayer.AccountService;

// namespace P1.Tests
// {

// 	public class Login
// 	{
// 		//create the in-memory Db //  installed EF Core
// 			DbContextOptions<P1Db> options = new DbContextOptionsBuilder<P1Db>()
// 			.UseInMemoryDatabase(databaseName: "TestingDb")
// 			.Options;

// 		[Fact]
// 		public async Task LoginWithCorrectCredential()
// 		{
// 			// arrange
// 			//createa a user to inset into the inmemory db.
// 			Account account = new Account()
//             {
//                 UserName = "userName",
//                 UserPassWord = "userPassWord",
//             };
// 			User user = new User()
// 			{
// 				FirstName = "firstName",
// 				LastName = "lastName",
// 				Email = "email",
// 				UserPassWord = "userPassWord",
// 				UserName = "userName",
// 			};
// 			//bool result = false ;
// 			//List<Account> testAccount;
//             User user1;
//             Account account1;

// 			// act 
// 			using (var context = new P1Db(options))
// 			{
// 				context.Database.EnsureDeleted();// delete any Db fro a previous test
// 				context.Database.EnsureCreated();// create anew the Db... you will need ot seed it again.
// 				context.Users.Add(user);
//                 context.Accounts.Add(account);
// 				context.SaveChanges();
//                 user1 = context.Users.Where(x => x.UserName == "userName" && x.UserPassWord == "userPassWord").FirstOrDefault();
// 				account1 = context.Accounts.Where(x => x.UserName == "userName" && x.UserPassWord == "userPassWord").FirstOrDefault();
// 			}

// 			// act
// 			// add to the In-Memory Db
// 			//instantiate the inmemory db
// 			using (var context = new P1Db(options))
// 			{
// 				//verify that the db was deleted and created anew
// 				context.Database.EnsureDeleted();// delete any Db fro a previous test
// 				context.Database.EnsureCreated();// create anew the Db... you will need ot seed it again.

// 				//instantiate the BAccountService that we are going to unit test
// 				BAccountService bAccount = new BAccountService(context);
// 				bool result = await bAccount.LoginAsync(account);
// 				bool result1 = await bAccount.LoginAsync(account1);

// 				context.SaveChanges();
// 				//}

// 				//assert
// 				// verify the the result was as expected
	
// 				Assert.NotNull(user1);
//                 Assert.False(result);
// 				Assert.NotNull(account);
// 				Assert.NotNull(account1);
// 				//Assert.True(result1);

// 			}
// 		}
// 	}
// }
