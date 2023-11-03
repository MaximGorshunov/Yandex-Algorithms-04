namespace CaseI;

internal sealed class Program
{
    private static void Main()
    {
        var input = Console.ReadLine();
        
        Console.WriteLine(CheckBraces(input) ? "yes" : "no");
    }

    private static bool CheckBraces(string input)
    {
        var stack = new Stack<char>();
        
        foreach (var chr in input)
        {
            switch (chr)
            {
                case ')' :
                    if (stack.Count == 0 || stack.Peek() != '(') return false;
                    stack.Pop();
                    break;
                case '}' :
                    if (stack.Count == 0 || stack.Peek() != '{') return false;
                    stack.Pop();
                    break;
                case ']' :
                    if (stack.Count == 0 || stack.Peek() != '[') return false;
                    stack.Pop();
                    break;
                default:
                    stack.Push(chr);
                    break;
            }
        }

        return stack.Count == 0;
    }
}