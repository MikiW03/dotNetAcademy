using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Passenger(string brand, string model, int year, string color, decimal price, string registrationNumber) 
        :Vehicle(brand, model, year, color, price, registrationNumber)
    {
        protected override int MileageUntilExploited { get; set; } = 100_000;
        protected override int MileageUntilMaintanance { get; set; } = 5_000;
        protected override int YearsUntilExploited { get; set; } = 5;
        protected override int ValueDecreasePerYear { get; set; } = 10;

        public decimal GetRentalCosts(DateTime endOfRental, int distance)
        {
            return 0;
        }
    }
}
