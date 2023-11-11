using System.Text;

namespace CaseB;

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

        for (var i = 1; i < n; i++)
        {
            if (array[i] >= array[i - 1]) continue;
            QuickSort(array, 0, n - 1);
            break;
        }

        var sb = new StringBuilder();
        for (var i = 0; i < n; i++)
        {
            sb.Append(array[i]);
            sb.Append(' ');
        }

        Console.Write(sb.ToString());
    }

    private static void QuickSort(int[] array, int left, int right)
    {
        if (left >= right) return;

        var p = Partition(array, left, right);
        QuickSort(array, left, p);
        QuickSort(array, p + 1, right);
    }

    private static int Partition(int[] array, int left, int right)
    {
        var equal = left;
        var greater = left;
        var length = right - left + 1;

        var random = new Random();
        var pivot = array[random.Next(left, right)];

        for (var i = left; i < left + length; i++)
        {
            if (array[i] < pivot)
            {
                var temp = array[i];
                array[i] = array[greater];
                array[greater] = array[equal];
                array[equal] = temp;
                equal++;
                greater++;
            }
            else if (array[i] == pivot)
            {
                (array[i], array[greater]) = (array[greater], array[i]);
                greater++;
            }
        }

        return equal;
    }
}