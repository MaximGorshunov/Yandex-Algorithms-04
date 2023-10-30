namespace CaseA;

internal sealed class Program 
{
    static void Main() {
        
        var mL = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        var sequence = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

        for (var i = 0; i < mL[1]; i++) 
        {
            var lR = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var localMin = sequence[lR[0]];
            bool notFound = true;

            for (var j = lR[0]+1; j <= lR[1]; j++)
            {
                if (sequence[j] > localMin) 
                {
                    Console.WriteLine(sequence[j]);
                    notFound = false;
                    break;
                }

                if (sequence[j] < localMin) {
                    Console.WriteLine(localMin);
                    notFound = false;
                    break;
                }
            }

            if (notFound) Console.WriteLine("NOT FOUND");
        } 
    }
}