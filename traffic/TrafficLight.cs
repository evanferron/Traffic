using System;

namespace traffic
{
    public class TrafficLight : Way
    {
        public TrafficLightEnum Light;

        public TrafficLight(string _name, int color) : base(_name)
        {   
            if (color == 0)
            {
                this.Light = TrafficLightEnum.Green;
                
            }
            else
            {
                this.Light = TrafficLightEnum.Red;
            }

        }

        public override bool GoThrought(Vehicle vehicle, Way leftWay, Way rightWay, Way infrontWay)
        {
            if (this.thereIsPedestrian == true){
                Console.WriteLine("   -un piétion traverse le véhicule attend");
                return false;
            }
            if (PedestrianWhereVehiculeGo(leftWay,rightWay,infrontWay,vehicle)){
                Console.WriteLine("   -un piétion traverse la ou le véhicule veux aller donc le véhicule attend");
                return false;
            }
            if (this.Light == TrafficLightEnum.Red || this.Light == TrafficLightEnum.Red2)
            {
                return false; 
            }
            return true;
        }

        public void ChangeLight()
        {
            switch (this.Light)
            {
                case TrafficLightEnum.Orange:
                    this.Light = TrafficLightEnum.Red;
                    break;
                case TrafficLightEnum.Red:
                    this.Light = TrafficLightEnum.Red2;
                    break;
                case TrafficLightEnum.Red2:
                    this.Light = TrafficLightEnum.Green;
                    break;
                default:
                    this.Light = TrafficLightEnum.Orange;
                    break;

            }
        }

        public enum TrafficLightEnum
        {
            Red,

            Red2,
            Orange,
            Green
        }
    }
}