using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Vehicle(string brand, string model, int year, string color, decimal price, string registrationNumber, int mileage, int comfortClass)
    {
        public readonly Guid Id = Guid.NewGuid();
        public string Brand { get; set; } = brand;
        public string Model { get; set; } = model;
        public int Year { get; set; } = year;
        public string Color { get; set; } = color;
        public decimal Price { get; set; } = price;
        public string RegistrationNumber { get; set; } = registrationNumber;
        public int Mileage { get; set; } = mileage;
        public int ComfortClass { get; set; } = comfortClass;

        public abstract int MileageUntilExploited { get; protected set; }
        public abstract int MileageUntilMaintanance { get; protected set; }
        public abstract int YearsUntilExploited { get; protected set; }
        public abstract int ValueDecreasePerYear { get; protected set; }
    }
}