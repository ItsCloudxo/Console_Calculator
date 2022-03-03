using System;
namespace ConCalc
{
    class Program
    {

        /// <summary>
        /// Menu method that utilizes basic console functions
        /// </summary>
        static void Menu()
        {
            Console.WriteLine("Velkommen til ConCalc");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Plus");
            Console.WriteLine("2. Træk fra");
            Console.WriteLine("3. Gange");
            Console.WriteLine("4. Dividere");
            Console.WriteLine("---------------------");
            Console.Write("Vælg funktion: ");
            
        }

        static void Main(string[] args)
        {

            ConsoleKeyInfo key;
            do
            {
                Menu();

                string funktion = Console.ReadLine();
                Console.Write("Tal 1: ");
                string tal1 = Console.ReadLine();
                Console.Write("Tal 2: ");
                string tal2 = Console.ReadLine();
                double resultat = 0;

                switch (funktion)
                {
                    case "1":
                        resultat = Convert.ToDouble(tal1) + Convert.ToDouble(tal2);
                        break;
                    case "2":
                        resultat = Convert.ToDouble(tal1) - Convert.ToDouble(tal2);
                        break;
                    case "3":
                        resultat = Convert.ToDouble(tal1) * Convert.ToDouble(tal2);
                        break;
                    case "4":
                        resultat = Convert.ToDouble(tal1) / Convert.ToDouble(tal2);
                        break;
                    default:
                        //resultat = Convert.ToDouble(tal1) + Convert.ToDouble(tal2); 
                        break;
                }
                //if (funktion == "1")
                //{
                //    resultat = Convert.ToDouble(tal1) + Convert.ToDouble(tal2);
                //}
                //if (funktion == "2")
                //{
                //    resultat = Convert.ToDouble(tal1) - Convert.ToDouble(tal2);
                //}
                //if (funktion == "3")
                //{
                //    resultat = Convert.ToDouble(tal1) * Convert.ToDouble(tal2);
                //}
                //if (funktion == "4")
                //{
                //    resultat = Convert.ToDouble(tal1) / Convert.ToDouble(tal2);
                //}
                //else
                //{

                //}


                Console.WriteLine("---------------------");
                Console.Write("Resultat: ");
                Console.WriteLine(resultat);
                Console.WriteLine("---------------------");
                Console.ReadLine();


                key = Console.ReadKey(true);

            } while (key.Key != ConsoleKey.Escape);
        }
    }
}