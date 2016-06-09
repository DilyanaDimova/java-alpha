using System;

namespace Square
{
    public class Program
    {
        public static void Main()
        {
            
            Console.Write("a= ");
			var a = int.Parse(Console.ReadLine());
            var area =  a*a;
			Console.Write("Square = ");
            Console.WriteLine(area);
         }
    }
}
