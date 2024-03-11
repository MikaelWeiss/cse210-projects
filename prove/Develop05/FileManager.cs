public class FileManager {
    public static void WriteToFile(string stringValue) {
        Console.Write("What is the filename for the goals file? ");
        string path = Console.ReadLine();
        File.WriteAllLines(path, [stringValue]);
    }

    public static string ReadFromFile() {
        Console.Write("What is the filename for the goals file? ");
        string path = Console.ReadLine();
        return File.ReadAllText(path);
    }
}