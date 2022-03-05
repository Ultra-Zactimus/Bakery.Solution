namespace Order.Model
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public int Price { get; set; }
    public Pastry(int quantity, int price)
    {
      Quantity = quantity;
      Price = price;
    }
    public static int GetTotal(int quantity, int price)
    {
      int total = 0;
      Pastry pastry = new Pastry(quantity, price);
      
      for (int i = 1; i <= pastry.Quantity; i++)
      {
        if (i % 3 != 0)
        {
          total += pastry.Price;
        }
        else
        {
          total += pastry.Price - 1;
        }
      }
      return total;
    }
  }
}