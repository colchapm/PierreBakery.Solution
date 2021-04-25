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
      int pastryOrderQty = 1;
      int orderAmount = 2;

      //Act
      int result = Pastry.PastryOrder(pastryOrderQty);

      //Assert
      Assert.AreEqual(orderAmount, result);
    }

    [TestMethod]
    public void PastryOrder_CheckOrderOfThreePastry_Five()
    {
      //Arrange
      int pastryOrderQty = 3;
      int orderAmount = 5;

      //Act 
      int result = Pastry.PastryOrder(pastryOrderQty);

      //Assert
      Assert.AreEqual(orderAmount, result);
    }
  }
}