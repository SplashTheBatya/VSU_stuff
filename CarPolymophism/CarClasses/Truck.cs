using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClasses
{
    public class Truck : Car
    {
        public double CarryingCapacity { get; set; }
        public double CurrentGoodsWeight { get; set; }

        public Truck(int Number, double FuelCapacity, double FuelСonsumption, double Mileage, double CarryingCapacity) 
           : base("Грузовой", Number, FuelCapacity, FuelСonsumption, Mileage)
        {
            this.CarryingCapacity = CarryingCapacity;
        }

        public override void Ride(double distance)
        {
            Mileage += distance;
            FuelCapacity -= distance * FuelСonsumption;
            DropGoods();

        }
        public void GetGoods(double goodsWeight)
        {
            if (CarryingCapacity == CurrentGoodsWeight)
            {
                return;
            }
            CurrentGoodsWeight += goodsWeight;
        }
        public void DropGoods()
        {
            if (CurrentGoodsWeight == 0)
            {
                return;
            }
            CurrentGoodsWeight = 0;
        }


    }
}