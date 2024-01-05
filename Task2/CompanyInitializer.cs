using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Diagnostics.Metrics;

namespace Task2
{
    static class CompanyInitializer
    {
        public static LeasingCompany InitSampleCompany()
        {
            var leasingCompany = new LeasingCompany();

            string filePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\")) + @"data\leasingCompany.json";
            string passengerJson = File.ReadAllText(filePath);
            var passenger = JsonConvert.DeserializeObject<List<Passenger>>(passengerJson);
            foreach (var passengerVehicle in passenger)
            {
                leasingCompany.AddVehicle(passengerVehicle);
            }

            string filePath2 = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\..\")) + @"data\leasingCompany2.json";
            string cargoJson = File.ReadAllText(filePath2);
            var cargo = JsonConvert.DeserializeObject<List<Cargo>>(cargoJson);
            foreach (var cargoVehicle in cargo)
            {
                leasingCompany.AddVehicle(cargoVehicle);
            }

            return leasingCompany;
        }
    }
}
