namespace SigmaSoftware.HW5.Task2;

public class ShopProduct
{
  public Guid Id { get; } = Guid.NewGuid();
  public string Name { get; init; }
  public string ShopSection { get; init; }
  public double Height { get; init; }
  public double Width { get; init; }
  public double Length { get; init; }
  public int Quantity { get; set; }

  public ShopProduct(string name,
                     string shopSection, 
                     double height, 
                     double width, 
                     double length, 
                     int quantity)
  {
    Name = name;
    ShopSection = shopSection;
    Height = height;
    Width = width;
    Length = length;
    Quantity = quantity;
  }

  public ShopProduct Clone(string? name = null,
                           string? shopSection = null, 
                           double height = -1,
                           double width = -1,
                           double length = -1,
                           int quantity = -1
                           )
  {
    ShopProduct product = new ShopProduct(
      name: name ?? Name,
      shopSection: shopSection ?? ShopSection,
      height: height <= 0 ? Height : height,
      width: width <= 0 ? Width : width,
      length: length <= 0 ? Length : length,
      quantity: quantity <= 0 ? Quantity : quantity
    );
    return product;
  }

  public override string ToString()
  {
    return $"Name: {Name} | Quantity: {Quantity}";
  }
}