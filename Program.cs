﻿// See https://aka.ms/new-console-template for more information

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

        Console.WriteLine();
        Console.WriteLine("StartsWith / EndsWith");
        StartsWithEndsWith();

        Console.WriteLine();
        Console.WriteLine("Comparação utilizando Equals");
        EqualsFunc();

        Console.WriteLine();
        Console.WriteLine("Encontrando o indice de caracteres de uma string");
        Index();

        Console.WriteLine();
        Console.WriteLine("Utilizando toLower e toUpper");
        ToLowerToUpper();

        Console.WriteLine();
        Console.WriteLine("Utilizando Insert e Remove");
        InsertRemove();
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

    static void StartsWithEndsWith()
    {
        string text = "Este é um texto de teste";

        Console.WriteLine(text);

        Console.WriteLine("Utilizando StartsWith");
        Console.WriteLine($"A frase começa com a palavra Este: {text.StartsWith("Este")}");
        Console.WriteLine($"A frase começa com a palavra este: {text.StartsWith("este")}");
        Console.WriteLine($"A frase começa com a plavra texto: {text.StartsWith("texto")}");

        Console.WriteLine("Utilizando EndsWith");
        Console.WriteLine($"A frase termina com a palavra teste: {text.EndsWith("teste")}");
        Console.WriteLine($"A frase termina com a palavra texto: {text.EndsWith("texto")}");
        Console.WriteLine($"A frase termina coma a palava este: {text.EndsWith("este")}");
    }

    static void EqualsFunc()
    {
        string text = "Este é um texto de teste";

        Console.WriteLine(text);

        Console.WriteLine("Utilizando StartsWith");
        Console.WriteLine($"A frase é igual a 'Este é um texto de teste'?: {text.Equals("Este é um texto de teste")}");
        Console.WriteLine($"A frase é igual a 'este é um texto de teste'?: {text.Equals("este é um texto de teste")}");
        Console.WriteLine($"A frase é igual a 'este é um texto de teste'? (Ignornado case sensitive): {text.Equals("Este é um texto de teste", StringComparison.OrdinalIgnoreCase)}");
    }

    static void Index()
    {
        var text = "Este é um texto de teste";
        Console.WriteLine(text.IndexOf("é"));
        Console.WriteLine(text.LastIndexOf("s"));
    }

    static void ToLowerToUpper()
    {
        var text = "Este é um texto de teste";
        Console.WriteLine(text.ToLower());
        Console.WriteLine(text.ToUpper());
    }

    static void InsertRemove()
    {
        var text = "Este é um texto de teste";
        Console.WriteLine(text.Insert(text.IndexOf(" "), "AQUI "));
        Console.WriteLine(text.Remove(5, 5));
    }
}
