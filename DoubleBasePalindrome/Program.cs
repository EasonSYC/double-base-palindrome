internal class Program
{
    static bool IsPalindrome(string str)
    {
        return str == string.Join("", str.ToCharArray().Reverse().ToArray());
    }
    static void Main()
    {
        List<int> palindromeNumber = [];

        for (int i = 0; palindromeNumber.Count < 20; ++i)
        {
            if (IsPalindrome(i.ToString()) && IsPalindrome(Convert.ToString(i, 2)))
            {
                palindromeNumber.Add(i);
            }
        }

        Console.WriteLine($"{"Denary",-10} Binary");

        foreach (int num in palindromeNumber)
        {
            Console.WriteLine($"{num,-10} {Convert.ToString(num, 2)}");
        }
    }
}