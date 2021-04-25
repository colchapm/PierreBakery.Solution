
namespace PierreBakery.Models
{
  public class Bread
  {
    public int BreadOrder(int userEnteredQty)
    {
      int orderAmount = userEnteredQty * 5; 
      return orderAmount;
    }

    public int SpecialOffer(int userEnteredQty)
    {
      int receivedQty = userEnteredQty;
      if (userEnteredQty >= 2)
      {
        return receivedQty + 1;
      }
      else 
      {
        return receivedQty;
      }
    }
  }
}