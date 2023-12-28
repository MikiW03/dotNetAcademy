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
        public decimal GetTotalFleetValue()
        {
            return _vehiclesList.Sum(vehicle => vehicle.Price);
        }
        public List<Vehicle> GetMatchingVehicles(string brand, string color)
        {
            return _vehiclesList
                .FindAll(vehicle => vehicle.Brand == brand && vehicle.Color == color)
                .OrderByDescending(vehicle => vehicle.ComfortClass)
                .ToList();
        }
        public List<Vehicle> GetVehiclesCloseToMaintanance()
        {
            return _vehiclesList;
        }
    }
}
