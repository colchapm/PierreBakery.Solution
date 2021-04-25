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
      int breadOrderQty = 1;
      int orderAmount = 5;
      Bread testBreadOrder = new Bread();

      //Act
      int result = testBreadOrder.BreadOrder(breadOrderQty);

      //Assert
      Assert.AreEqual(orderAmount, result);
    }

    [TestMethod]
    public void BreadOrder_CheckOrderOfTwoLoaves_Ten()
    {
      //Arrange
      int breadOrderQty = 2;
      int orderAmount = 10;
      Bread testBreadOrder = new Bread();

      //Act
      int result = testBreadOrder.BreadOrder(breadOrderQty);

      //Assert
      Assert.AreEqual(orderAmount, result);
    }

    [TestMethod]
    public void BreadOrder_ReturnQtySpecialOfBuyTwoGetOneFree_Three()
    {
      //Arrange
      int breadOrderQty = 2;
      int receivedQty = 3;
      Bread testSpecialOffer = new Bread();

      //Act
      int result = testSpecialOffer.SpecialOffer(breadOrderQty);

      //Assert
      Assert.AreEqual(receivedQty, result);
    }
  }
}