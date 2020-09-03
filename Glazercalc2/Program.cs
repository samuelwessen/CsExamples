using Glazecalc.models;
using System;
using System.Collections.Generic;

namespace Glazecalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculate_glass = new Calculate_glass();

            bool _buyingWindows;




            Console.WriteLine("Hi how many windows do you want to buy? Please type a number ");
            Int32.TryParse(Console.ReadLine(), out int resultat);
            
            double[] doubleVektor = new double[resultat];
            for( int i = 0; i < doubleVektor.Length; i++)
            {
                Console.WriteLine("How many windows? " + (i + 1) + ":");
                double.TryParse(Console.ReadLine(), out double siffra);
                doubleVektor[i] = siffra;
            }





            if (!_buyingWindows)
                Console.WriteLine("Ok that´s cool");

            else
            {
                Console.WriteLine("How many windows do you wanna buy? ");
                int _numberOfWindows = Convert.ToInt32(Console.ReadLine());


                var windows = new List<string>();

                if (_numberOfWindows == 1)
                {
                    windows.Add(Console.ReadLine());
                    calculate_glass.Window();

                }
                else
                {
                    calculate_glass.Window();
                    var _response = Console.ReadLine();


                    foreach (var window in windows)
                    {
                        windows.Add(window);
                    }

                    Console.Write($"Okay, so your measurements are ");
                    foreach (var window in windows)
                    {
                        Console.Write($"{windows} ");
                    }
                }

            }













        }


    }
}
