using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Vehicle(string brand, string model, int year, string color, decimal price, string registrationNumber, int mileage, int comfortClass, double modelCoefficient)
    {
        private static int counter = 0;

        public readonly Guid Id = Guid.NewGuid();
        public readonly int Number = counter++;
        public string Brand { get; set; } = brand;
        public string Model { get; set; } = model;
        public int Year { get; set; } = year;
        public string Color { get; set; } = color;
        public decimal Price { get; set; } = price;
        public string RegistrationNumber { get; set; } = registrationNumber;
        public int Mileage { get; set; } = mileage;
        public int ComfortClass { get; set; } = comfortClass;
        public double ModelCoefficient { get; set; } = modelCoefficient;

        public abstract int MileageUntilExploited { get; protected set; }
        public abstract int MileageUntilMaintanance { get; protected set; }
        public abstract int YearsUntilExploited { get; protected set; }
        public abstract int ValueDecreasePerYear { get; protected set; }


        public override string ToString()
        {
            var type = GetType().Name;
            return String.Format($"""
            No.{Number}
            Type: {type}
            Brand: {Brand}
            Model: {Model}
            Year of Manufacture: {Year}
            Color: {Color}
            Price: {Price}
            Registration Number: {RegistrationNumber}
            Mileage: {Mileage}
            Comfort Class: {ComfortClass}
            Model Coefficient: {ModelCoefficient}{Environment.NewLine}
            """);
        }
    }
}