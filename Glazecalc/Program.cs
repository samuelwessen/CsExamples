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


            Console.WriteLine("Hi do you want to buy customs windows with a wooden frame? (yes/no) ");
            var _windowsResponse = Console.ReadLine();

            

            switch (_windowsResponse.ToLower())
            {
                case "yes":
                    _buyingWindows = true;
                    break;

                case "no":
                    _buyingWindows = false;
                    break;

                default:
                    _buyingWindows = false;
                    break;

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
                    calculate_glass.Window();
                    windows.Add(Console.ReadLine());

                }
                else
                {
                    for (var i=0; i < _numberOfWindows; i++)
                    {                        
                        calculate_glass.Window();
                        windows.Add(Console.ReadLine());
                        
                    }

                }
                
            }

            Console.WriteLine("Thank you for buying ");
            Console.ReadKey();

        }

        
    }
}
