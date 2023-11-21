using System;

namespace traffic
{
    public class TrafficLight : Way
    {
        public TrafficLightEnum light;
        
        // private Timer timerLight
        // {
        //     get; set;
        // }

        public TrafficLight(string _name, int color) : base(_name)
        {
            if (color == 0){
                this.light = TrafficLightEnum.Green;
            } else {
                this.light = TrafficLightEnum.Red;
            }

        }

        public override bool canVehiculeDrive(Way leftWay, Way rightWay)
        {
            if (light == TrafficLightEnum.Red)
            {
                return false;
            }
            return true;
        }

        public void changeLight()
        {
            switch (light)
            {
                case TrafficLightEnum.Orange:
                    light = TrafficLightEnum.Red;
                    break;
                case TrafficLightEnum.Red:
                    light = TrafficLightEnum.Green;
                    break;
                default:
                    light = TrafficLightEnum.Orange;
                    break;

            }
        }

        public enum TrafficLightEnum
    {
        Red,
        Orange,
        Green
    }

        // public async void changeLight()
        // {
        //     await while (true)
        //     {
        //         switch (light)
        //         {
        //             case TrafficLightEnum.Orange:
        //                 light = new Timer(async _ => await light = TrafficLightEnum.Red, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        //                 break;
        //             case TrafficLightEnum.Red:
        //                 light = new Timer(async _ => await light = TrafficLightEnum.Green, null, TimeSpan.Zero, TimeSpan.FromSeconds(4));
        //                 break;
        //             default:
        //                 light = new Timer(async _ => await light = TrafficLightEnum.Orange, null, TimeSpan.Zero, TimeSpan.FromSeconds(3));
        //                 break;

        //         }
        //     }
        // }
    }

    
}