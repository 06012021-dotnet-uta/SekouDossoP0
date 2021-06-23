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
    }
}
