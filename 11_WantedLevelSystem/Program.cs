using System;
namespace WantedLevelSystem
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] wantedLevel = {"★ Just a warning", 
                             "★★ Patrol car nearby", 
                             "★★★ SWAT called in",  
                             "★★★★ Helicopters inbound", 
                             "★★★★★ Full lockdown!" };
     
     foreach (string i in wantedLevel)
      {
        Console.WriteLine(i);
      }

      string[,] cityZones = {
                             {"Downtown", "★★★★★"}, 
                             {"Vinewood", "★★★" },
                             {"Sandy Shores", "★"}
                            };

      for (int i = 0; i < cityZones.GetLength(0); i++)
      {
        Console.WriteLine(cityZones[i, 0] + " - " + cityZones[i, 1]);
      }                  



    }
  }
}
