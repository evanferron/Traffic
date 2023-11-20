using System;
using System.Collections.Generic;

namespace traffic
{

    public abstract class Way
    {
        public bool canVehiculePass;
        public List<Vehicle> vehicles;
        public List<Pedestrian> pedestrian;
        public abstract bool canVehiculeDrive(Way leftWay, Way rightWay);
    }
}