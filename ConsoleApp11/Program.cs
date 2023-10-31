using System.IO;

void WriteFile(string path, string content)
{
    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);

    StreamWriter streamWriter = new StreamWriter(fs);

    streamWriter.WriteLine(content);
    streamWriter.Close();

    fs.Close();
}

void ReadFile(string path)
{
    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

    StreamReader sr = new StreamReader(fs);

    Console.WriteLine(sr.ReadToEnd());

    sr.Dispose();
}


string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/test.txt";

WriteFile(path, "Hello world");

ReadFile(path);


FileInfo fi = new FileInfo(path);

fi.CreationTime = new DateTime(2024, 2, 2);

Console.WriteLine(fi.CreationTime);

var oldLastWriteTime = File.GetLastWriteTime(path);

File.SetLastWriteTime(path, new DateTime(1999,2,2,11,22,10));