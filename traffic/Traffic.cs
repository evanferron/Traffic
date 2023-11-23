using System;
using System.Collections.Generic;

namespace traffic
{
    class  Traffic{

        public int Round = 0; 
        public  void RoundManagement(Intersection intersection){
            this.Round ++ ;
            foreach (Way element in intersection.Ways)
            {
                var result  = Direction(element.name, intersection);
                Way leftWay  = result.Item1;
                Way rightWay = result.Item2;
                Way infrontWay = result.Item3;
                if(element.GoThrought(element.Vehicles[0], leftWay,rightWay,infrontWay)){
                    element.Vehicles[0].advance();
                    if (element.Vehicles.Count > 0)
                    {
                        element.Vehicles.RemoveAt(0);
                        Console.WriteLine("Le premier élément a été retiré.");
                    }
                }

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