namespace SigmaSoftware.HW5.Task2;

public class ShopBox
{
  public string ShopName { get; set; }
  public List<SectionBox> SectionBoxes { get; set; }

  public ShopBox(string shopName, List<SectionBox> sectionBoxes)
  {
    ShopName = shopName;
    SectionBoxes = sectionBoxes;
  }
}