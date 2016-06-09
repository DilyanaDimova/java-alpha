using System;
using System.Globalization;
					
public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        DateTime dt = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
        DateTime result = dt.AddDays(1000-1);
		
        Console.WriteLine(result.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture));
    }
}
