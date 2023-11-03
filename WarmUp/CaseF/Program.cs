namespace CaseF;

internal sealed class Program
{
    private static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        
        for (var i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
 
        nuint seconds = 0;
        nuint currentK = 0;
        bool onParking = true;
        
        for (var i = n-1 ; i >= 0; i--)
        {
            if (a[i] == 0)
            {
                if (!onParking) seconds++;
                continue;
            }

            if (onParking)
            {
                seconds += (nuint)(i + 1);
                onParking = false;
            }
            
            nuint ai = (nuint)a[i] + currentK; 

            switch (ai % (nuint)k)
            {
                case 0:
                    seconds += (nuint)(2 * (i + 1)) * (ai / (nuint)k);
                    if (!onParking) seconds -= (nuint)(i + 1);
                    currentK = 0;
                    onParking = true;
                    break;
                case > 0:
                    seconds += (nuint)(2 * (i + 1)) * (ai / (nuint)k) + 1;
                    currentK = ai % (nuint)k;
                    break;
            } 
        }
        
        Console.WriteLine(seconds);
    }
}
