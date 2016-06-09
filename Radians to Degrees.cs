using System;

namespace RadiansToDegrees

{
    public class StartUp
    {
        public static void Main()
        {    
            var rad = double.Parse(Console.ReadLine());
			
            //  degrees = radians*180/Math.PI; 
            var c = (rad*180/Math.PI);
			
            Console.WriteLine(Math.Round(c,0));
        }
    }
}
