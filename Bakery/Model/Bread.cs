namespace Order.Model
{
public class Bread
  {
    public int Quantity { get; set ; }
    public int Price { get; set; }
    public Bread(int quantity, int price)
    {
      Quantity = quantity;
      Price = price;
    }
    public static int GetTotal(int quantity, int price)
    {
      int total = 0;
      Bread bread = new Bread(quantity, price);

      for (int i = 1; i <= bread.Quantity; i++)
      {
        if (i % 3 != 0)
        {
          total += bread.Price;
        }
        else
        {
          total += 0;
        }
      }
      return total;
    }
  }
}