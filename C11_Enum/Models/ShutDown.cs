using System;
using System.Collections.Generic;
using System.Text;

namespace C11_Enum.Models
{
    class ShutDown
    {
        public void EmergencyShuttdown(int seconds)
        {
            for (var i = 10; i < seconds; i--)
                Console.WriteLine(i);
        }

    }
}
