namespace SigmaSoftware.HW5.Task2;

public class SectionBox
{
  public string Name { get; set; }
  // порушення інкапсуляції
  public List<ProductBox> ProductsBoxes { get; set; }
  public List<SectionBox> SectionBoxes { get; set; }
  
  public double Height => ProductsBoxes.Max(box => box.Product.Height);
  public double Width => ProductsBoxes.Sum(box => box.Product.Width);
  public double Length => ProductsBoxes.Max(box => box.Product.Length);

  public SectionBox(string name, List<ProductBox> productsBoxes, List<SectionBox>? sectionBoxes = null)
  {
    Name = name;
    ProductsBoxes = productsBoxes;

    SectionBoxes = sectionBoxes ?? Enumerable.Empty<SectionBox>().ToList();
  }
}
