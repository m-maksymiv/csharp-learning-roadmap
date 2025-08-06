namespace CSharpFundamentals.ControlFlow;

public static partial class ControlFlow
{
    private static void WhileLoops()
    {
        Console.WriteLine("Start -> While Loops");

        while (true)
        {
            Console.WriteLine("Type your name");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                break;

            Console.WriteLine("@Echo:" + input);
        }

        Console.WriteLine("Finish -> While Loops");
    }
}
