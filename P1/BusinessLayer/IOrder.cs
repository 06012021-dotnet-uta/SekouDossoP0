using ModelsLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IOrder
    {
        Task<bool> CreateOrderAsync(Order order);
        Task<List<Order>> OrderListAsync();
        Task<List<Location>> LocationOrderListAsync();
        Task<List<User>> UserOrderListAsync();
        Task<List<OrderProduct>> OrderProductListAsync(); // orderProduct list
        Task<List<Product>> ProductListAsync(); // Product list
    }
}
