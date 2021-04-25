
namespace PierreBakery.Models
{
  public class Pastry
  {
    public static int PastryOrder(int pastryOrderQty)
    {
      int orderAmount = pastryOrderQty * 2;
      if (pastryOrderQty == 3)
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