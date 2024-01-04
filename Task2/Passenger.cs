using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Passenger(string brand, string model, int year, string color, decimal price, string registrationNumber, int mileage, int comfortClass, double modelCoefficient)
        : Vehicle(brand, model, year, color, price, registrationNumber, mileage, comfortClass, modelCoefficient)
    {
        public override int MileageUntilExploited { get; protected set; } = 100_000;
        public override int MileageUntilMaintanance { get; protected set; } = 5_000;
        public override int YearsUntilExploited { get; protected set; } = 5;
        public override int ValueDecreasePerYear { get; protected set; } = 10;

        public decimal GetRentalCosts(DateTime endOfRental, int distance)
        {
            // ($1 for each hour started + $0.3 for each kilometer) * model coefficient * lessee's rating
            // in real life every user would probably have an account with his own rating, but for the sake of this task i will just assume that every user has the same rating
            return ((decimal)Math.Ceiling((endOfRental - DateTime.Now).TotalHours) + 0.3m * distance) * (decimal)ModelCoefficient * 1m;
        }
    }
}
