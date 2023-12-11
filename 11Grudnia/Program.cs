Console.WriteLine("Podaj sćieżke do pliku (z rozszerzeniem)");
string path = Console.ReadLine();

if (File.Exists(path))
{
    if (Path.GetExtension(path) == ".txt")
    {
        StreamReader sr = new StreamReader(path);
        string data = sr.ReadToEnd();
        sr.Close();
        Console.WriteLine(data);
    }
} 
else
{
    File.Create(path).Close();
    StreamWriter sw = new StreamWriter(path);
    Console.WriteLine("Co chcialbys napisac w pliku?");
    napisz();
    void napisz()
    {
        string data = Console.ReadLine();

        if (data.EndsWith("END;;")) sw.Close();
        else
        {
            sw.WriteLine(data);
            napisz();
        }

    }
}