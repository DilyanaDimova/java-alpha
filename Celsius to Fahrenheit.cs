using System;

namespace CelsiusToFahrenheit

{
    public class StartUp
    {
        public static void Main()
        {    
            var c = double.Parse(Console.ReadLine());
			
            // T(°F) = T(°C) × 1.8 + 32
            var f = (c*1.8)+32;
			
            Console.WriteLine(Math.Round(f,2));
        }
    }
}
