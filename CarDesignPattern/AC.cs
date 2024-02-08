using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDesignPattern
{
    public class AC:ExtraFeatures
    {
        public AC(Car car) : base(car)
        {
        }

        public override void Features()
        {
            _features.Add("This car has Air Conditioner");
        }
    }
}
