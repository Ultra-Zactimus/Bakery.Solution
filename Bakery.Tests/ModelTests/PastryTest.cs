using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order.Model;

namespace Order.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreateAnInstanceOfPastryObject_Object()
    {
      Pastry pastry = new Pastry(2,2);
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void Pastry_ShouldReturnValuesOfArguments_Int()
    {
      int pricing = 2;
      Pastry pastry = new Pastry(0, pricing);
      Assert.AreEqual(pricing, pastry.Price);
    }

    [TestMethod]
    public void GetTotal_ShouldReturnDiscountedPriceForEveryThirdItem_Int()
    {
      int quantity = 6;
      int pricing = 2;
      Pastry pastry = new Pastry(quantity, pricing);
      int total = Pastry.GetTotal(pastry.Quantity, pastry.Price);
      Assert.AreEqual(10, total);
    }
  }
}