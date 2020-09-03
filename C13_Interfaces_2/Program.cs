using C13_Interfaces_2.Helpers;
using C13_Interfaces_2.Interfaces;
using C13_Interfaces_2.Models;
using System;

namespace C13_Interfaces_2
{
    class Program
    {
        static void Main(string[] args)
        {

            var cart = SampleData.CartSampleItems();

            foreach (var item in cart)
            {
                item.ShippingItem();

                if (item is ILincense license)
                    Console.WriteLine($"- Du har { license.NumberOfLicenses } st licenser att använda.");
            }
               


        }
    }
}
