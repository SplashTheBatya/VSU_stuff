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

        public Car(string Model,int Number,double FuelCapacity,double FuelСonsumption, double Mileage)
        {
            this.Model = Model;
            this.Number = Number;
            this.FuelCapacity = FuelCapacity;
            this.FuelСonsumption = FuelСonsumption;
            this.Mileage = Mileage;
        }


        public virtual void Ride(double distance)
        {   
            
        }
        
    }
}
