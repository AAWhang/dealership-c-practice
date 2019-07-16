namespace Dealership.Models
{
  class Car
  {
    public string makeModel;
    public int price;
    public int miles;

    public Car(string makeModel1, int price1, int miles1)
    {
      makeModel = makeModel1;
      price = price1;
      miles = miles1;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (price < maxPrice);
    }
  }
}
