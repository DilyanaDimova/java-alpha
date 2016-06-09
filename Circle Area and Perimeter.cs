using System;

namespace TrapeziodArea
{
    public class StartUp
    {
        public static void Main()
        {    
            var r = double.Parse(Console.ReadLine());
            var s = Math.PI * r * r ;
            var p = 2 * Math.PI * r ;
			
            Console.WriteLine("Area = {0}", s);
            Console.WriteLine("Perimeter = {0}", p);
        }
    }
}
