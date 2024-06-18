using System.Text.Json;
using Desafio2.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
        foreach (var filme in filmes)
        {
            filme.ExibirDetalhes();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}

using (HttpClient client2 = new HttpClient())
{
    try
    {
        string resposta = await client2.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta);
        foreach (var pais in paises)
        {
            pais.ExibirDetalhes();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}

using (HttpClient client3 = new HttpClient())
{
    try
    {
        string resposta = await client3.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        var carros = JsonSerializer.Deserialize<List<Carro>>(resposta);
        foreach (var carro in carros)
        {
            carro.ExibirDetalhes();
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}

using (HttpClient client4 = new HttpClient())
{
    try
    {
        string resposta = await client4.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var livros = JsonSerializer.Deserialize<List<Livro>>(resposta);
        foreach (var livro in livros)
        {
            livro.ExibirDetalhes();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}