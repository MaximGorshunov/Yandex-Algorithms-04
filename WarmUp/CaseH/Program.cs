namespace CaseH;

class Program
{
    static void Main()
    {
        int a, b, n;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());

        if (a > Math.Ceiling((double)b / n))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}