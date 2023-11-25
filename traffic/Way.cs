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

        public bool thereIsPedestrian; 

        public Way(){}

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
        public void AddVehicle(){
            Random randomWalk = new Random();
            int isWalk = randomWalk.Next(0,5);
            if (isWalk == 0){
                this.CreateVehicle();
                Console.WriteLine("   -un véhicule arrive sur la file d'attente de la voie " + this.name);
            }
        }

        public abstract bool GoThrought(Vehicle vehicle, Way leftWay, Way rightWay, Way infrontWay);

        public bool PedestrianWhereVehiculeGo(Way way1, Way way2, Way way3, Vehicle car){
            if (way1.name == car.Arrive && way1.thereIsPedestrian == true){
                return true;
            }
            if (way2.name == car.Arrive && way2.thereIsPedestrian == true){
                return true;
            }
            if (way3.name == car.Arrive && way3.thereIsPedestrian == true){
                return true;
            }
            return false;
        } 
    }
}