using ePizzaDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaDelivery.Repositories.Interfaces
{
    public interface ICartRepository:IRepository<Cart>
    {
        Cart GetCart(Guid CartId);
        int DeleteItem(Guid CartId,int itemId);
        int UpdateQuantiy(Guid CartId,int itemId,int quantity);
        int UpdateCart(Guid CartId,int userId);

    }
}
