namespace CaseA;

internal sealed class Program
{
    private static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine("0\n0");
            return;
        }
        var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var x = int.Parse(Console.ReadLine());
        
        int equal = Partition(array, x);
        
        Console.WriteLine(equal);
        Console.WriteLine(n - equal);
    }

    private static int Partition(int[] array, int pivot)
    {
        var equal = 0;
        var greater = 0;
        
        for (var i = 0; i < array.Length; i++)
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