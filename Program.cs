// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        GetFunctions(); 
    }

    static void GetFunctions()
    {
        Console.WriteLine("Gerando id utilizando Guid");
        var id = Guid.NewGuid().ToString();
        Console.WriteLine(id);

        Console.WriteLine();
        Console.WriteLine("Interpolação de String");
        Interpolation();

        Console.WriteLine();
        Console.WriteLine("Comparação de strings");
        CompareString();
    }

    static void Interpolation()
    {
        var price = 10.2;
        var text = $"O preço do produto é {price} somente na promoção.";
        var text1 = string.Format("Utilizando string.Format() => O preço do produto é {0} somente na promoção.", price);

        Console.WriteLine(text);
        Console.WriteLine(text1);
    }

    static void CompareString()
    {
        var text = "Testando";
        var text1 = "Este texto é um teste.";
        Console.WriteLine($"Utilizando texto.CompareTo(): {text.CompareTo("testando")}");
        Console.WriteLine($"Verificando se o texto contém uma determinada palavra utlizando texto.Contains(): {text1.Contains("Teste")}");
        Console.WriteLine($"Verificando se o texto contém uma determinada palavra utlizando texto.Contains(), ignoraando case sensitive: {text1.Contains("Teste", StringComparison.OrdinalIgnoreCase)}");

    }
}
