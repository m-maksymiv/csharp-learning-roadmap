﻿namespace CSharpFundamentals.WorkingWithDates;

public static partial class WorkingWithDates
{
    private static void DateTimes()
    {
        Console.WriteLine("Start -> DateTime");

        var dateTime = new DateTime(1999, 12, 16);
        var now = DateTime.Now;
        var today = DateTime.Today;

        Console.WriteLine("Hour: " + now.Hour);
        Console.WriteLine("Minute: " + now.Minute);

        var tomorrow = now.AddDays(1);
        var yesterday = now.AddDays(-1);

        Console.WriteLine(now.ToLongDateString());
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToLongTimeString());
        Console.WriteLine(now.ToShortTimeString());
        Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

        Console.WriteLine("Finish -> DateTime");
    }
}
