using System;

namespace traffic
{
    public class DefaultWay : Way
    {
        public DefaultWay(string _name) : base(_name){}
        public override bool GoThrought(Vehicle vehicle, Way leftWay, Way rightWay, Way infrontWay)
        {
            if (this.thereIsPedestrian == true){
                Console.WriteLine("   -un piétion traverse le véhicule attend");
                return false;
            }
            if (PedestrianWhereVehiculeGo(leftWay,rightWay,infrontWay,vehicle)){
                Console.WriteLine("   -un piétion traverse la ou le véhicule veux aller donc le véhicule attend");
                return false;
            }
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