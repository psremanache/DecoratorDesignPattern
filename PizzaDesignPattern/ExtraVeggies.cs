using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDesignPattern
{
    public class ExtraVeggies : Toppings
    {
        public BasePizza _basePizza { get; set; }
        public ExtraVeggies(BasePizza basePizza)
        {
            _basePizza = basePizza;
        }

        public override int Cost()
        {
            return _basePizza.Cost() + 40;
        }
    }
}
