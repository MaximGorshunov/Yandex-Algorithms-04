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
            var array = arrayN.Concat(arrayM).ToArray();
            Console.WriteLine(string.Join(" ", Merge(array, 0, array.Length - 1, n)));
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

    private static int[] Merge(int[] array, int left, int right, int middle)
    {
        var cursor1 = left;
        var cursor2 = middle;
        var mergedArray = new int[array.Length];

        for (var i = 0; i < mergedArray.Length; i++)
        {
            if (cursor2 > right)
            {
                mergedArray[i] = array[cursor1];
                cursor1++;
                continue;
            }

            if (cursor1 >= middle)
            {
                mergedArray[i] = array[cursor2];
                cursor2++;
                continue;
            }

            if (array[cursor1] <= array[cursor2])
            {
                mergedArray[i] = array[cursor1];
                cursor1++;
            }
            else if (array[cursor1] > array[cursor2])
            {
                mergedArray[i] = array[cursor2];
                cursor2++;
            }
        }

        return mergedArray;
    }
}
