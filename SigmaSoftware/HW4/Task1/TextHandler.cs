using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SigmaSoftware.HW4;

public class TextHandler
{
  private readonly string _text;

  public TextHandler(string text)
  {
    _text = text.Replace("\n", string.Empty).Replace("\r", string.Empty);
  }

  public string[] FindAllBracketsInfo()
  {
      MatchCollection punctuationMatches = Regex.Matches(_text, @"(\.|\?|!)");

      List<int> indexes = punctuationMatches.Select(part => part.Index).ToList();

      List<string> sentences = new List<string>();
      indexes.Aggregate(-1, (prev, next) =>
      {
          sentences.Add(_text.Substring(prev + 1, next - prev).Trim());
          return next;
      });

      return sentences.Where(part => Regex.IsMatch(part, @"(\(.*\)|\{.*\}|\[.*\])")).ToArray();
  }
}