using System;
using System.Collections.Generic;

namespace traffic
{

    public class GiveWay : Way
    {

        public GiveWay(string _name) : base(_name){}
        public override bool GoThrought(Vehicle vehicle, Way leftWay, Way rightWay, Way infrontWay){
            if (vehicle.Departure == "left" && leftWay.Vehicles.Count == 0 && rightWay.Vehicles.Count == 0){
                return true;
            }
            if (vehicle.Departure == "right" && leftWay.Vehicles.Count == 0 ){
                return true;
            }
            return false;
        }
    }
}