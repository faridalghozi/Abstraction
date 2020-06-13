using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Polymorphism
{
    public class Anjing : Animals
    {
        public override void Speak()
        {
            Console.WriteLine("guk....guk");
        }
    }
}