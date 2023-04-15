namespace SigmaSoftware.HW4.Task3;

public class ElectricityData
{
  private const decimal PricePerKiloWatt = 1.75m;
  private const int MonthCountPerQuarter = 3;
  public decimal BeginMonthInfo { get; set; }
  public decimal EndMonthInfo { get; set; }
  public DateOnly Date { get; set; }
  public int Quarter => Date.Month / MonthCountPerQuarter + 1;
  public decimal Debt => (EndMonthInfo - BeginMonthInfo) * PricePerKiloWatt;
}