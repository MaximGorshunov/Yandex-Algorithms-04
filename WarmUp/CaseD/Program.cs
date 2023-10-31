namespace  CaseD;

internal sealed class Program
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        
        if (s1.Length != s2.Length)
        {
            Console.WriteLine("NO");
            return;
        }

        var chars = new int[256];
        for (var i = 0; i < s1.Length; i++)
        {
            chars[s1[i]]++;
            chars[s2[i]]--;
        }

        foreach (var count in chars)
        {
            if (count != 0)
            {
                Console.WriteLine("NO");
                return;
            }
        }

        Console.WriteLine("YES");
    }
}