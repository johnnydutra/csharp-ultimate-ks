public class Exercises
{
    public static void Main()
    {
        Console.WriteLine(DivideSum(5, 10, -4));
        Console.WriteLine(IsSumLargeOrEqualToNumber(5, 12, 10));
        Console.WriteLine(QualifyNumberSign(5));
        Console.WriteLine(AbsoluteOfSum(-2, -2));
        Console.WriteLine(FormatDate(2026, 2, 25));
        Console.WriteLine(DescribeWeekday(2));
        Console.WriteLine(CalculateSumOfNumbersBetween(3, 5));
        Console.WriteLine(RepeatCharacter('a', 5));
        Console.WriteLine(Factorial(3));
        Console.WriteLine(BuildHelloString());
        Console.WriteLine(IsWordPresentInCollection(["one", "two"], "one"));
        

    }

    // Variables and operators
    public static int DivideSum(int a, int b, int denominator)
    {
        return (a + b) / denominator;
    }

    // Boolean types and operators
    public static bool IsSumLargeOrEqualToNumber(int a, int b, int target)
    {
        return (a + b) >= target;
    }

    // If-else conditional statement
    public static string QualifyNumberSign(int number)
    {
        if (number < 0)
        {
            return "negative";
        }
        else if (number == 0)
        {
            return "zero";
        }
        else
        {
            return "positive";
        }
    }

    // Methods
    public static int AbsoluteOfSum(int a, int b)
    {
        return Math.Abs(a + b);
    }

    // String interpolation
    public static string FormatDate(int year, int month, int day)
    {
        return $"{year}/{month}/{day}";
    }

    // Switch statement
    public static string DescribeWeekday(int dayNumber)
    {
        switch (dayNumber)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                return "Working day";
            case 6:
            case 7:
                return "Weekend";
            default:
                return "Invalid day number";
        }
    }

    // While loop
    public static int CalculateSumOfNumbersBetween(int first, int last)
    {
        if (last < first)
        {
            return 0;
        }

        int current = first;
        int sum = 0;

        while (current <= last)
        {
            sum += current;
            current++;
        }
        return sum;
    }

    // Do-while loop
    public static string RepeatCharacter(char character, int targetLength)
    {
        string result = "";

        do
        {
            result += character;
        }
        while (result.Length < targetLength);

        return result;
    }

    // For loop
    public static int Factorial(int number)
    {
        var result = 1;
        for (int i = 1; i < number; i++)
        {
            result *= i;
        }
        return result;
    }

    // Arrays (1)
    public static string BuildHelloString()
    {
        var letters = new char[] { 'h', 'e', 'l', 'l', 'o' };
        var result = "";

        for (int i = 0; i < letters.Length; i++)
        {
            result += letters[i];
        }
        return result;
    }

    // Arrays (2)
    public static bool IsWordPresentInCollection(string[] words, string wordToCheck)
    {
        for (var i = 0; i < words.Length; i++)
        {
            if (words[i] == wordToCheck)
            {
                return true;
            }
        }
        return false;
    }

    // Multi-dimensional arrays
    public static int FindMax(int[,] numbers)
    {
        int matrixHeight = numbers.GetLength(0);
        int matrixWidth = numbers.GetLength(1);

        if (matrixHeight == 0)
        {
            return -1;
        }

        if (matrixWidth == 0)
        {
            return -1;
        }

        int max = numbers[0, 0];

        for (var i = 0; i < matrixHeight; ++i)
        {
            for (var j = 0; j < matrixWidth; ++j)
            {
                var number = numbers[i, j];
                if (number > max)
                {
                    max = number;
                }
            }
        }
        return max;
    }

    // Foreach loop
    public static bool IsAnyWordLongerThan(int length, string[] words)
    {
        foreach (var word in words)
        {
            if (word.Length > length)
            {
                return true; 
            }
        }
        return false;
    }

    // Lists
    public List<string> GetOnlyUpperCaseWords(List<string> words)
    {
        var result = new List<string>();
        foreach (var word in words)
        {
            if (result.Contains(word))
            {
                continue;
            }

            if (IsUpperCase(word))
            {
                result.Add(word);
            }
        }
        return result;
    }

    bool IsUpperCase(string word)
    {
        foreach (char letter in word)
        {
            if (!char.IsUpper(letter))
            {
                return false; 
            }
        }
        return true;
    }

}