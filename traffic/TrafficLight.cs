using System;

namespace traffic
{
    public class TrafficLight : Way
    {
        private TrafficLightEnum light;
        private Timer timerLight
        {
            get; set;
        }

        public TrafficLight(TrafficLightEnum light)
        {
            this.light = light;

        }

        public override bool canVehiculeDrive(Way leftWay, Way rightWay)
        {
            if (light == TrafficLightEnum.Red)
            {
                return false;
            }
            return true;
        };

        public async void changeLight()
        {
            await while (true)
            {
                switch (light)
                {
                    case TrafficLightEnum.Orange:
                        value = new Timer(async _ => await light = TrafficLightEnum.Red, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
                        break;
                    case TrafficLightEnum.Red:
                        value = new Timer(async _ => await light = TrafficLightEnum.Green, null, TimeSpan.Zero, TimeSpan.FromSeconds(4));
                        break;
                    default:
                        value = new Timer(async _ => await light = TrafficLightEnum.Orange, null, TimeSpan.Zero, TimeSpan.FromSeconds(3));
                        break;

                }
            }
        }
    }

    enum TrafficLightEnum
    {
        Red,
        Orange,
        Green
    }
}