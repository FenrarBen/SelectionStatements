using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            var userInput = int.Parse(Console.ReadLine());

            if (userInput > favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine("What is your favorite subject?");
            var favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Math":
                    Console.WriteLine("Math");
                    break;
                case "English":
                    Console.WriteLine("English");
                    break;
                case "Science":
                    Console.WriteLine("Science");
                    break;
                case "History":
                    Console.WriteLine("History");
                    break;
                case "Art":
                    Console.WriteLine("Art");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }
}
