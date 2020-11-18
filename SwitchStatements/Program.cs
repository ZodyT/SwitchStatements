using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for their favorite school subject.
            //Store their answer in a variable
            //Pass the variable as the expression in a switch statement.
            //Create 5 different cases for different subjects.  
            //Each case will print the subject chosen and a custom message of your choosing.
            //Create a default case to handle any case not handled.
            Console.WriteLine("What is your favorite school subject?");
            var Subject = Console.ReadLine().ToLower();

            switch (Subject)
            {
                case "math":
                    Console.WriteLine($"You picked {Subject}, you must be good with numbers.");
                    break;
                case "literature":
                    Console.WriteLine($"You picked { Subject}, you must read alot.");
                    break;
                case "chemistry":
                    Console.WriteLine($"You picked { Subject}, you must know all the elements");
                    break;
                case "biology":
                    Console.WriteLine($"You picked { Subject}, you must have studied the human body.");
                    break;
                case "recess":
                    Console.WriteLine($"You picked { Subject}, you must like to have fun.");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break;


            }
        }
    }
}
