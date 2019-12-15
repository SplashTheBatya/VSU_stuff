using CarClasses;
using System;
using System.Collections.Generic;

namespace CarPolymophism
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            int iter;
            bool numberCheck = true;
            do
            {
                Console.WriteLine("Выберите:\n1 - добавить легковой автомобиль\n2 - добавить грузовой автомобиль\n3 - выбрать автомобиль из списка автомобилей\n4 - выйти");
                bool iterSuccess = int.TryParse(Console.ReadLine(), out iter);
                switch (iter)
                {
                    case 1:
                        Console.WriteLine("Введите номер: ");
                        numberCheck= true;
                        bool numberSuccess = int.TryParse(Console.ReadLine(), out int number);
                        for (int i = 0; i < cars.Count; i++)
                        {
                            if (cars[i].Number == number)
                            {
                                numberCheck = false;
                                Console.WriteLine("Автомобиль с таким номером существует, попробуйте снова ");
                                break;
                            }
                        }
                        if (!numberCheck) { break; }
                        Console.WriteLine("Введите ёмкость бензобака: ");
                        bool fuelCapacitySuccess = double.TryParse(Console.ReadLine(), out double fuelCappacity);
                        Console.WriteLine("Введите расход бензина: ");
                        bool fuelСonsumptionSuccess = double.TryParse(Console.ReadLine(), out double fuelCunsumption);
                        Console.WriteLine("Введите пробег: ");
                        bool mileageSuccess = double.TryParse(Console.ReadLine(), out double Mileage);
                        Console.WriteLine("Введите колличество мест: ");
                        bool passangerCapacitySuccess = int.TryParse(Console.ReadLine(), out int passangerCapacity);
                        if (numberSuccess && fuelCapacitySuccess && fuelСonsumptionSuccess
                            && mileageSuccess && passangerCapacitySuccess)
                        {
                            var passCar = new PassengerCar(number, fuelCappacity,
                                fuelCunsumption, Mileage, passangerCapacity);
                            cars.Add(passCar);
                            break;
                        }
                        else { break; }


                    case 2:
                        numberCheck = true;
                        Console.WriteLine("Введите номер: ");
                        bool truckNumSuccess = int.TryParse(Console.ReadLine(), out int truckNum);
                        for (int i = 0; i < cars.Count; i++)
                        {
                            if (cars[i].Number == truckNum)
                            {
                                numberCheck = false;
                                Console.WriteLine("Автомобиль с таким номером существует, попробуйте снова ");

                               
                            }
                        }
                        if (!numberCheck) { break; }
                        Console.WriteLine("Введите ёмкость бензобака: ");
                        bool truckFuelCapacitySuccess = double.TryParse(Console.ReadLine(), out double truckFuelCapacity);
                        Console.WriteLine("Введите расход бензина: ");
                        bool truckFuelСonsumptionSuccess = double.TryParse(Console.ReadLine(), out double truckFuelСonsumption);
                        Console.WriteLine("Введите пробег: ");
                        bool truckMileageSuccess = double.TryParse(Console.ReadLine(), out double truckMileage);
                        Console.WriteLine("Введите грузоподъёмность: ");
                        bool carryingCapacitySuccess = int.TryParse(Console.ReadLine(), out int carryingCapacity);
                        if (truckNumSuccess && truckFuelCapacitySuccess && truckFuelСonsumptionSuccess
                            && truckMileageSuccess && carryingCapacitySuccess)
                        {
                            var truckCar = new Truck(truckNum, truckFuelCapacity,
                                truckFuelСonsumption, truckMileage, carryingCapacity);
                            cars.Add(truckCar);
                            break;
                        }
                        else { break; }

                    case 3:
                        Console.WriteLine("Введите номер нужного автомобиля: ");
                        bool numSuccess = int.TryParse(Console.ReadLine(), out int needNum);
                        if (numSuccess)
                        {
                            for (int i = 0; i < cars.Count; i++)
                            {
                                if (cars[i].Number == needNum)
                                {
                                    if (cars[i].Model == "Легковой")
                                    {
                                        PassengerCar car = (PassengerCar)cars[i];
                                        Console.WriteLine($"Номер выбранного автомобиля: {car.Number}\nЕго модель: {car.Model}\nПробег: " +
                                            $"{car.Mileage}\nВместительность бака:  {car.FuelCapacity} Расход бензина: {car.FuelСonsumption}\nВместительность: " +
                                            $"{car.PassangerCapacity} пасажира\nТекущее кол-во пассажиров: {car.CurrentPassenger}\n");
                                        break;
                                    }
                                    else if (cars[i].Model == "Грузовой")
                                    {
                                        Truck car = (Truck)cars[i];
                                        Console.WriteLine($"Номер выбранного автомобиля: {car.Number}\nЕго модель: {car.Model}\nПробег: " +
                                            $"{car.Mileage}\nВместительность бака: {car.FuelCapacity} Расход бензина: {car.FuelСonsumption}\n Грузоподъёмность: " +
                                            $"{car.CarryingCapacity}\n Текущий груз: {car.CurrentGoodsWeight}\n");
                                        break;
                                    }
                                }
                            }
                        }

                        break;
                }
            } while (iter != 4);
        }
    }
}
