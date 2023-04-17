using System.Collections.ObjectModel;

namespace SigmaSoftware.HW5.Task2;

public static class AllProducts
{
  private static List<ShopProduct> _products = new List<ShopProduct>();
  public static IEnumerable<ShopProduct> Get()
  {
    if (!_products.Any())
    {
      _products.AddRange(new List<ShopProduct>
      {
        new (name: "Bread", shopSection: "ATB/Food".ToUpper(), height: 4, width: 4, length: 20, quantity: Random.Shared.Next(20, 1000)),
        new (name: "Cheese", shopSection: "ATB/Food".ToUpper(), height: 3, width: 5, length: 5, quantity: Random.Shared.Next(20, 1000)),
        new (name: "Rice", shopSection: "ATB/Food".ToUpper(), height: 10, width: 8, length: 2, quantity: Random.Shared.Next(20, 1000)),
        new (name: "Water", shopSection: "ATB/Food/Drinks".ToUpper(), height: 20, width: 4, length: 4, quantity: Random.Shared.Next(20, 1000)),
        new (name: "Cola", shopSection: "ATB/Food/Drinks".ToUpper(), height: 17, width: 4, length: 4, quantity: Random.Shared.Next(20, 1000)),
        new (name: "Fanta", shopSection: "ATB/Food/Drinks".ToUpper(), height: 15, width: 3, length: 4, quantity: Random.Shared.Next(20, 1000)),
        new (name: "T-Shirt", shopSection: "ATB/Clothes".ToUpper(), height: 110, width: 75, length: 3, quantity: Random.Shared.Next(20, 1000)),
        new (name: "Shirt", shopSection: "ATB/Clothes".ToUpper(), height: 100, width: 70, length: 3, quantity: Random.Shared.Next(20, 1000)),
      });
    }

    return _products;
  }
}