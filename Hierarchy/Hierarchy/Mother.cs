using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Mother : Family
    {
        public override void Name()
        {
            Console.WriteLine("Name: Ilhame");
        }
        public override void Age()
        {
            Console.WriteLine($"Age: {38}");
        }
        public override void Height()
        {
            Console.WriteLine($"Height: { 160}");
        }
        public override void Weight()
        {
            Console.WriteLine($"Weight: {65}");
        }
    }
}
