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
        public DefaultWay wayTDefaultWay;
        public GiveWay wayRGiveWay;
        public DefaultWay wayBDefaultWay;
        public GiveWay wayLGiveWay;

        public Intersection(string name)
        {
            this.name = name;
        }

        public void AddWay()
        {
            if (this.name == "2")
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
                this.wayRGiveWay = new GiveWay("right");
                this.wayLGiveWay = new GiveWay("left");
                this.wayTDefaultWay = new DefaultWay("top");
                this.wayBDefaultWay = new DefaultWay("bottom");
                
                this.Ways.Add(wayRGiveWay);
                this.Ways.Add(wayLGiveWay);  
                this.Ways.Add(wayTDefaultWay);
                this.Ways.Add(wayBDefaultWay); 
            }
        }
    }
}