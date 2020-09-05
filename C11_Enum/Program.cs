using C11_Enum;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace C11_Enum
{
    public enum Level
    {
        Low,
        Normal,
        High,
        VeryHigh,
          
    }

    
    class Program
    {
      
        enum Status
         {
            Pending,
            Production,
            Transporting,
            Delivered
         }


        static void Main(string[] args)
        {
            var temperature = 52;
            var _tempLevel = Level.Normal;
            

            switch (temperature)
            {
                case int t when t < 10:
                    _tempLevel = Level.Low;                    
                    break;

                case int t when t > 30 && t < 50:
                    _tempLevel = Level.High;                    
                    break;

                case int t when t > 51:
                    _tempLevel = Level.VeryHigh;                    
                    break;

                default:                 
                    _tempLevel = Level.Normal;                    
                    break;


            }

            switch (_tempLevel)
            {
                case Level.Low:
                    Console.WriteLine("Temperature is to Low");
                    break;
                case Level.Normal:
                    Console.WriteLine("Temperature is Normal");
                    break;
                case Level.High:
                    Console.WriteLine("Temperature is to High");                    
                    break;
                    
                case Level.VeryHigh:
                    Console.WriteLine("Temperature is dangerously High please shutdown immendiately!!");
                    Console.WriteLine("Shutting down in");
                    EmergencyShuttdown();
                    Console.WriteLine("Shutdown Complete");
                    break;
                    
            }


            var status = Status.Transporting;

            switch (status)
            {
                case Status.Pending:
                    Console.WriteLine("Electronic information has been received.");
                    break;
                case Status.Production:
                    Console.WriteLine("Your product(s) are beeing prepared for shipping.");
                    break;
                case Status.Transporting:
                    Console.WriteLine("Your product(s) are in transit.");
                    break;
                case Status.Delivered:
                    Console.WriteLine("Your product(s) has been delivered");
                    break;
            }

             
             void EmergencyShuttdown()
             {
                for (int i = 10; i > 0; i--)
                {                    
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                }
                    
             }



        }
    }
}
