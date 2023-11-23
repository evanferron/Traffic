using System;
using System.Collections.Generic;
using System.Linq;


namespace traffic
{
    public class Intersection
    {
        readonly string name;
        public List<Way> Ways = new List<Way>();

        public Way wayT;
        public Way wayR;
        public Way wayB;
        public Way wayL;

        public Intersection(string name)
        {
            this.name = name;
        }

        public void AddWay()
        {
            if (name == "traffic light")
            {

                Way wayT = new TrafficLight("top", 0);
                Way wayR = new TrafficLight("right", 1);
                Way wayB = new TrafficLight("bottom", 0);
                Way wayL = new TrafficLight("left", 1);

                this.Ways.Add(wayT);
                this.Ways.Add(wayR);
                this.Ways.Add(wayB);
                this.Ways.Add(wayL);
            }
            else
            {
                
            }

        }

    }
}