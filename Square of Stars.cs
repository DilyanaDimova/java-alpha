using System;

namespace Rextester
{
    public class Program
    {
        public static void Main()
        {
            
            var n = int.Parse(Console.ReadLine());
            char edge = '*';
            
             for (int row = 0; row < n; row++)
             {
                  for (int col = 0; col < n; col++)
                  {
                      if (col == 0 || row == 0 || row == n-1 || col == n-1)
                      { 
                          Console.Write(edge);
                      }
					  else
					  {
						  Console.Write(" ");
					  }
                 }
                 Console.WriteLine();
             }
         }
    }
}
