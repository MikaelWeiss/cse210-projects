public class FileManager
{
    public static void WriteToFile(string stringValue)
    {
        Console.WriteLine();
        Console.Write("What is the filename for the visions file? ");
        string path = Console.ReadLine();
        File.WriteAllLines(path, [stringValue]);
    }

    public static string ReadFromFile()
    {
        Console.WriteLine();
        Console.Write("What is the filename for the visions file? ");
        string path = Console.ReadLine();
        return File.ReadAllText(path);
    }
}