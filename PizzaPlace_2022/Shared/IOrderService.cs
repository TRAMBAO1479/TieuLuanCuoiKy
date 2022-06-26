using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace_2022.Shared {
    public interface IOrderService {
        ValueTask PlaceOrder(ShoppingBasket basket);
    }
}
