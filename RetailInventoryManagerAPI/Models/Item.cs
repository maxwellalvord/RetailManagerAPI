namespace RetailApi.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Descript { get; set; }
  }
}