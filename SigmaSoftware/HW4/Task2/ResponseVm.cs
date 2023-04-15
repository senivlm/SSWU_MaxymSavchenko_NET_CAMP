namespace SigmaSoftware.HW4.Task2;

public class ResponseVm
{
  public IEnumerable<string> Mails { get; set; } = Enumerable.Empty<string>();
  public IEnumerable<string> Lexemes { get; set; } = Enumerable.Empty<string>();
}