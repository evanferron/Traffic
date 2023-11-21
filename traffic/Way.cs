using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace traffic
{

    public abstract  class Way
    {
        public bool CanVehiculePass;
        public List<Vehicle> Vehicles  = new List<Vehicle>();
        //public List<Pedestrian> Pedestrian; 

        public Way(){
            Random aleatoire = new();
            int entierUnChiffre = aleatoire.Next(5);
            for(int i=0 ; i<=entierUnChiffre; i++){
                CreateVehicle();
            }
        }
        enum Season
        {
        right = 2,
        center = 1,
        left= 0,
}

        public void CreateVehicle(){
            Random aleatoire = new();
            int entierUnChiffre = aleatoire.Next(1);
            string Arrive  = ((Season)entierUnChiffre).ToString();
            Vehicle vehicle =new(Arrive,"name");
            if (vehicle!= null){
                this.Vehicles.Add(vehicle);
            }
        }

        public abstract bool canVehiculeDrive(Way leftWay, Way rightWay);
    }
}