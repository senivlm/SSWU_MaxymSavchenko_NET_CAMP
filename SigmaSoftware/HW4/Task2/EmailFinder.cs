using System.Net.Mail;

namespace SigmaSoftware.HW4.Task2;

public static class EmailFinder
{
  public static ResponseVm GetEmailsOrLexemes(string text)
  {
    IEnumerable<string> textSplitBySpace = text.Split(' ').Where(part => part.Contains("@"));

    List<string> mails = new List<string>();
    List<string> lexemes = new List<string>();

    foreach (string partOfText in textSplitBySpace)
    {
      if (IsMail(partOfText))
      {
        mails.Add(partOfText);
      }
      else
      {
        lexemes.Add(partOfText);
      }
    }

    ResponseVm responseVm = new()
    {
      Mails = mails,
      Lexemes = lexemes
    };

    return responseVm;
  }

  private static bool IsMail(string row)
  {
    try
    {
      MailAddress address = new MailAddress(row);
      return address.Address == row;
    }
    catch
    {
      return false;
    }
  }
}