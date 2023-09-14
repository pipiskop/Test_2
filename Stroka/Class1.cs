using System;
using System.Linq;

public class YourStringManipulationClass
{
    public static string FindShortestWord(string input)
    {
        string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        if (words.Length == 0)
        {
            return null; // Возвращаем null, если строка не содержит слов.
        }

        string shortestWord = words.OrderBy(w => w.Length).First();
        return shortestWord;
    }

    public static int CountWords(string input)
    {
        string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    public static int CountCharacters(string input)
    {
        return input.Length;
    }

    public static char GetNthCharacter(string input, int n)
    {
        if (n >= 0 && n < input.Length)
        {
            return input[n];
        }
        throw new ArgumentOutOfRangeException(nameof(n));
    }

    public static int CountDigits(string input)
    {
        int digitCount = 0;
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
        }
        return digitCount;
    }

    public static int FindMaxConsecutiveDigits(string input)
    {
        int maxConsecutiveDigits = 0;
        int currentConsecutiveDigits = 0;
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                currentConsecutiveDigits++;
                maxConsecutiveDigits = Math.Max(maxConsecutiveDigits, currentConsecutiveDigits);
            }
            else
            {
                currentConsecutiveDigits = 0;
            }
        }
        return maxConsecutiveDigits;
    }

    public static int CountAmCombinations(string input)
    {
        int amCount = 0;
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == 'a' && input[i + 1] == 'm')
            {
                amCount++;
            }
        }
        return amCount;
    }
}
