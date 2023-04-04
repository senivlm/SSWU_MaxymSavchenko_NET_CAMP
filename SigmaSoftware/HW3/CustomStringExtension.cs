using System.Text;

namespace SigmaSoftware.HW3;
public static class CustomStringExtenstion
{

    public static string ReplaceAllLetterDuplicates(this string text, string replaceText)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            if (i + 1 != text.Length && text[i] == text[i + 1] && char.IsLetter(text[i]))
            {
                result.Append(replaceText);
                i++;
                continue;
            }

            result.Append(text[i]);
        }

        return result.ToString();
    }
    public static int GetCountWordsWithUppercase(this string text)
    {
        return text.Split(' ').Count(word => char.IsUpper(word.FirstOrDefault()));
    }
    public static int? GetIndexSecondEnteringSubstring(this string text, string substring)
    {
        bool containsSubstring = false;
        for (int i = 0; i < text.Length - substring.Length + 1; i++)
        {
            if (text.Substring(i, substring.Length).ToLower() == substring.ToLower())
            {
                if (containsSubstring)
                {
                    return i;
                }
                containsSubstring = true;
            }
        }

        return null;
    }
}