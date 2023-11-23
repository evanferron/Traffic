using System;

namespace traffic{
    public class Vehicle
    {
        public string Departure {get;set;}
        public string Arrive{get;set;}
        public string Name {get;set;}

        public Vehicle(string Arrive,string Departure, string Name){
            this.Arrive = Arrive;
            this.Departure=Departure;
            this.Name = Name;
        } 

        public void advance(){
            Console.WriteLine("le premier véicule de la vois de "+  this.Departure + " avance et va sur la vois " + this.Arrive);
        }

    }
}