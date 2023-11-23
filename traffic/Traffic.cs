using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace traffic
{
    class  Traffic{

        public int Round = 0; 
        public  void RoundManagementTrafficLight(Intersection intersection){
            this.Round ++ ;
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
                     Console.WriteLine("le feux de la voie " + element.name + " est de couleur rouge" );
                }
                if (element.Light == TrafficLight.TrafficLightEnum.Red2){
                     Console.WriteLine("le feux de la voie " + element.name + " est de couleur rouge" );
                }
                if (element.Light == TrafficLight.TrafficLightEnum.Orange){
                     Console.WriteLine("le feux de la voie " + element.name + " est de couleur orange" );
                }
                if (element.Light == TrafficLight.TrafficLightEnum.Green){
                     Console.WriteLine("le feux de la voie " + element.name + " est de couleur verte" );
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
                element.AddVehicle();
            }
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