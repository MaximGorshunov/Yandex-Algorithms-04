namespace CaseJ;

internal sealed class Program
{
    private static void Main()
    {
        var t = int.Parse(Console.ReadLine());
        
        for (var i = 0; i < t; i++)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var n = input[0];
            var a = input[1];
            var b = input[2];

            switch (n % a)
            {
                case 0: 
                    Console.WriteLine("YES");
                    break;
                case > 0: 
                    Console.WriteLine(n % a <= (n / a) * (b - a) || n % b <= (n / b) * (b - a) ? "YES" : "NO");
                    break;
            }
        }
    }
}

