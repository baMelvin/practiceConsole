namespace practiceConsole;

public class NumberExercises{
    public static void Swap(ref int a, ref int b){
        int tempa = a;
        a = b;
        b = tempa;
    }

    static List<int> noDups(List<int> ints)
    {
        if(ints == null || !ints.Any()){
            throw new ArgumentException("That list is not any good.");
        }

        HashSet<int> uniques = new HashSet<int>(ints);
        
        return new List<int>(uniques);
    }

    static int sumOfEvens(List<int> ints){
        int sum = 0;

        if(ints != null && ints.Any()){
            foreach(int number in ints){
                sum += (number % 2 == 0) ? number : 0;
            }
        }

        return sum;
    }

    static int MaxNum(List<int> ints)
    {
        if (ints == null || !ints.Any())  // ✅ first check null
        {
            throw new ArgumentException("Pass something better please.");
        }

        return ints.Max();
    }

}