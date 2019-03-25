using System;
using System.Collections.Generic;


namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your age?");
            string input = Console.ReadLine();
            double age = Convert.ToDouble(input);

            double heartrate = 220 - age;
            double lowavg = heartrate * 0.50;
            double highavg = heartrate * 0.85;

            Console.WriteLine("Your maximum heart rate should be {0} beats per minute.", heartrate);

            Console.WriteLine("Your target HR Zone is {0} - {1} beats per minute.", lowavg, highavg);

            Console.ReadLine();


        }
    }
}
