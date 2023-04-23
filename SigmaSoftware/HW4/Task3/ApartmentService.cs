using System.Diagnostics;

namespace SigmaSoftware.HW4.Task3;
// Не побачила копії екрану виконання.(((
public class ApartmentService
{
  private readonly List<Apartment> _apartments = new List<Apartment>();
  public int ApartmentCount { get; private set; }
  
  public int Quarter { get; private set; }

  public ApartmentService(string fileName)
  {
    // А винятки вже відмінились?
    string[] information = File.ReadAllLines(fileName);

    IEnumerable<string> dataInfo = information[0].Split(';')[..2];

    ApartmentCount = int.Parse(dataInfo.ElementAt(0));
    Quarter = int.Parse(dataInfo.ElementAt(1));
    
    foreach (string info in information[1..])
    {
      if (!TryParse(info, out Apartment? newApartment))
      {
        continue;
      }

      _apartments.Add(newApartment!);
    }
  }

  public IReadOnlyCollection<Apartment> GetAllApartments()
  {
    return _apartments;
  }

  public Apartment? GetApartmentById(int id)
  {
    return _apartments.FirstOrDefault(apartment => apartment.ApartmentNumber == id);
  }
  
  public bool TryParse(string row, out Apartment? apartment)
  {
    try
    {
      List<string> allData = row.Split(';').ToList();
      int apartmentInfoColumns = 3;
      int electricityInfoByMonth = 3;

      List<string> onlyApartmentInfo = allData.Take(apartmentInfoColumns).ToList();
      List<string> onlyElectricityInfo = allData.Skip(apartmentInfoColumns).ToList();

      apartment = new()
      {
        ApartmentNumber = int.Parse(onlyApartmentInfo[0]),
        Street = onlyApartmentInfo[1],
        LastName = onlyApartmentInfo[2],
        ElectricityData = new List<ElectricityData>()
      };

      int totalMonth = (allData.Count - apartmentInfoColumns) / electricityInfoByMonth;

      for (int i = 0; i < totalMonth; i++)
      {
        List<string> currentMonth =
          onlyElectricityInfo
            .Skip(i * electricityInfoByMonth)
            .Take(electricityInfoByMonth)
            .ToList();

        ElectricityData electricityData = new()
        {
          BeginMonthInfo = int.Parse(currentMonth[0]),
          EndMonthInfo = int.Parse(currentMonth[1]),
          Date = DateOnly.Parse(currentMonth[2])
        };

        apartment.ElectricityData.Add(electricityData);
      }

      return true;
    }
    catch (Exception ex)
    {
      apartment = null;
      Debug.WriteLine(ex);
      return false;
    }
  }
}
