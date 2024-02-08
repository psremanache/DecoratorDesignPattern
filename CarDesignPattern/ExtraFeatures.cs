using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDesignPattern
{
    public abstract class ExtraFeatures:Car
    {
        public Car _car = null;
        public ExtraFeatures(Car car)
        {
            _car = car;
        }
        
    }
}
