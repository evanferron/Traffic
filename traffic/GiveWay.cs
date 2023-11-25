using System;
using System.Collections.Generic;

namespace traffic
{

    public class GiveWay : Way
    {

        public GiveWay(string _name) : base(_name){}
        public override bool GoThrought(Vehicle vehicle, Way leftWay, Way rightWay, Way infrontWay){
            if (this.thereIsPedestrian == true){
                Console.WriteLine("   -un piétion traverse le véhicule attend");
                return false;
            }
            if (PedestrianWhereVehiculeGo(leftWay,rightWay,infrontWay,vehicle)){
                Console.WriteLine("   -un piétion traverse la ou le véhicule veux aller donc le véhicule attend");
                return false;
            }
            if (vehicle.Departure == "left" && leftWay.Vehicles.Count == 0 && rightWay.Vehicles.Count == 0){
                return true;
            }
            if (vehicle.Departure == "right" && leftWay.Vehicles.Count == 0 && rightWay.Vehicles.Count == 0){
                return true;
            }
            if (vehicle.Departure == "top" && leftWay.Vehicles.Count == 0 && rightWay.Vehicles.Count == 0){
                return true;
            }
             if (vehicle.Departure == "bottom" && leftWay.Vehicles.Count == 0 && rightWay.Vehicles.Count == 0){
                return true;
            }
            Console.WriteLine("   -le véhicule attend son tour");
            return false;
        }
    }
}