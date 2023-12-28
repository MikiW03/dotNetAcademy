﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Cargo(string brand, string model, int year, string color, decimal price, string registrationNumber, int mileage, string comfortClass) 
        :Vehicle(brand, model, year, color, price, registrationNumber, mileage, comfortClass)
    {
        public override int MileageUntilExploited { get; protected set; } = 1_000_000;
        public override int MileageUntilMaintanance { get; protected set; } = 15_000;
        public override int YearsUntilExploited { get; protected set; } = 15;
        public override int ValueDecreasePerYear { get; protected set; } = 7;

        public decimal GetRentalCosts(DateTime endOfRental, int distance, int weight)
        {
            return 0;
        }
    }
}
