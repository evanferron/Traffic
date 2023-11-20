using System;

namespace traffic{
    class Vehicle
    {
        private Way Departure {get;set;}
        private Way Arrive{get;set;}
        private string Name {get;set;}

        public Vehicle(Way Arrive, Way Departure, string Name){
            this.Arrive = Arrive;
            this.Departure = Departure;
            this.Name = Name;

        }

        
    }
}