using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDesignPattern
{
    public class MarutiSuzuki:Car
    {
        public override void Features()
        {
            _features.Add("This car has 4 wheels");
            _features.Add("THis car has green colors");
        }
    }
}
