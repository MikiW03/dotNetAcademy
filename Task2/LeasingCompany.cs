using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        public bool RemoveVehicle(int number)
        {
            var isCompleted = _vehiclesList.Remove(_vehiclesList.Find(v => v.Number == number));
            return isCompleted;
        }
        public Vehicle? GetVehicle(int number)
        {
            return _vehiclesList.Find(vehicle => vehicle.Number == number);
        }
        public List<Vehicle> GetExploitedVehicles()
        {
            return _vehiclesList.FindAll(vehicle => vehicle.Mileage > vehicle.MileageUntilExploited
            || (DateTime.Now.Year - vehicle.Year) > vehicle.YearsUntilExploited);
        }
        public decimal GetTotalFleetValue()
        {
            return _vehiclesList.Sum(vehicle => vehicle.Price * (decimal)Math.Pow(1 - (double)vehicle.ValueDecreasePerYear / 100, DateTime.Now.Year - vehicle.Year));
        }
        public List<Vehicle> GetMatchingVehicles(string brand)
        {
            return _vehiclesList
                .FindAll(vehicle => vehicle.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public List<Vehicle> GetMatchingVehicles(string brand, string color)
        {
            return _vehiclesList
                .FindAll(vehicle => vehicle.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase) && vehicle.Color.Equals(color, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(vehicle => vehicle.ComfortClass)
                .ToList();
        }
        public List<Vehicle> GetVehiclesCloseToMaintanance()
        {
            return _vehiclesList
                .FindAll(vehicle => vehicle.Mileage % vehicle.MileageUntilMaintanance > vehicle.MileageUntilMaintanance - 1000);
        }
    }
}
