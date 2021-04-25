using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using System.Collections.Generic;
using System;

namespace PierreBakery.TestTools
{
  [TestClass]
  public class PastryTest
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryOrder_CheckOrderOfOnePastry_Two()
    {
      //Arrange
      int userEnteredQty = 1;
      int orderAmount = 2;
      Pastry testPastryOrder = new Pastry();

      //Act
      int result = testPastryOrder.PastryOrder(userEnteredQty);

      //Assert
      Assert.AreEqual(orderAmount, result);
    }
  }
}