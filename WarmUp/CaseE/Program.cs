namespace CaseE;

internal sealed class Program
{
    private static void Main()
    {
        var students = Convert.ToInt32(Console.ReadLine());
        var ratings = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        var prefixSums = new int[students + 1];
        
        for (var i = 0; i < students; i++)
        {
            prefixSums[i + 1] = prefixSums[i] + ratings[i];
        }
        
        for (var i = 0; i < students; i++)
        {
            var result = ratings[i] * (2 * i - students + 2) - 2 * prefixSums[i + 1] + prefixSums[students];
            Console.WriteLine(result);
        }
    }
}