
namespace PierreBakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }

    public Pastry(int pastryOrderQty)
    {
      Quantity = pastryOrderQty;
    }
    public static int PastryOrder(int Quantity)
    {
      int orderAmount = Quantity * 2;
      if (Quantity == 3)
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