using System;

namespace TriangleArea

{
    public class StartUp
    {
        public static void Main()
        {    
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
			
            var area = a*h/2;
			
            Console.WriteLine("Triangle area = {0}",Math.Round(area,2));
        }
    }
}
