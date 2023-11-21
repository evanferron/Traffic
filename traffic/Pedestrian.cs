using System;
namespace traffic
{
    public class Pedestrian
    {
        public string Position = "null";
        public bool Walk = false;

        public void Move(){
            Random randomWalk = new Random();
            int isWalk = randomWalk.Next(0,9);
            if (isWalk == 0){
                this.Walk = true;
                
                Random randomPosition = new Random();
                int intPosition = randomPosition.Next(0,4);
                if (intPosition == 0){
                    this.Position = "up";
                }
                if (intPosition == 1){
                    this.Position = "right";
                }
                if (intPosition == 2){
                    this.Position = "bottom";
                }
                if (intPosition == 3){
                    this.Position = "left";
                }
            } 
        }

        public void Stop(){
            if (this.Walk == true){
                this.Walk = false;
                this.Position = "null";
            }
        }
    }
}