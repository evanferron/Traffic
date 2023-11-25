using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace traffic
{
    class  Traffic{

        public int Round = 0; 
        public  void RoundManagementTrafficLight(Intersection intersection){
            
            Pedestrian.PedestrianMove(intersection.Ways);
            int numOfCycle = 1;
            if (this.Round%2 == 0){
                intersection.wayT.ChangeLight();
                intersection.wayB.ChangeLight();
                intersection.wayL.ChangeLight();
                intersection.wayR.ChangeLight();
            } 
            foreach (TrafficLight element in intersection.Ways)
            {   
                
                Console.WriteLine();
                if (element.Light == TrafficLight.TrafficLightEnum.Red){
                     Console.WriteLine(numOfCycle.ToString() +" -le feux de la voie " + element.name + " est de couleur rouge, il y a " + element.Vehicles.Count.ToString()+" véhicules qui attendent leur tour");
                }
                if (element.Light == TrafficLight.TrafficLightEnum.Red2){
                     Console.WriteLine(numOfCycle.ToString() +" -le feux de la voie " + element.name + " est de couleur rouge, il y a " + element.Vehicles.Count.ToString()+" véhicules qui attendent leur tour" );
                }
                if (element.Light == TrafficLight.TrafficLightEnum.Orange){
                     Console.WriteLine(numOfCycle.ToString() +" -le feux de la voie " + element.name + " est de couleur orange, il y a " + element.Vehicles.Count.ToString()+" véhicules qui attendent leur tour" );
                }
                if (element.Light == TrafficLight.TrafficLightEnum.Green){
                     Console.WriteLine(numOfCycle.ToString() +" -le feux de la voie " + element.name + " est de couleur verte, il y a " + element.Vehicles.Count.ToString()+" véhicules qui attendent leur tour" );
                }
               

              
                var result  = Direction(element.name, intersection);
                Way leftWay  = result.Item1;
                Way rightWay = result.Item2;
                Way infrontWay = result.Item3;
                
                if (element.Vehicles.Count > 0)
                {

                    if(element.GoThrought(element.Vehicles[0], leftWay,rightWay,infrontWay))
                    {
                        element.Vehicles[0].advance();
                        
                        element.Vehicles.RemoveAt(0);
                     }
                }
                element.thereIsPedestrian = false;
                numOfCycle++;
                element.AddVehicle();     
            }
            this.Round ++ ;
            Console.WriteLine("___________________");
        }

        public  void RoundManagementGiveWay(Intersection intersection){
            int numOfCycle = 1;
            string type = "";
            Pedestrian.PedestrianMove(intersection.Ways);
            foreach (Way element in intersection.Ways)
            {   
                
                if (element.GetType().ToString() == "traffic.DefaultWay"){
                     type = "voie normal";
                } else {
                     type = "céder le passage";
                }
                Console.WriteLine();
                Console.WriteLine(numOfCycle.ToString() + " -Sur la voie " + element.name + " ( " + type + " )  il y a " + element.Vehicles.Count.ToString()+" véhicules qui attendent leur tour");
                var result  = Direction(element.name, intersection);
                Way leftWay  = result.Item1;
                Way rightWay = result.Item2;
                Way infrontWay = result.Item3;
                
                if (element.Vehicles.Count > 0)
                {

                    if(element.GoThrought(element.Vehicles[0], leftWay,rightWay,infrontWay))
                    {
                        element.Vehicles[0].advance();
                        
                        element.Vehicles.RemoveAt(0);
                     }
                }
                element.thereIsPedestrian = false;
                numOfCycle++; 
                element.AddVehicle();  
            }
            this.Round ++ ;
            Console.WriteLine("___________________"); 
        }

        public static (Way,Way,Way) Direction(string name, Intersection intersection ){
            Way leftWay  = null;
            Way rightWay = null;
            Way infrontWay = null;

            switch (name)
               {
                case "top":
                    leftWay= intersection.Ways.Find(p => p.name == "right");
                    rightWay= intersection.Ways.Find(p => p.name == "left");
                    infrontWay= intersection.Ways.Find(p => p.name == "bottom");
                    break;
                case "bottom":
                    leftWay= intersection.Ways.Find(p => p.name == "left");                        
                    rightWay= intersection.Ways.Find(p => p.name == "right");
                    infrontWay= intersection.Ways.Find(p => p.name == "top");
                    break;
                case "right":
                    leftWay= intersection.Ways.Find(p => p.name == "top");
                    rightWay= intersection.Ways.Find(p => p.name == "bottom");
                    infrontWay= intersection.Ways.Find(p => p.name == "left");
                    break;
                case "left":
                    leftWay= intersection.Ways.Find(p => p.name == "bottom");
                    rightWay= intersection.Ways.Find(p => p.name == "top");
                    infrontWay= intersection.Ways.Find(p => p.name == "right");
                    break;
            }
            return (leftWay,rightWay,infrontWay);
        }
    }
}