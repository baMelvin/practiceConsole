using System.Text;

namespace practiceConsole;

public class StringExercises
{
    public static bool IsPalindromeDeclarative(string input)
    {
        var cleaned = new string(input
            .Where(char.IsLetterOrDigit)
            .Select(char.ToLower)
            .ToArray());

        var reversed = new string(cleaned.Reverse().ToArray());
        
        return cleaned == reversed;
    }
    public static Func<string, bool> isPalindromeAnonymousFunction = input =>
    {
        var cleaned = new string(input
            .Where(char.IsLetterOrDigit)
            .Select(char.ToLower)
            .ToArray());

        var reversed = new string(cleaned.Reverse().ToArray());

        return cleaned == reversed;
    };

    // Old C# version < 3 delegate syntax
    public static Func<string, bool> isPalindromeImperative = delegate(string input)
    {
        int i = 0;
        bool isPalindrome = true;

        input = input.ToLower();
        StringBuilder sbin = new StringBuilder(input);
        sbin.Replace(" ", "");
        for (int j = sbin.Length -1; j > -1; j--){
            if(sbin[i] != sbin[j])
                isPalindrome = false;
            i++;
        }

        return isPalindrome;
    };


    public static List<(int Key, char Value)> CharactersSurroundedByPluses(string input)
    {
        var results = new List<(int Key, char Value)>();
        for (int i = 0; i < input.Length - 2; i++)
        {
            Console.WriteLine($"current starting char is {input[i]}");
            if (input[i] == '+' && char.IsLetter(input[i + 1]) && input[i + 2] == '+')
            {
                results.Add((i, input[i+1]));
                Console.WriteLine($"added {input[i+1]}");
                i++;
            }
        }

        return results;
    }
    
    static int vowelCount(string input)
    {
        if(string.IsNullOrWhiteSpace(input)){
            throw new ArgumentException("no");
        }

        return input
            .ToLower()
            .Where(c => "aeiou".Contains(c))
            .Count();
    }
    static string ReverseString(string theString){


        if(string.IsNullOrWhiteSpace(theString)){

            return string.Empty;
        }

        return new string(theString.Reverse().ToArray());
    }


}   