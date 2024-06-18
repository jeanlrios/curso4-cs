using Desafio1;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
    
}

Console.WriteLine("");

try
{
    Console.Write("Numero: ");
    int numero = int.Parse(Console.ReadLine()!);
    Console.Write("Numero: ");
    int numero2 = int.Parse(Console.ReadLine()!);
    int divisao = numero / numero2;
    Console.WriteLine($"Resultado: {divisao}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.WriteLine("");

try
{
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, };
    Console.WriteLine(numeros[2]);
    Console.WriteLine(numeros[7]);
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

Console.WriteLine("");

try
{
    ObjetoNulo objeto = null;
    objeto.Calcular();
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}