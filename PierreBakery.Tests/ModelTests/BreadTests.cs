using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierreBakery.Models;
using System.Collections.Generic;
using System;

namespace PierreBakery.TestTools
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadOrder_CheckOrderOfOneLoaf_Five()
    {
      //Arrange
      int userEnteredQty = 1;
      int orderAmount = 5;
      Bread testBreadOrder = new Bread();

      //Act
      int result = testBreadOrder.BreadOrder(userEnteredQty);

      //Assert
      Assert.AreEqual(orderAmount, result);
    }
  }
}