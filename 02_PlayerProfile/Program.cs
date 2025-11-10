using System;
namespace PlayerProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      //Player Profile
      string playerName = "Trevor";       //text
      int level = 15;                    //whole number
      double health = 80.7;             //decimal number
      bool isInPoliceChase = true;     //true false
      char rank = 'A';                //single character

      Console.WriteLine("Player: " + playerName);
      Console.WriteLine("Level: " + level);
      Console.WriteLine("Health: " + health);
      Console.WriteLine("Is in Police Chase: " + isInPoliceChase);
      Console.WriteLine("Rank: " + rank);


      


    }
  }
}