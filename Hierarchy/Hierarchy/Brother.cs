using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Brother : Family
    {
        public override void Name()
        {
            Console.WriteLine("Name : Emil");
        }
        public override void Age()
        {
            Console.WriteLine($"Age : {20}");
        }
        public override void Height()
        {
            Console.WriteLine($"Height : {175}");
        }

        public override void Weight()
        {
            Console.WriteLine($"Weight : {70}");

        }
    }
}
      