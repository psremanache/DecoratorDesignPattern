using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDesignPattern
{
    public class WheatPizzaBase : BasePizza
    {
        public override int Cost()
        {
            return 60;
        }
    }
}
