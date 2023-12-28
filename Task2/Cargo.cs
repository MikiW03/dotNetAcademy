using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Cargo(string brand, string model, int year, string color, decimal price, string registrationNumber) 
        :Vehicle(brand, model, year, color, price, registrationNumber)
    {
        protected override int MileageUntilExploited { get; set; } = 1_000_000;
        protected override int MileageUntilMaintanance { get; set; } = 15_000;
        protected override int YearsUntilExploited { get; set; } = 15;
        protected override int ValueDecreasePerYear { get; set; } = 7;

        public decimal GetRentalCosts(DateTime endOfRental, int distance, int weight)
        {
            return 0;
        }
    }
}
