using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDesignPattern
{
    public class BlueHeadLights:ExtraFeatures
    {
        public BlueHeadLights(Car car) : base(car)
        {
        }

        public override void Features()
        {
            _features.Add("This car has Blue Head Lights");
        }
    }
}
