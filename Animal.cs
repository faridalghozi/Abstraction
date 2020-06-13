using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Polymorphism
{
    public class Animals
    {
        public string Name { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine("Animals speaks ");
        }
    }
}