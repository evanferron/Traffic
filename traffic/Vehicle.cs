using System;

namespace traffic{
    public class Vehicle
    {
        private string Departure {get;set;}
        private string Arrive{get;set;}
        private string Name {get;set;}

        public Vehicle(string Arrive, string Name){
            this.Arrive = Arrive;
            this.Name = Name;

        }


    }
}