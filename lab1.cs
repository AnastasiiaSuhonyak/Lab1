using System;

class File
{
    private string name;
    private DateTime creationDate;
    private long length;

    public File(string name, DateTime creationDate, long length)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("The file name cannot be empty or whitespace.", nameof(name));
        }

        if (creationDate > DateTime.Now)
        {
            throw new ArgumentException("The creation date cannot be in the future.", nameof(creationDate));
        }

        if (length < 0)
        {
            throw new ArgumentException("The file length cannot be negative.", nameof(length));
        }

        this.name = name;
        this.creationDate = creationDate;
        this.length = length;
    }

    public void Append(string text)
    {
        // Here we would implement the logic to append text to the end of the file.
        // For simplicity, we just print the text to the console.
        Console.WriteLine(text);
    }

    public string Name
    {
        get { return name; }
    }

    public DateTime CreationDate
    {
        get { return creationDate; }
    }

    public long Length
    {
        get { return length; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            File file = new File("example.txt", new DateTime(2023, 3, 14), 1024);

            Console.WriteLine($"Name: {file.Name}");
            Console.WriteLine($"Creation date: {file.CreationDate}");
            Console.WriteLine($"Length: {file.Length}");

            file.Append("This is some text that we want to append to the end of the file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}