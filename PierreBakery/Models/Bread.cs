using System.Collections.Generic;

namespace PierreBakery.Models
{
  public class Bread
  {
    public int BreadOrder(int userEnteredQty)
    {
      int orderAmount = userEnteredQty * 5; 
      return orderAmount;
    }
  }
}