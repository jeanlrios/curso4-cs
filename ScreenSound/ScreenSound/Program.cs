using ScreenSound.Modelos;
using System.Text.Json;
using ScreenSound.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //foreach (var musica in musicas)
        //{
            //musica.ExibirDetalhes();
        //}

        musicas[5].ExibirDetalhes();

        LinqFiltro.FiltrarMusicaTom(musicas, "C#");
        //LinqFiltro.FiltrarGeneros(musicas);
        //LinqOrdenacao.FiltrarArtistaOrdenados(musicas);
        //LinqFiltro.FiltrarArtistaGenero(musicas, "pop");
        //LinqFiltro.FiltrarMusicaArtista(musicas, "Migos");

        //var musicasFavoritas = new MusicasFavoritas("Jean");
        //musicasFavoritas.AdicionarMusicas(musicas[5]);
        //musicasFavoritas.AdicionarMusicas(musicas[45]);
        //musicasFavoritas.AdicionarMusicas(musicas[278]);
        //musicasFavoritas.AdicionarMusicas(musicas[1062]);
        //musicasFavoritas.AdicionarMusicas(musicas[22]);
        //musicasFavoritas.AdicionarMusicas(musicas[509]);

        //musicasFavoritas.ExibirFavoritos();

        //musicasFavoritas.GerarJson();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"ERRO: {ex.Message}");
    }
}