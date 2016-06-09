using System;

namespace CurrencyConverter
{
    public class StartUp
    {
        public static void Main()
        {    
             var number = double.Parse(Console.ReadLine());
             var inputCurrent = Console.ReadLine();
             var outputCurrent = Console.ReadLine();
             double result=0.00;
			
             if (inputCurrent == "USD" && outputCurrent == "BGN")
             {
                 result = number*1.79549;
             }
             else if (inputCurrent == "EUR" && outputCurrent == "BGN")
             {
                 result = number*1.95583;
             }
             else if (inputCurrent == "GBP" && outputCurrent == "BGN")
             {
                result = number*2.53405;			
             }		
             else if (inputCurrent == "BGN" && outputCurrent == "USD")
             {
                result = number/1.79549;
             }
             else if (inputCurrent == "BGN" && outputCurrent == "EUR")
             {
                result = number/1.95583;
             }
             else if (inputCurrent == "BGN" && outputCurrent == "GBP")
             {
                result = number/2.53405;
             }
             else if (inputCurrent == "EUR" && outputCurrent == "USD")
             {
                result = number*1.79549/1.95583;
             }
             else if (inputCurrent == "EUR" && outputCurrent == "GBP")
             {
                result = number*2.53405/1.95583;
             }
            else if (inputCurrent == "USD" && outputCurrent == "EUR")
            {
                result =  number*1.95583/1.79549;
            }
            else if (inputCurrent == "GBP" && outputCurrent == "EUR")
            {
                result = number*2.53405/1.79549;
            }
            else if (inputCurrent == "USD" && outputCurrent == "GBP")
            {
                result = number*2.53405/1.79549;
            }
            else if (inputCurrent == "GBP" && outputCurrent == "USD")
            {
               result = number*1.79549/2.53405;
            }
			
            Console.WriteLine ("{0:F2} {1}", result, outputCurrent);
        }
    }
}
