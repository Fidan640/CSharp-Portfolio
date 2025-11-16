using System;
namespace WeaponWheelSystem
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Choose your weapon: (1)Pistol, (2)Shotgun, (3)SMG, (4)Sniper");
      string weaponChoice = Console.ReadLine();

      switch (weaponChoice)
      {
        case "1":
          Console.WriteLine("🔫 You equipped the Pistol.");
          break;
        case "2":
          Console.WriteLine("💥 You equipped the Shotgun.");
          break;
        case "3":
          Console.WriteLine("⚙️ You equipped the SMG.");
          break;
        case "4":
          Console.WriteLine("🎯 You equipped the Sniper.");
          break;
        default:
          Console.WriteLine("❌ Invalid weapon choice!");
          break;
      }
    }
  }
}