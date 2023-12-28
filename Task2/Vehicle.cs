using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Vehicle(string brand, string model, int year, string color, decimal price, string registrationNumber)
    {
        public readonly Guid Id = Guid.NewGuid();
        public string Brand { get; set; } = brand;
        public string Model { get; set; } = model;
        public int Year { get; set; } = year;
        public string Color { get; set; } = color;
        public decimal Price { get; set; } = price;
        public string RegistrationNumber { get; set; } = registrationNumber;

        protected abstract int MileageUntilExploited { get; set; }
        protected abstract int MileageUntilMaintanance { get; set; }
        protected abstract int YearsUntilExploited { get; set; }
        protected abstract int ValueDecreasePerYear { get; set; }
    }
}