using System.Text;

namespace CaseD;

internal sealed class Program
{
    private static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine();
            return;
        }
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        
        array = MergeSort(array);
        
        var sb = new StringBuilder();
        for (var i = 0; i < n; i++)
        {
            sb.Append(array[i]);
            sb.Append(' ');
        }

        Console.Write(sb.ToString());
    }

    private static int[] MergeSort(int[] array)
    {
        var c = 1;
        var n = 2;
        var left = 0;
        var right = 1;
        var middle = 1;
        var bufferArray = new int[array.Length];
        
        while (n <= array.Length)
        {
            if (array.Length % n != 0) c = 1 + array.Length % n;
                
            Merge(array, bufferArray, left, right, middle);

            if (right != array.Length - c)
            {
                left += n;
                right += n;
                middle = left + (right - left) / 2 + 1;   
            }
            else
            {
                if (c != 1)
                {
                    for (var i = left; i <= array.Length - c; i++)
                    {
                        array[i] = bufferArray[i];
                    }
                    Merge(array, bufferArray, left, array.Length - 1, array.Length - c + 1);
                }
                
                (array, bufferArray) = (bufferArray, array);
                
                n *= 2;
                left = 0;
                right = left + n - 1;
                middle = left + (right - left) / 2 + 1;
            }
        }
        
        return array;
    }
    
    private static void Merge(int[] array, int[] bufferArray, int left, int right, int middle)
    {
        var cursor1 = left;
        var cursor2 = middle;

        for (var i = left; i <= right; i++)
        {
            if (cursor2 > right)
            {
                bufferArray[i] = array[cursor1];
                cursor1++;
                continue;
            }

            if (cursor1 >= middle)
            {
                bufferArray[i] = array[cursor2];
                cursor2++;
                continue;
            }

            if (array[cursor1] <= array[cursor2])
            {
                bufferArray[i] = array[cursor1];
                cursor1++;
            }
            else if (array[cursor1] > array[cursor2])
            {
                bufferArray[i] = array[cursor2];
                cursor2++;
            }
        }
    }
}