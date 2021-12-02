using System.IO;

class FileIO{
    public static void Main(string[] arg)
    {
        // write to file
        string path = "./outputFile.txt";
        StreamWriter writer = new StreamWriter(path);
        writer.WriteLine("writing text to the output file.");
        writer.WriteLine("line 2");
        writer.Close();
        Console.WriteLine("Done!");

        string[] text = {"hi", "hello", "How's it going" };
        File.AppendAllLines(path, text);

        // read a file
        string path2 = "./inputFile.txt";
        StreamReader reader = new StreamReader(path2);
        try
        {
            // reader.peek() --> while nextline exists
            while (reader.Peek() != -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("End of the file");
        } finally{
            reader.Close();
        }
    }
}