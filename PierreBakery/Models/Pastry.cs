
namespace PierreBakery.Models
{
  public class Pastry
  {
    public int PastryOrder(int userEnteredQty)
    {
      int orderAmount = userEnteredQty * 2;
      return orderAmount;
    }
  }
}