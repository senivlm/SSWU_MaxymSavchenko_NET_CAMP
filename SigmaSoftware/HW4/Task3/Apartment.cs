using System.Text;

namespace SigmaSoftware.HW4.Task3;

public class Apartment
{
  public int ApartmentNumber { get; set; }
  public string Street { get; set; } = string.Empty;
  public string LastName { get; set; } = string.Empty;
  public List<ElectricityData> ElectricityData { get; set; } = null!;

  public override string ToString()
  {
    decimal totalDebt = ElectricityData.Sum(electricityData => electricityData.Debt);
    DateOnly lastTimeCheck = ElectricityData.Max(data => data.Date);

    DateTime now = DateTime.UtcNow;

    int daysAfterLastCheck = (now - lastTimeCheck.ToDateTime(TimeOnly.FromDateTime(now))).Days;

    StringBuilder electricityInformation = new StringBuilder($"\n\t{"Date",15}|{"Begin month",15}|{"End month",15}|{"Debt",10}");
    
    
    foreach (ElectricityData data in ElectricityData)
    {
      electricityInformation.Append($"\n\t{data.Date,15}|{data.BeginMonthInfo + "kWt",15}|{data.EndMonthInfo + "kWt",15}|{data.Debt,10:C0}");
    }
    return $"Apartment Number: {ApartmentNumber};Street: {Street}; Last name: {LastName};" +
           $"{electricityInformation}" +
           $"\n\tTotal debt: {totalDebt:C0}; Days after last check: {daysAfterLastCheck}";
  }
}