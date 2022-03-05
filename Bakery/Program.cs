using System;
using Order.Model;

namespace Order
{
  public class Bakery
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! So glad you have made us your first choice for baked goods.");
      Console.WriteLine("Today we have bread and pastries available and we have a special deal going on.");
      Console.WriteLine("Bread is $3 per Loaf and Pastries are $2 per pastries, but for every 2 you buy I am gonna throw on a discount.");
      Console.WriteLine("Buy 2 Loafs and get 1 free! Buy 2 Pastries and get the 3rd half off!");

      Console.WriteLine("How many you loafs of bread would you like to today?");
      int loafs = int.Parse(Console.ReadLine());

      Console.Write("How many you patries would you like to today?");
      int pastries = int.Parse(Console.ReadLine());

      int breadPrice = Bread.GetTotal(loafs, 5);
      int pastryPrice = Pastry.GetTotal(pastries, 2);

      Console.WriteLine("Your total is $" + (breadPrice + pastryPrice));

      Console.WriteLine("Would you like to shop with us again? Y for 'yes' or Enter if 'no'");
      string answer = Console.ReadLine().ToLower();

      if (answer == "y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Thank you for shopping! Goodbye my friend.");
      }
    }
  }
}