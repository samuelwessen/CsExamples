using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Glazecalc.models
{
    class Calculate_glass
    {
        public double Glasswidth { get; private set; }
        public double Glassheight { get; private set; }

        public double GlassArea { get; private set; }
        
        public double WoodLength { get; private set; }

        public double Glass() => GlassArea = (Glasswidth) * (Glassheight);
        public double Wood() => WoodLength = (Glasswidth) * (Glassheight) * 3.25;
        
       
        public void Window()
        {
            Console.WriteLine("Please write your windows measures in m ");
            Console.WriteLine("Please write your windows width in m ");

            try
            {
                Glasswidth = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You must write in digits and use ',' if you have a decimal. Please try again ");

                try
                {
                    Glasswidth = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Are you stupid?");
                }
                        


            }
            finally
            {
                Console.WriteLine("Thank you.");
                
            }
            Console.WriteLine("Now please write your windows height in m");

            try
            {
                Glassheight = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You must write in digits and use ',' if you have a decimal. Please try again ");

                try
                {
                    Glassheight = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Are you stupid?");
                }
            }
            finally
            {
                Console.WriteLine("Thank you.");
            }
                        

            
            Console.WriteLine($"The area of the glass is {Glass()} m");
            Console.WriteLine($"The the lenght of the wood is {Wood()} square metres");
        }
    }


}

    