using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunn_assignment4Dealership
{
    public class Dealership<T> : IEnumerable<T>
        where T : Vehicle
    {
        private List<T> vehicle { get; } = new List<T>();
        public List<T> Vehicles
        {
            get { return vehicle; }
        }
        public IEnumerator<T> GetEnumerator() => vehicle.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => vehicle.GetEnumerator();
        public void MakeNoises()
        {
            foreach (T vehicle in Vehicles)
            {
                vehicle.MakeNoise();
            }
        }
        public void DriveTheVehicles()
        {
            foreach (T vehicle in Vehicles)
            {
                vehicle.Drive();
            }
        }
        public Dealership<Truck> GetTrucks()
        {
            Dealership<Truck> truckDealership = new Dealership<Truck>();
            foreach (T vehicle in Vehicles)
            {
                if (vehicle is Truck)
                {
                    truckDealership.Vehicles.Add(vehicle as Truck);
                }
            }
            return truckDealership;
        }
    }
}
