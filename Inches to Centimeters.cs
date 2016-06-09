using System;

namespace InchesToCentimeters
{
    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Inches= ");
            var inches = double.Parse(Console.ReadLine());
            var centimeters =  inches*2.54;
            Console.Write("Centimeters = ");
            Console.WriteLine(centimeters);
         }
    }
}
