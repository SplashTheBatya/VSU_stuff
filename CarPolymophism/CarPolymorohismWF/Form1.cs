using CarClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarPolymorohismWF
{

    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();

        }

        private void AddCarsBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewCars.RowCount - 1; i++)
            {
                if (dataGridViewCars[0, i].Value.ToString() == "Легковой")
                {
                    if (int.TryParse(dataGridViewCars[1, i].Value.ToString(), out int Number) &&
                        double.TryParse(dataGridViewCars[2, i].Value.ToString(), out double FuelCapacity) &&
                        double.TryParse(dataGridViewCars[3, i].Value.ToString(), out double FuelConsumption) &&
                        double.TryParse(dataGridViewCars[4, i].Value.ToString(), out double Miliage) &&
                        int.TryParse(dataGridViewCars[5, i].Value.ToString(), out int PassangerCappacity))
                    {
                        var car = new PassengerCar(Number, FuelCapacity, FuelConsumption, Miliage, PassangerCappacity);
                        cars.Add(car);
                    }
                    else
                    {
                        MessageBox.Show("Некорректные данные в строке " + dataGridViewCars[i, i].RowIndex.ToString());
                    }

                }
                else if (dataGridViewCars[0, i].Value.ToString() == "Грузовой")
                {
                    if (int.TryParse(dataGridViewCars[1, i].Value.ToString(), out int Number) &&
                        double.TryParse(dataGridViewCars[2, i].Value.ToString(), out double FuelCapacity) &&
                        double.TryParse(dataGridViewCars[3, i].Value.ToString(), out double FuelConsumption) &&
                        double.TryParse(dataGridViewCars[4, i].Value.ToString(), out double Miliage) &&
                        int.TryParse(dataGridViewCars[1, i].Value.ToString(), out int CarryingCapacity))
                    {
                        var car = new Truck(Number, FuelCapacity, FuelConsumption, Miliage, CarryingCapacity);
                        cars.Add(car);
                    }
                    else
                    {
                        MessageBox.Show("Некорректные данные в строке " + dataGridViewCars[i, i].OwningRow);
                    }
                }
                else
                {
                    MessageBox.Show("Модель не опознана в строке " + dataGridViewCars[0, i].RowIndex.ToString());
                }

            }
        }

        private void ShowInfoBtn_Click(object sender, EventArgs e)
        {   
            if(int.TryParse(NumberTxtBox.Text,out int needNum))
            {
                foreach(Car car in cars)
                {
                    if (car.Number == needNum)
                    {
                        if (car.Model == "Легковой")
                        {
                            PassengerCar PassCar = (PassengerCar)car;
                            richTextBox1.Text = $"Номер выбранного автомобиля: {PassCar.Number}\nЕго модель: {PassCar.Model}\nПробег: " +
                                $"{PassCar.Mileage}\nВместительность бака:  {PassCar.FuelCapacity} Расход бензина: {PassCar.FuelСonsumption}\nВместительность: " +
                                $"{PassCar.PassangerCapacity} пасажира\nТекущее кол-во пассажиров: {PassCar.CurrentPassenger}\n";
                           
                        }
                        else if (car.Model == "Грузовой")
                        {
                            Truck truck = (Truck)car;
                            richTextBox1.Text = $"Номер выбранного автомобиля: {truck.Number}\nЕго модель: {truck.Model}\nПробег: " +
                                $"{truck.Mileage}\nВместительность бака: {truck.FuelCapacity} Расход бензина: {truck.FuelСonsumption}\n Грузоподъёмность: " +
                                $"{truck.CarryingCapacity}\n Текущий груз: {truck.CurrentGoodsWeight}\n";
                            
                        }
                    }
                }
            }
           
        }
    }
}
