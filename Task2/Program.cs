using System.Reflection;

namespace Task2
{
    internal class Program
    {
        static void Main()
        {
            var company = new LeasingCompany();
            
            company.AddVehicle(new Passenger("BMW1", "X5", 2015, "Black", 100_000, "BG1234", 4_999, 5));
            company.AddVehicle(new Passenger("BMW2", "X5", 2015, "Black", 100_000, "BG1234", 3_999, 5));
            company.AddVehicle(new Cargo("Mercedes1", "Sprinter", 2018, "White", 150_000, "BG4321", 29_900, 2));
            company.AddVehicle(new Cargo("Mercedes2", "Sprinter", 2018, "White", 150_000, "BG4321", 28_900, 2));
            company.AddVehicle(new Cargo("BMW", "Sprinter", 2018, "Black", 150_000, "BG4321", 1, 2));
            company.AddVehicle(new Cargo("BMW", "Sprinter", 2018, "Black", 150_000, "BG4321", 1_000_001, 4));

            var vehiclesCloseToMaintanance = company.GetVehiclesCloseToMaintanance();
        }
    }
}