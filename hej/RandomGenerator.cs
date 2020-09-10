using System;
using System.Collections.Generic;
using System.Text;

namespace Inlämmningsuppgift_1.Models
{
    class RandomGenerator
    {

        static void Main()
        {
            System.Random random = new System.Random();            
            System.Console.WriteLine(random.Next(10,50));

        }
    }
}
