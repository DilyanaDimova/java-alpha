using System;

public class StartUp
{
  public static void Main()
  {
    int firstCompetitor = int.Parse(Console.ReadLine());
    int secondCompetitor = int.Parse(Console.ReadLine());
    int thirdCompetitor = int.Parse(Console.ReadLine());
    
    int result = firstCompetitor + secondCompetitor + thirdCompetitor;
   
    
    if (result >= 0 && result <= 59)
    {
      if (result < 10)
      {
        Console.WriteLine("0:0"+result);
      }
      else
      {
        Console.WriteLine("0:" + result);
      }      
    }
    
    else if (result >= 60 && result <= 119)
    {
      if ((result - 60)< 10)
      {
        Console.WriteLine("1:0"+ (result - 60));
      }
      else
      {
        Console.WriteLine("1:"+ (result - 60));
      }
    }
    
    else if (result >= 120 && result <= 179)     
    {
      if ((result - 120)< 10)
      {
        Console.WriteLine("2:0"+ (result - 120));
      }
      else
      {
        Console.WriteLine("2:"+ (result - 120));
      }
    }
  }
}
