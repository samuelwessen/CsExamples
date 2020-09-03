using C13_Interfaces_2.Interfaces;
using C13_Interfaces_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Helpers
{
    class SampleData
    {
        public static List<IShoppingItem> CartSampleItems()
        {
            var output = new List<IShoppingItem>();

            output.Add(new Product { Id = "10", Name = "Iphone10", Description = "mobiltelefon" });
            output.Add(new Product { Id = "11", Name = "Piggelin", Description = "glass" });
            output.Add(new Product { Id = "12", Name = "Smartshake", Description = "Vattenflaska 700ml" });

            output.Add(new Lincense { Id = "100", Name = "MsWord10", Description = "MicrosoftWord 10", NumberOfLicenses = 1 });

            return output;
        }
    }
}
