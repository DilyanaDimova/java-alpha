using System;

namespace USDToBGN

{
    public class StartUp
    {
        public static void Main()
        {    
            var USD = double.Parse(Console.ReadLine());
            var BGN = USD*1.79549;
			
            Console.WriteLine("{0:F2} BGN", BGN);
        }
    }
}
