namespace CaseC;

internal sealed class Program
{
    static void Main()
    {
        var coords = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var x1 = (double)coords[0];
        var y1 = (double)coords[1];
        var x2 = (double)coords[2];
        var y2 = (double)coords[3];

        double radius1 = Math.Sqrt(x1 * x1 + y1 * y1);
        double radius2 = Math.Sqrt(x2 * x2 + y2 * y2);
        
        var angle = Math.Atan2(x2, y2) - Math.Atan2(x1, y1);

        while (angle > Math.PI)
            angle -= 2.0 * Math.PI;
        while (angle < -Math.PI)
            angle += 2.0 * Math.PI;

        double distance;

        if (radius1 > radius2) distance = radius1 - radius2 + Math.Abs(radius2 * angle);
        else if (radius1 == radius2) distance = Math.Abs(radius2 * angle);
        else distance = radius2 - radius1 + Math.Abs(radius1 * angle);
        
        Console.WriteLine(Math.Round(Math.Min(radius1 + radius2, distance), 12));
    }
}