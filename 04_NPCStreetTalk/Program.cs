using System;
namespace NPCStreetTalk
{
  class Program
  {
    static void Main(string[] args)
    {
      string playerQuestion;
      string npcResponse;

      Console.WriteLine("You meet an NPC on the street. What do you ask?");
  
      //player question: Which car should I steal for my next mission?
      playerQuestion = Console.ReadLine();

      npcResponse = "Try the blue sports car down the alley, fast but low attention.";
      Console.Write("NPC: " + npcResponse);

    }
  }
}