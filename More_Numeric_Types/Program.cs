using System;

namespace More_Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many miles have you driven?");
            int miles = int.Parse(Console.ReadLine());

            Console.WriteLine("How much gas has your car consumed?");
            int gasConsumed = int.Parse(Console.ReadLine());

            Console.WriteLine("Your car's MPG is: " + miles/gasConsumed);
        }
    }
}
