using System;

namespace traffic
{
    public class TrafficLight : Way
    {
        public TrafficLightEnum light;

        public TrafficLight(string _name, int color) : base(_name)
        {
            if (color == 0)
            {
                this.light = TrafficLightEnum.Green;
            }
            else
            {
                this.light = TrafficLightEnum.Red;
            }

        }

        public override bool GoThrought(Vehicle vehicle, Way leftWay, Way rightWay, Way infrontWay)
        {
            if (light == TrafficLightEnum.Red)
            {
                return false;
            }
            if (vehicle.Departure == "left")
            {
                if (infrontWay.Vehicles.Count != 0)
                {
                    foreach (Vehicle veh in infrontWay.Vehicles)
                    {
                        if (veh.Arrive == vehicle.Departure)
                        {
                            WaitingsVehicles.Add(vehicle);
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public void ChangeLight()
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