using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClasses
{
    abstract public class Car
    {
        public string Model { get; protected set; }
        public int Number { get; set; }
        public double FuelCapacity { get; set; }
        public double FuelСonsumption { get; set; }
        public double Mileage { get; set; }


        public virtual void Ride(double distance)
        {   
            
        }
        
    }
}
