using ePizzaDelivery.Entities;
using ePizzaDelivery.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaDelivery.Repositories.Implementations
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        private AppDbContext appContext
        {
            get
            {
                return _dbContext as AppDbContext;
            }
        }
        public CartRepository(DbContext dbContext) : base(dbContext)
        {

        }
        public Cart GetCart(Guid CartId)
        {
            return appContext.Carts.Include("Items").Where(c => c.Id == CartId && c.IsActive == true).FirstOrDefault();
        }
        public int DeleteItem(Guid cartId, int itemId)
        {
            var item = appContext.CartItems.Where(ci => ci.CartId == cartId && ci.Id == itemId).FirstOrDefault();
            if (item != null)
            {
                appContext.CartItems.Remove(item);
                return appContext.SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public int UpdateQuantiy(Guid CartId, int itemId, int quantity)
        {
            bool flag = false;
            var cart = GetCart(CartId);
            if (cart != null)
            {
                for (int i = 0; i < cart.Items.Count; i++)
                {
                    if (cart.Items[i].Id == itemId)
                    {
                        flag = true;
                        if (quantity < 0 && cart.Items[i].Quantity > 1)
                            cart.Items[i].Quantity += quantity;
                        else if (quantity > 0)
                            cart.Items[i].Quantity += quantity;
                        break;
                    }
                }
                if (flag)
                    return appContext.SaveChanges();

            }
            return 0;

        }

        public int UpdateCart(Guid CartId, int userId)
        {
            Cart cart = GetCart(CartId);
            cart.UserId = userId;
            return appContext.SaveChanges();

        }
    }
}
