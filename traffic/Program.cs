using System;

namespace traffic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez choisir un type d'intersection :\n 1- cédez le passage \n 2- feux rouge\n Entrez votre réponse : ");
            string input = Console.ReadLine();
            while (input != "q")
            {
                switch (input)
                {
                    case "1":
                        //execute giveway
                        break;
                    case "2":
                        // execute red light
                        break;
                    case "q":
                        continue;
                    default:
                        Console.Clear();
                        Console.WriteLine("Veuillez choisir un type d'intersection :\n 1- cédez le passage \n 2- feux rouge\n Entrez votre réponse valid : ");
                        break;
                }

            }

        }
    }
}
