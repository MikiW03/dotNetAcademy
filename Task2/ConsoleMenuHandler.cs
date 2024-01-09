using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ConsoleMenuHandler
    {
        private readonly ConsoleInputHandler _inputHandler = new();

        public void HandleUserInput()
        {
            var company = CompanyInitializer.InitSampleCompany();
            Console.WriteLine("Welcome in our leasing company!");

            var exit = false;
            while(!exit)
            {
                var operation = GetOperation();
                exit = !HandleOperation(operation, company);
            }
        }

        private Operation GetOperation() 
        {
            PrintMenu();
            var input = _inputHandler.GetIntFromConsole("Chose one option: ");

            if(!Enum.IsDefined(typeof(Operation), input))
            {
                Console.WriteLine("This option is not in the menu! Try another");
                return GetOperation();
            } 

            return (Operation)input;
        }

        private bool HandleOperation(Operation operation, LeasingCompany company)
        {
            switch (operation)
            {
                case Operation.Quit:
                    {
                        Console.WriteLine("Goodbye!");
                        return false;
                    }

                case Operation.AllVehicles:
                    {
                        var vehicles = company.GetVehicles();
                        if (vehicles.Count <= 0)
                        {
                            Console.WriteLine("We have no available vehicles right now. Try another time");
                            break;
                        }
                        Console.WriteLine("Here is a list of all vehicles:");
                        vehicles.ForEach(v => Console.WriteLine(v));
                        break;
                    }

                case Operation.VehiclesOfSpecificBrand:
                    {
                        Console.Write("Type in a brand: ");
                        var brand = Console.ReadLine();

                        var vehicles = company.GetMatchingVehicles(brand);
                        if (vehicles.Count <= 0)
                        {
                            Console.WriteLine("There are no vehicles meeting your criteria");
                            break;
                        }
                        vehicles.ForEach(vehicle => Console.WriteLine(vehicle));
                        break;
                    }

                case Operation.VehiclesOfSpecificBrandAndColor:
                    {
                        Console.Write("Type in a brand: ");
                        var brand = Console.ReadLine();

                        Console.Write("Type in a color: ");
                        var color = Console.ReadLine();

                        var vehicles = company.GetMatchingVehicles(brand, color);
                        if(vehicles.Count <= 0)
                        {
                            Console.WriteLine("There are no vehicles meeting your criteria");
                            break;
                        }

                        Console.WriteLine("Here is a list of matching vehicles");
                        vehicles.ForEach(vehicle => Console.WriteLine(vehicle));
                        break;
                    }

                case Operation.ExploitedVehicles:
                    {
                        var vehicles = company.GetExploitedVehicles();
                        if (vehicles.Count <= 0)
                        {
                            Console.WriteLine("There are no vehicles meeting your criteria");
                            break;
                        }

                        Console.WriteLine("Here is a list of exploited vehicles:");
                        vehicles.ForEach(v => Console.WriteLine(v));
                        break;
                    }

                case Operation.TotalFleetValue:
                    {
                        Console.WriteLine($"Total fleet value is: ${company.GetTotalFleetValue():F2}");
                        break;
                    }

                case Operation.VehiclesCloseToMaintanance:
                    {
                        var vehicles = company.GetVehiclesCloseToMaintanance();
                        if (vehicles.Count <= 0)
                        {
                            Console.WriteLine("There are no vehicles close to maintanance");
                            break;
                        }

                        Console.WriteLine("Here is a list of vehicles close to maintanance:");
                        vehicles.ForEach(v => Console.WriteLine(v));
                        break;
                    }

                case Operation.RentVehicle:
                    {
                        var number = _inputHandler.GetIntFromConsole("Enter the number of the vehicle you want to rent: ");
                        var vehicle = company.GetVehicle(number);
                        if (vehicle == null)
                        {
                            Console.WriteLine("There is no available vehicle with this number!");
                            break;
                        }

                        Console.WriteLine("Your vehicle: ");
                        Console.WriteLine(vehicle);

                        if (vehicle is Passenger passengerVehicle)
                        {
                            var date = _inputHandler.GetFutureDateFromConsole("Enter the end date of the rental (MM/DD/YYYY): ");
                            var distance = _inputHandler.GetPositiveIntFromConsole("Enter the distance of your travel (km): ");

                            var cost = passengerVehicle.GetRentalCosts(date, distance);
                            Console.WriteLine($"The cost of your rental is: ${cost:F2}");
                            break;
                        }
                        else if (vehicle is Cargo cargoVehicle)
                        {
                            var date = _inputHandler.GetFutureDateFromConsole("Enter the end date of the rental (MM/DD/YYYY): ");
                            var distance = _inputHandler.GetPositiveIntFromConsole("Enter the distance of your travel (km): ");
                            var weight = _inputHandler.GetPositiveIntFromConsole("Enter a weight of your loading: ");

                            var cost = cargoVehicle.GetRentalCosts(date, distance, weight);
                            Console.WriteLine($"The cost of your rental is: ${cost:F2}");
                            break;
                        }
                        break;
                    }

                default:
                    break;
            }
            return true;
        }

        private void PrintMenu()
        {
            Console.WriteLine("""
            ----------------------------------------
            0 - Quit
            1 - See all vehicles
            2 - See vehicles of a specific brand
            3 - See vehicles of a specific brand and color
            4 - See exploited vehicles
            5 - See a total fleet value
            6 - See vehicles close to maintanance
            7 - Rent a vehicle
            ----------------------------------------
            """);
        }
    }
}
