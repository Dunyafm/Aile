using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Mother mother = new Mother();

            mother.Name();
            mother.Age();
            mother.Height();
            mother.Weight();
            Brother brother = new Brother();

            brother.Name();
            
        }
    }
}
