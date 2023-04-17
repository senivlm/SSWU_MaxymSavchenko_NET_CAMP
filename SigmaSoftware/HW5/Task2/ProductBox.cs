namespace SigmaSoftware.HW5.Task2;

public class ProductBox
{
  public string BoxName => Product.ShopSection;
  public ShopProduct Product { get; set; }

  public ProductBox(ShopProduct product)
  {
    Product = product;
  }
}