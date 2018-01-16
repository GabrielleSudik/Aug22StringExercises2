using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug22StringExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            //class exercise one

            string firstName = "Gabrielle";
            string lastName = "Sudik";

            Console.WriteLine($"Length of {firstName} is {firstName.Length}.");
            Console.WriteLine($"Length of {lastName} is {lastName.Length}.");

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Your first name is longer.");
            }

            if (firstName.Length == lastName.Length)
            {
                Console.WriteLine("Your names are the same length.");
            }

            if (firstName.Length < lastName.Length)
            {
                Console.WriteLine("Your last name is longer.");
            }

            //class exercise two
            //i don't understand the instructions so I'll just print something

            Console.WriteLine("\tHere's an example of tab.\nAnd here's an example of new line.\n" +
                "and here's another new line and a bell sound\a "+ "\nbut you probably muted your speakers.");

            //class exercise three

            string myName = "Gabrielle";
            string sisName = "Nicky";

            Console.WriteLine($"\nMy name is {myName} and my sister is {sisName}.");

            if (myName == sisName)
            {
                Console.WriteLine("Our parents are stupid and gave us the same name.");
            }

            else
            {
                Console.WriteLine("Our parents are not stupid. Their children have different names.");
            }

            if (myName.Equals(sisName))
            {
                Console.WriteLine("Our parents are really dumb.");
            }

            else
            {
                Console.WriteLine("Giving siblings the same name is stupid.");
            }

            //class exercise four

            Console.WriteLine("\nWhat's your first name?");
            string userFirst = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            string userLast = Console.ReadLine();

            Console.WriteLine($"Nice to me you, {userFirst} {userLast}!");

            string fullName = string.Concat(userFirst, " ", userLast);

            Console.WriteLine("Nice hat, " + fullName + ".");

            //class exercise five

            Console.WriteLine("What animal is the opposite of dog?");
            string answer = "cat";
            string guess = Console.ReadLine().ToLower();

            if (guess == answer)
            {
                Console.WriteLine("Right on, sister!");
            }

            else if (guess == answer.ToUpper())
            {
                Console.WriteLine("Right on, sister!");
            }

            else if (guess == answer.ToLower())
            {
                Console.WriteLine("Right on, sister!");
            }

            else
            {
                Console.WriteLine($"Nope, the answer is not {answer}.");
            }

            Console.ReadLine();
        }
    }
}
