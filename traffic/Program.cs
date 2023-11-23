using System;

namespace traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            Intersection inter = new Intersection("traffic light");
            Traffic traffic = new();
            inter.AddWay();
            Console.WriteLine("Veuillez choisir un type d'intersection :\n 1- cédez le passage \n 2- feux rouge\n Entrez votre réponse : ");
            string input= "";
            while (input != "q")
            {
                traffic.RoundManagementTrafficLight(inter);
                input = Console.ReadLine();
                // switch (input)
                // {
                //     case "1":
                //         //execute giveway
                //         break;
                //     case "2":
                //         traffic.RoundManagement(inter);
                //         break;
                //     case "q":
                //         continue;
                //     default:
                //         Console.Clear();
                //         Console.WriteLine("Veuillez choisir un type d'intersection :\n 1- cédez le passage \n 2- feux rouge\n Entrez votre réponse valid : ");
                //         break;
                // }
                
            }

        }
    }
}
