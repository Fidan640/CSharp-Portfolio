using System;
namespace PoliceChaseLogic
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Are you wanted by the police?");
      string wantedInput = Console.ReadLine();

      Console.WriteLine("Do you have a fast car?");
      string carInput = Console.ReadLine();

      if (wantedInput == "no")
      {
        Console.WriteLine("No chase today. You are free to cruise Console City!");
      }
      else if (wantedInput == "yes" && carInput == "yes")
      {
        Console.WriteLine("You escaped the cops through the highway!");
      }
      else if (wantedInput == "yes" && carInput == "no")
      {
        Console.WriteLine ("You got caught by the police!");
      }
      else
      {
        Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
      }

    }
  }
}