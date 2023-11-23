using System;
using System.Collections.Generic;
using System.Linq;


namespace traffic
{
    public class Intersection
    {
        readonly string name;
        public List<Way> Ways = new List<Way>();

// pour l'intersection feux
        public TrafficLight wayT;
        public TrafficLight wayR;
        public TrafficLight wayB;
        public TrafficLight wayL;

// pour l'intersection céder le passage
        public GiveWay wayTGiveWay;
        public GiveWay wayRGiveWay;
        public GiveWay wayBGiveWay;
        public GiveWay wayLGiveWay;

        public Intersection(string name)
        {
            this.name = name;
        }

        public void AddWay()
        {
            if (name == "traffic light")
            {

                this.wayT = new TrafficLight("top", 0);
                this.wayR = new TrafficLight("right", 1);
                this.wayB = new TrafficLight("bottom", 0);
                this.wayL = new TrafficLight("left", 1);

                this.Ways.Add(wayT);
                this.Ways.Add(wayR);
                this.Ways.Add(wayB);
                this.Ways.Add(wayL);
            }
            else
            {
                this.wayTGiveWay = new GiveWay("top");
                this.wayRGiveWay = new GiveWay("right");
                this.wayBGiveWay = new GiveWay("bottom");
                this.wayLGiveWay = new GiveWay("left");

                this.Ways.Add(wayTGiveWay);
                this.Ways.Add(wayRGiveWay);
                this.Ways.Add(wayBGiveWay);
                this.Ways.Add(wayLGiveWay);  
            }
        }
    }
}