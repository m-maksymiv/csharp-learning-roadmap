namespace CSharpFundamentals.WorkingWithFiles;

public static partial class WorkingWithFiles
{
    private static void FileAndFileInfo()
    {
        Console.WriteLine("Start -> File and FileInfo");

        var path = @"d:\somefile.jpg";

        File.Copy(@"d:\temp\myfile.jpg", @"d:\temp1\myfile.jpg", true);
        File.Delete(path);

        if (File.Exists(path))
        {
            //
        }
        var content = File.ReadAllText(path);

        var fileInfo = new FileInfo(content);
        fileInfo.CopyTo("...");
        fileInfo.Delete();
        if (fileInfo.Exists)
        {
            //
        }

        Console.WriteLine("Finish -> File And FileInfo");
    }
}
