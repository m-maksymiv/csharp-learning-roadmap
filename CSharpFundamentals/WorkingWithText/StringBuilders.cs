﻿using System.Text;

namespace CSharpFundamentals.WorkingWithText;

public static partial class WorkingWithText
{
    private static void StringBuilders()
    {
        Console.WriteLine("Start -> String Builder");

        var builder = new StringBuilder("Hello World");
        builder.Append('-', 10)
               .AppendLine()
               .Append("Header")
               .AppendLine()
               .Append('-', 10)
               .Replace('-', '+');

        builder.Remove(0, 10);

        builder.Insert(0, new string('-', 10));

        Console.WriteLine(builder);

        Console.WriteLine("First Char: " + builder[0]); //Output: First Char: -

        Console.WriteLine("Finish -> String Builder");
    }
}
