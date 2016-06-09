using System;

namespace RectangleArea
{
    public class StartUp
    {
        public static void Main()
        {    
             var x1 = double.Parse(Console.ReadLine());
             var y1 = double.Parse(Console.ReadLine());
             var x2 = double.Parse(Console.ReadLine());
             var y2 = double.Parse(Console.ReadLine());
             double a,b;
			
             if (x1>x2)
             {
                 a = x1 - x2;
             }
             else
             {
                 a = x2 - x1;
             }
			
             if (y1>y2)
             {
                 b = y1 - y2;
             }
             else
             {
                 b = y2 - y1;
             }
			
             Console.WriteLine(a * b);
             Console.WriteLine(2 * (a + b));
       }
    }
}
