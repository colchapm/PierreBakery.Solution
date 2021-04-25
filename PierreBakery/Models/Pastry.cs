
namespace PierreBakery.Models
{
  public class Pastry
  {
    public int PastryOrder(int userEnteredQty)
    {
      int orderAmount = userEnteredQty * 2;
      if (userEnteredQty == 3)
      {
        return orderAmount = 5;
      }
      else 
      {
        return orderAmount;
      }
    }
  }
}