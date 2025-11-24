using System;
namespace StreetRaceCountdown
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 3; i > 0; i--)
      {
        Console.WriteLine(i + "...");
      }
      Console.WriteLine("GO!");

      Console.WriteLine("Press Enter to start the race!");
      Console.ReadLine();

      for (int lap = 1; lap <= 2; lap++)
      {
        int racer = 1;
        while (racer <= 3)
        {
        Console.WriteLine("Racer " + racer + " finished lap " + lap);
        racer++;
        }
        Console.WriteLine();

      }
      Console.WriteLine("🏆 Race finished!");



      
        


        

    }
  }
}