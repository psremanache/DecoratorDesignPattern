using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDesignPattern
{
    public abstract class Car
    {
        public List<string> _features = null;
        public Car()
        {
            _features = new List<string>();

        }
        public abstract void Features(); 
        public void ShowFeatures()
        {
            foreach (var feature in _features)
            {
                Console.WriteLine(feature);
            }
        }
    }
}
