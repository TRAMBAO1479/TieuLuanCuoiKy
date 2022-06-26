using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace_2022.Shared {
    public class Menu {
        public List<Pizza> Pizzas { get; set; }
            = new List<Pizza>();
        public void Add(Pizza pizza)
            => Pizzas.Add(pizza);
        public Pizza? GetPizza(int id)
            => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
    }
}
