using ePizzaDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaDelivery.Repositories.Interfaces
{
    public interface IOrderRepository:IRepository<Order>
    {
        IEnumerable<Order> GetUserOrders(int UserId);
    }
}
