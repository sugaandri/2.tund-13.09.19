using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string firstName;
            string lastName;
            string favColor;
            //muutujad koodi ette
            Console.WriteLine("Please enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter your lastname: ");
            lastName = Console.ReadLine();
            //Console.WriteLine("Hi, " + firstName + " " + lastName + "!");
            //Just another option
            Console.WriteLine("Nice to meet you, {0} {1}!", firstName, lastName);
            //parem viis
            Console.WriteLine("What is your favourite color, {0} {1}?", firstName, lastName);
            favColor = Console.ReadLine();
            Console.WriteLine("{0}, I like {1} color too!", firstName, favColor);
            Console.ReadLine();

        }
    }
}
