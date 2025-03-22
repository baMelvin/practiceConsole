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
    
    
}   