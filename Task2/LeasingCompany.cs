using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class LeasingCompany
    {
        private readonly List<Vehicle> _vehiclesList = [];
        public List<Vehicle> GetVehicles()
        {
            return _vehiclesList;
        }
        public void AddVehicle(Vehicle vehicle)
        {
            _vehiclesList.Add(vehicle);
        }


        public List<Vehicle> GetExploitedVehicles()
        {
            return _vehiclesList.FindAll(vehicle => vehicle.Mileage > vehicle.MileageUntilExploited);
        }
        public double GetTotalFleetValue()
        {
            return 0;
        }
        public List<Vehicle> GetMatchingVehicles(string brand, string color)
        {
            return _vehiclesList;
        }
        public List<Vehicle> GetVehiclesCloseToMaintanance()
        {
            return _vehiclesList;
        }
    }
}
