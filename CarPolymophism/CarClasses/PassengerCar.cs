using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClasses
{
    public class PassengerCar : Car
    {
        public int PassangerCapacity { get; set; }
        public int CurrentPassenger { get; set; }

        public PassengerCar(int Number, double FuelCapacity, double FuelСonsumption, double Mileage, int PassangerCapacity)
            : base("Легковой",Number,FuelCapacity, FuelСonsumption, Mileage)
        {
            this.PassangerCapacity = PassangerCapacity;
        }

        public override void Ride(double distance)
        {
            Mileage += distance;
            FuelCapacity -= distance * FuelСonsumption;
        }

        public void GetPassengers(int peopleValue)
        {
            if (PassangerCapacity == CurrentPassenger)
            {
                return;
            }
            CurrentPassenger += peopleValue;
        }

        public void DropPassengers(int peopleValue)
        {
            if (CurrentPassenger == 0)
            {
                return;
            }
            CurrentPassenger += peopleValue;
        }
    }
}
