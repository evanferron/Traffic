using System;

namespace traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            string intersectionName = "";
            while (intersectionName != "1" && intersectionName != "2") {
                Console.WriteLine("Veuillez choisir un type d'intersection :\n 1- cédez le passage \n 2- feux rouge\n Entrez votre réponse : ");
                intersectionName = Console.ReadLine();
            }
            
            Intersection inter = new Intersection(intersectionName);
            Traffic traffic = new();
            inter.AddWay();
            string input = "";
            if (intersectionName == "1"){
                while (input != "q")
                {
                    traffic.RoundManagementGiveWay(inter);
                    input = Console.ReadLine();
                }
            }
            if (intersectionName == "2"){
                while (input != "q")
                {
                    traffic.RoundManagementTrafficLight(inter);
                    input = Console.ReadLine();
                }
            }
        }
    }
}
