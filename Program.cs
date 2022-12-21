// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        var id = Guid.NewGuid().ToString();
        Console.WriteLine(id);
    }
}
