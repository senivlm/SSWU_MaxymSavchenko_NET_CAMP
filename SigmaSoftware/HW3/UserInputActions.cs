
using System.Text;

public class UserInputActions
{
    public string Text { get; set; } = string.Empty;
    public UserInputActions(string text)
    {
        Text = text;
    }

    public string ReplaceAllLetterDuplicates(string text)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < Text.Length; i++)
        {
            if (i + 1 != Text.Length && Text[i] == Text[i + 1])
            {
                result.Append(text);
                i++;
                continue;
            }

            result.Append(Text[i]);
        }

        return result.ToString();
    }
    public int GetCountWordsWithUppercase()
    {
        return Text.Split(' ').Count(word => char.IsUpper(word[0]));
    }
    public int? GetIndexSecondEnteringSubstring(string substring)
    {
        List<string> list = Enumerable.Range(0, Text.Length - substring.Length + 1)
                                       .Select(index => Text.Substring(index, substring.Length))
                                       .ToList();
        
        int firstSubstringIndex = list.IndexOf(substring);
        int secondSubstringIndex = list.IndexOf(substring, firstSubstringIndex + 1);

        return secondSubstringIndex  == -1 ? null : secondSubstringIndex;
    }
}