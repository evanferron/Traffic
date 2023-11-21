using System;

namespace traffic{
    public class Vehicle
    {
        public string Departure {get;set;}
        public string Arrive{get;set;}
        public string Name {get;set;}

        public Vehicle(string Arrive, string Name){
            this.Arrive = Arrive;
            this.Name = Name;

        }


    }
}