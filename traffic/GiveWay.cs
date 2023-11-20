using System;
using System.Collections.Generic;

namespace traffic
{

    public class GiveWay
    {
        public bool GoThrought(Vehicle vehicle, Way leftWay, Way rightWay){
            if (vehicle.Departure == "left" && leftWay.vehicles.Count == 0 && rightWay.vehicles.Count == 0){
                return true;
            }
            if (vehicle.Departure == "right" && leftWay.vehicles.Count == 0 ){
                return true;
            }
            return false;
        }
    }
}