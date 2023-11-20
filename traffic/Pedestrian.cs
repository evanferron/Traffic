using System;
namespace traffic
{
    class Pedestrian
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
                    this.Position = "nord";
                }
                if (intPosition == 1){
                    this.Position = "est";
                }
                if (intPosition == 2){
                    this.Position = "sud";
                }
                if (intPosition == 3){
                    this.Position = "ouest";
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