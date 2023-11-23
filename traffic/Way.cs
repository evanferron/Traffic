using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace traffic
{

    public abstract class Way
    {
        public string name;
        public bool CanVehiculePass;
        public List<Vehicle> Vehicles = new List<Vehicle>();
        public List<Vehicle> WaitingsVehicles = new List<Vehicle>();



        public TrafficLight trafficLight;


        //public List<Pedestrian> Pedestrian; 

        public Way()
        {

        }

        public Way(string _name)
        {
            this.name = _name;

            Random aleatoire = new();
            int nbVehicle = aleatoire.Next(6);
            for (int i = 0; i <= nbVehicle; i++)
            {
                CreateVehicle();
            }
        }

        public void CreateVehicle()
        {
            Random aleatory = new();
            int intNumber = aleatory.Next(4);
            string arrive = "";
            if (intNumber == 0)
            {
                arrive = "top";
            }
            if (intNumber == 1)
            {
                arrive = "right";
            }
            if (intNumber == 2)
            {
                arrive = "bottom";
            }
            if (intNumber == 3)
            {
                arrive = "left";
            }
            // if car go where it come
            if (arrive == this.name)
            {
                arrive = "bottom";
                if (arrive == this.name)
                {
                    arrive = "left";
                }
            }

            Vehicle vehicle = new(arrive,this.name , "name");

            if (vehicle != null)
            {
                this.Vehicles.Add(vehicle);
            }

        }

        public abstract bool GoThrought(Vehicle vehicle, Way leftWay, Way rightWay, Way infrontWay);

        
    }
}