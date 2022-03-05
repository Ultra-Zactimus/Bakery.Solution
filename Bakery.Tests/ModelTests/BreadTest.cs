using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order.Model;

namespace Order.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreateAnInstanceOfBreadObject_NewBread()
    {
      Bread bread = new Bread(3, 5);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void Bread_ShouldReturnValuesOfArguments_NewBread()
    {
      int pricing = 3;
      Bread bread = new Bread(0, pricing);
      Assert.AreEqual(pricing, bread.Price);
    }

    [TestMethod]
    public void GetTotal_ShouldReturnDiscountedPriceIfModuloThreeEqualsZero_Bread()
    {
      int quantity = 6;
      int pricing = 5;
      Bread sourdough = new Bread(quantity, pricing);
      int total = Bread.GetTotal(sourdough.Quantity, sourdough.Price);
      Assert.AreEqual(12, total);
    }
  }
}