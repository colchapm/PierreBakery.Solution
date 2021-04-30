
namespace PierreBakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }

    public Pastry(int pastryOrderQty)
    {
      Quantity = pastryOrderQty;
    }
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