using System;

namespace FuelAndMoneyConverter
{
  class Program
  {
    static void Main(string[] args)
    {
      float fuelInLiters = 12.5f;
      float pricePerLiter = 3.75f;

      int wholeFuel = Convert.ToInt32(fuelInLiters);
      int roundedTotalCost = Convert.ToInt32(fuelInLiters * pricePerLiter);

      Console.WriteLine("Fuel: " + wholeFuel);
      Console.WriteLine("Total money required: $" + roundedTotalCost);
      
    }
  }
}