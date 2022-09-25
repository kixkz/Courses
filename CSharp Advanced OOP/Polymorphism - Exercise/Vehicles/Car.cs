﻿namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumptionPerKm) 
            : base(fuelQuantity, fuelConsumptionPerKm)
        {
        }

        public override double FuelConsumptionPerKm => base.FuelConsumptionPerKm + 0.9;
    }
}
