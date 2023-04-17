namespace SigmaSoftware.HW5.Task2;

public class ShopOrganizer
{
  private readonly string _shopName;
  private readonly List<ShopProduct> _cartProducts = new List<ShopProduct>();
  private readonly List<ShopProduct> _existedProductInShop;

  public ShopOrganizer()
  {
    IEnumerable<ShopProduct> shopProducts = AllProducts.Get();
    
    _existedProductInShop = new List<ShopProduct>(shopProducts);
    _shopName = _existedProductInShop.First().ShopSection.Split('/').First();
  }
  
  
  public bool AddToCartProduct(Guid id, int quantity = 1)
  {
    ShopProduct? product = _existedProductInShop.FirstOrDefault(product => product.Id == id);
    if (product is null || quantity < 1)
    {
      return false;
    }

    quantity = Math.Min(quantity, product.Quantity);

    ShopProduct addedProduct = product.Clone();

    addedProduct.Quantity = quantity;
    
    _cartProducts.Add(addedProduct);
    product.Quantity -= quantity;

    return true;
  }

  public bool RemoveFromCartProduct(Guid id, int quantity = 1)
  {
    ShopProduct? product = _cartProducts.FirstOrDefault(product => product.Id == id);

    if (product is null || quantity < 1)
    {
      return false;
    }

    quantity = Math.Min(quantity, product.Quantity);
    
    if (product.Quantity == quantity)
    {
      _cartProducts.Remove(product);
      return true;
    }
    
    product.Quantity -= quantity;
    
    ShopProduct shopProduct = _existedProductInShop.First(shopProduct => shopProduct.Id == id);

    shopProduct.Quantity += quantity;
    
    return true;
  }

  public bool AddProductToShop(ShopProduct shopProduct)
  {
    ShopProduct? existed = _existedProductInShop.FirstOrDefault(product => product.Name == shopProduct.Name);
    if (existed is not null)
    {
      existed.Quantity += shopProduct.Quantity;
      return true;
    }

    ShopProduct correctProduct = shopProduct.Clone(shopSection: "ATB/" + shopProduct.ShopSection.ToUpper());
    _existedProductInShop.Add(correctProduct);

    return true;
  }

  public bool DeleteProductFromShop(Guid id)
  {
    ShopProduct? product = _existedProductInShop.FirstOrDefault(product => product.Id == id);
    if (product is null)
    {
      return false;
    }

    _existedProductInShop.Remove(product);

    return true;
  }
  public Dictionary<string, IEnumerable<ShopProduct>> GetProductsWithSections()
  {
    return _existedProductInShop
      .GroupBy(product => product.ShopSection)
      .ToDictionary(keyValue => keyValue.Key,
                    keyValue => keyValue.AsEnumerable());
  }

  public IEnumerable<ShopProduct> GetProducts()
  {
    return _existedProductInShop;
  }

  public IEnumerable<ShopProduct> GetCartProducts()
  {
    return _cartProducts;
  }

  public ShopBox Buy()
  {
    List<SectionBox> sectionBoxes = new List<SectionBox>();

    foreach (ShopProduct shopProduct in _cartProducts)
    {
      List<string> sections = shopProduct.ShopSection
        .Split('/')
        .Skip(1)
        .ToList();

      string firstSectionName = sections.First();
      SectionBox? previousBox = sectionBoxes.FirstOrDefault(box => box.Name == firstSectionName);

      if (previousBox is null)
      {
        previousBox = new SectionBox(firstSectionName, new List<ProductBox>());
        sectionBoxes.Add(previousBox);
      }

      if (sections.Count == 1)
      {
        ProductBox box = new ProductBox(shopProduct);
        previousBox.ProductsBoxes.Add(box);
        continue;
      }
      
      for (int i = 1; i < sections.Count; i++)
      {
        SectionBox? sectionBox = previousBox.SectionBoxes.FirstOrDefault(box => box.Name == sections[i]);
        if (sectionBox is null)
        {
          sectionBox = new SectionBox(sections[i], new List<ProductBox>());
          previousBox.SectionBoxes.Add(sectionBox);
        }

        previousBox = sectionBox;
        
        if (i + 1 == sections.Count)
        {
          ProductBox box = new ProductBox(shopProduct);
          previousBox.ProductsBoxes.Add(box); 
          break;
        }
      }
    }
    
    ShopBox shopBox = new ShopBox(_shopName, sectionBoxes);

    _cartProducts.Clear();
    
    return shopBox;
  }
}