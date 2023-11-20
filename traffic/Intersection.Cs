using Programme;

namespace traffic
{
    public class Intersection
    {
        readonly string name;
        public Way[] ways { get; set; };

        public Intersection(string name)
        {
            this.name = name;
        }

        public void AddWay(Way way)
        {
            List<Way> LWays = ways.ToList();
            LWays.Add(way);
            ways = LWays.ToArray();
        }
    }
}