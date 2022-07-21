using System;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        static void Main(String[] args)
        {
            // List Creation
            List<Creator> creators = new List<Creator>() { new Youtuber(), new Programmer()};

            // Loops
            foreach(var creator in creators)
            {
                Console.WriteLine(creator.GetType().Name);
                creator.Create();
                Console.WriteLine();
            }
        }
    }
}