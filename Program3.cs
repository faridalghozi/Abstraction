using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Polymorphism
{
    public class program
    {
        public static void Main(string[] args)
        {
            Animals animals = new Animals();

            animals = new Anjing();
            animals.Speak();

            Console.WriteLine();
            animals = new Kambing();
            animals.Speak();

            Console.ReadKey();
        }
    }
}