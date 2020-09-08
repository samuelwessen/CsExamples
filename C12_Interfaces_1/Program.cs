using System;

namespace C12_Interfaces_1
{

    class Program
    {

        static void Main(string[] args)
        {
            var cnc = new CNC();
            cnc.Start();
            var bandsaw = new BandSaw();
            bandsaw.Stop();

            Console.WriteLine("Hello World!");
        }
    }
}
