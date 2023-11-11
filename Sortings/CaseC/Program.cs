namespace CaseC;

internal sealed class Program
{
    private static void Main()
    {
        var arrayN = Array.Empty<int>();
        var arrayM = Array.Empty<int>();
        
        var n = int.Parse(Console.ReadLine());
        if (n != 0) arrayN = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        else Console.ReadLine();
        
        var m = int.Parse(Console.ReadLine());
        if (m != 0) arrayM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        else Console.ReadLine();

        if (n != 0 && m != 0)
        {
            Console.WriteLine(string.Join(" ", Merge(arrayN, arrayM)));
        }
        else if (n == 0 && m != 0)
        {
            Console.WriteLine(string.Join(" ", arrayM));
        }
        else if (n != 0 && m == 0)
        {
            Console.WriteLine(string.Join(" ", arrayN));
        }
        else
        {
            Console.WriteLine();
        }
    }

    private static int[] Merge(int[] arrayN, int[] arrayM)
    {
        var cursorN = 0;
        var cursorM = 0;
        var mergedArray = new int[arrayN.Length + arrayM.Length];
        
        for (var i = 0; i < mergedArray.Length; i++)
        {
            if (cursorM >= arrayM.Length)
            {
                mergedArray[i] = arrayN[cursorN];
                cursorN++;
                continue;
            }
            
            if (cursorN >= arrayN.Length)
            {
                mergedArray[i] = arrayM[cursorM];
                cursorM++;
                continue;
            }
            
            if (cursorM >= arrayM.Length || arrayN[cursorN] <= arrayM[cursorM])
            {
                mergedArray[i] = arrayN[cursorN];
                cursorN++;
            }
            else if (cursorN >= arrayN.Length || arrayN[cursorN] > arrayM[cursorM])
            {
                mergedArray[i] = arrayM[cursorM];
                cursorM++;
            }
        }
        
        return mergedArray;
    }
}
