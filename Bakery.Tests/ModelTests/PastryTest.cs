using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order.Model;

namespace Order.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreateAnInstanceOfPastryObject_NewPastry()
    {
      Pastry pastry = new Pastry(2,2);
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void Pastry_ShouldReturnValuesOfArguments_NewPastry()
    {
      int pricing = 2;
      Pastry pastry = new Pastry(0, pricing);
      Assert.AreEqual(pricing, pastry.Price);
    }

    [TestMethod]
    public void GetTotal_ShouldReturnDiscountedPriceIfModuloThreeEqualsZero_Pastry()
    {
      int quantity = 6;
      int pricing = 2;
      Pastry pastry = new Pastry(quantity, pricing);
      int total = pastry.GetTotal(pastry.Quantity, pastry.Price);
      Assert.AreEqual(10, total);
    }
  }
}