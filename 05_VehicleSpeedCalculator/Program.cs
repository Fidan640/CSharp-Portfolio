using System;
namespace VehicleSpeedCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      double distance = 120; //meters
      double time = 5; //seconds

      double speed = distance / time; //arithmetic
      speed += 7; //nitro boost //assignmnet

      bool isFast = speed > 50; //comparisson
      bool missionReady = (speed > 40 && speed < 120); //logical

      Console.WriteLine(distance + " meters");
      Console.WriteLine(time + " seconds");
      Console.WriteLine(speed + " m/s");
      Console.WriteLine("Is Fast: " + isFast );
      Console.WriteLine("Mission ready: " + missionReady);



      
    }
  }
}

