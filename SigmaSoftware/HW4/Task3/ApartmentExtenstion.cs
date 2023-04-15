using System.Diagnostics;

namespace SigmaSoftware.HW4.Task3;

public static class ApartmentExtenstion
{
  public static void PrintAllApartments(this ApartmentService apartmentService)
  {
    IReadOnlyCollection<Apartment> apartments = apartmentService.GetAllApartments();

    foreach (Apartment apartment in apartments)
    {
      PrintApartment(apartment);
    }
  }

  public static void PrintApartmentInfo(this ApartmentService apartmentService, int apartmentNumber)
  {
    Apartment? apartment = apartmentService.GetApartmentById(apartmentNumber);

    PrintApartment(apartment);
  }

  public static Apartment? GetApartmentWithGreaterDebt(this ApartmentService apartmentService)
  {
    try
    {
      IReadOnlyCollection<Apartment> apartments = apartmentService.GetAllApartments();

      Apartment? apartment = apartments.MaxBy(apartment => apartment.ElectricityData.Sum(electricityData => electricityData.Debt));

      if (apartment == null)
      {
        throw new Exception("There are no apartments.");
      }

      return apartment;
    }
    catch (Exception e)
    {
      Debug.WriteLine(e);
      return null;
    }
  }

  private static void PrintApartment(Apartment? apartment)
  {
    if (apartment == null)
    {
      Console.BackgroundColor = ConsoleColor.Red;
      Console.ForegroundColor = ConsoleColor.White;

      Console.WriteLine("Apartment not found.");
      
      Console.ResetColor();
      return;
    }

    Console.WriteLine($"> {apartment}\n");
  }
}