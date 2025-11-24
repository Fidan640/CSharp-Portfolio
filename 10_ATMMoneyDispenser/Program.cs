using System;
namespace ATMMoneyDispenser
{
  class Program
  {
    static void Main(string[] args)
    {
      int amountToWithdraw = 230;
      
      while (amountToWithdraw > 0)
      {
        int bill = 0;
        if (amountToWithdraw >= 100) bill = 100;
        else if (amountToWithdraw >= 50) bill = 50;
        else if (amountToWithdraw >= 20) bill = 20;
        else break;

       amountToWithdraw -= bill;
       Console.WriteLine("Dispensing $" + bill);
      }

         Console.WriteLine("ATM is empty! Time to run!");
    }
  }
}