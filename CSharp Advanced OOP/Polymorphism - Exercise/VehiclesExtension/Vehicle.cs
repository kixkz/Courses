using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double tankCapacity, double fuelQuantity,double fuelConsumptionPerKm)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantity
        {
            get => FuelQuantity;
            private set
            {
                if (value > this.TankCapacity)
                {
                    FuelQuantity = 0;
                }
                else
                {
                    FuelQuantity = value;
                }
            }
        }

        public virtual double FuelConsumptionPerKm { get; protected set; }

        public double TankCapacity { get; private set; }

        public bool IsEmpty { get; set; }

        public bool CanDrive(double km) 
            => this.FuelQuantity - (km * this.FuelConsumptionPerKm) >= 0;

        public bool CanRefuel(double amount)
            => this.FuelQuantity + amount <= this.TankCapacity;

        public void Drive(double km)
        {
            if (CanDrive(km))
            {
                this.FuelQuantity -= (km * this.FuelConsumptionPerKm);
            }
        }

        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (CanRefuel(amount))
            {
                this.FuelQuantity += amount;
            }
            
        }
    }
}
