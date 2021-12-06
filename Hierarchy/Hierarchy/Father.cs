using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Father : Family
    {
        public override void Name()
        {
            Console.WriteLine("Name: Faramaz");
        }
        public override void Age()
        {
            Console.WriteLine($"Age:{48}");

        }
        public override void Height()
        {
            Console.WriteLine($"Height:{170}");
        }
        public override void Weight()
        {
            Console.WriteLine($"Weight:{85}");
        }






    }
}
