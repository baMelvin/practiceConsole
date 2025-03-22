using static practiceConsole.StringExercises;

var result = CharactersSurroundedByPluses("a++b+c++d+e+f++g");
foreach (var (key, value) in result)
{
    Console.WriteLine($"{key} : {value}");
}


// 1. Convert input to lowercase
// 2. Remove all non-alphanumeric characters
// 3. Reverse the cleaned string
// 4. Compare cleaned string with reversed string
// 5. Return true if they match, false otherwise


// // Lambda
// Func<string, bool> isPalindrome = input =>
// {
//     var cleaned = new string(input
//         .Where(char.IsLetterOrDigit)
//         .Select(char.ToLower)
//         .ToArray());
//
//     var reversed = new string(cleaned.Reverse().ToArray());
//
//     return cleaned == reversed;
// };

// // No return type for action.
// Action<string> greet = name => Console.WriteLine($"Hello, {name}!");

// // Anonymous function
// Func<string, bool> isPalindrome = delegate(string input)
// {
//     return true;
// };

// Func<string, bool> isPalindrome = input =>
// {
//     var cleaned = new string(input
//         .Where(char.IsLetterOrDigit)
//         .Select(char.ToLower)
//         .ToArray());

//     var reversed = new string(cleaned.Reverse().ToArray());

//     return cleaned == reversed;
// };

// Console.WriteLine(isPalindrome("here come the hot steppa43s00"));
// Console.WriteLine(isPalindrome("tac ocat"));

// int x=3, y=7;
// void Swap(ref int a, ref int b){
//     int tempa = a;
//     a = b;
//     b = tempa;
// }
// Swap(ref x, ref y);
// Console.WriteLine(x);
// Console.WriteLine(y);



// Action<Rectangle> printArea = delegate(Rectangle rect)
// {
//     Console.WriteLine($"Area: {rect.Width * rect.Height}" );
// };
// printArea(new Rectangle { Width = 10, Height = 20 });
//
// struct Rectangle
// {
//     public int Width;
//     public int Height;
// }

