using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)

        {

            List<Circle> circles = new List<Circle>();


            double userNum;
            bool check;
            do
            {
                do
                {
                    Console.WriteLine("Hello User! Please enter a Radius. ");
                    string input = Console.ReadLine();
                    check = double.TryParse(input, out userNum);
                    if (userNum < 0)
                    {
                        Console.WriteLine("please enter a positive int.");
                        check = false;
                    }
                    else if (!check)
                    {
                        Console.WriteLine("Please enter an Int.");
                    }
                } while (!check);
                
                    
                

                Circle c1 = new Circle(userNum);
                circles.Add(c1);


                Console.WriteLine(c1.CalculateFormattedCircumference());
                Console.WriteLine(c1.CalculateFormattedArea());
            } while (Continue());
            Console.WriteLine("You've created " + circles.Count + " Circles.");
            Console.ReadLine();






        }

        public static bool Continue()
        {
            Console.WriteLine("Again? {Y/N}");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else Console.WriteLine("Please Try Again.");
            return Continue();
        }
    }
}
