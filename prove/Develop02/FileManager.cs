public class FileManager {
    public static void WriteToFile(string stringValue) {
        Console.Write("Name of file: ");
        string path = Console.ReadLine();
        File.WriteAllLines(path, [stringValue]);
    }

    public static string ReadFromFile() {
        Console.Write("Name of file: ");
        string path = Console.ReadLine();
        return File.ReadAllText(path);
    }
}