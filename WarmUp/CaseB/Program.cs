namespace CaseB;

internal sealed class Program 
{
    static void Main(){

        var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        
        var lcd = FindLcd(input[1], input[3]);
        var m = input[0] * lcd/input[1] + input[2] * lcd/input[3];
        var gcd = FindGcd(m, lcd);
        
        Console.WriteLine(m/gcd + " " + lcd/gcd);
    }
    
    private static int FindLcd(int num1, int num2) {
        
        int maxNum = Math.Max(num1, num2);
        int lcd = num1 * num2;

        for (int i = maxNum; i <= lcd; i += maxNum) {
            if (i % num1 == 0 && i % num2 == 0) {
                lcd = i;
                break;
            }
        }

        return lcd;
    }
    
    private static int FindGcd(int num1, int num2)
    {
        while (num2 != 0)
        {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        return num1;
    }
}