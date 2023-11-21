using System;

namespace traffic
{
    public class DefaultWay : Way
    {
        public override bool GoThrought(Vehicle vehicle, Way leftWay, Way rightWay, Way infrontWay)
        {
            if (vehicle.Departure == "left")
            {
                if (infrontWay.Vehicles.Count != 0)
                {
                    foreach (Vehicle veh in infrontWay.Vehicles)
                    {
                        if (veh.Arrive == vehicle.Departure)
                        {
                            WaitingsVehicles.Add(vehicle);
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}