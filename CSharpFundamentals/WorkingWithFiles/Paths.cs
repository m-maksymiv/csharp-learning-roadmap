namespace CSharpFundamentals.WorkingWithFiles;

public static partial class WorkingWithFiles
{
    private static void Paths()
    {
        var path = @"";

        var dotIndex = path.IndexOf('.');
        var extension = path.Substring(dotIndex);

        Console.WriteLine("Extension: " + Path.GetExtension(path));
        Console.WriteLine("File Name: " + Path.GetFileName(path));
        Console.WriteLine("File Name: without Extension: " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
    }
}
