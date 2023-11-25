using System;
using System.Collections.Generic;
namespace traffic
{
    public static class Pedestrian
    {
        public static void PedestrianMove(List<Way> listWay){
            Random randomWalk = new Random();
            int isWalk = randomWalk.Next(0,5);
            if (isWalk == 0){
                
                Random randomPosition = new Random();
                int intPosition = randomPosition.Next(0,4);
                listWay[intPosition].thereIsPedestrian = true;
            } 
        }
    }
}