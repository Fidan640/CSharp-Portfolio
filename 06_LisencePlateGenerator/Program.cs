using System;
namespace LisencePlateGenerator
{
  class Program
  {
    static void Main(string[] args)
    {
      string letters = "GTA";
      string numbers = "911";

      string plate = letters + "-" + numbers;

      char firstLetter = plate[0];
      char lastNumber = plate[plate.Length - 1]; 
      Console.WriteLine("🚖GTA Plate Generator🚔\n");
      Console.WriteLine(" Plate: " + plate);
      Console.WriteLine(" First Letter: " + firstLetter);
      Console.WriteLine(" Last Number " + lastNumber);
      

    }
  }
}