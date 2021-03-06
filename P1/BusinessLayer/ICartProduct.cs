using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface ICartProduct
    {
        Task<bool> AddProductAsync(Product p);
        Task<List<CartProduct>> CartProductsAsync();
        Task<List<CartProduct>> ListOfCartProductsAsync();

        Task<List<Product>> ListOfProductsAsync();  // product list
        Task<bool> CheckoutAsync(); // checkout and empty cart
     
    }
}