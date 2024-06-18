using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class MusicasFavoritas
    {
        public string Nome { get; }
        public List<Musica> ListaDeMusicas { get; }

        public MusicasFavoritas(string nome)
        {
            Nome = nome;
            ListaDeMusicas = new List<Musica>();
        }

        public void AdicionarMusicas(Musica musica)
        {
            ListaDeMusicas.Add(musica);
        }

        public void ExibirFavoritos()
        {
            Console.WriteLine($"Musica favoritas de {Nome}");
            foreach (var musica in ListaDeMusicas)
            {
                Console.WriteLine($"Título: {musica.Nome}\nArtista: {musica.Artista}\n");
            }
        }

        public void GerarJson()
        {
            try
            {
                string json = JsonSerializer.Serialize(new
                {
                    nome = Nome,
                    musicas = ListaDeMusicas
                });
                string nomeArquivo = $"musicas-favoritas-{Nome}.json";

                File.WriteAllText(nomeArquivo, json);
                Console.WriteLine($"Arquivo {nomeArquivo} criado com sucesso na pasta {Path.GetFullPath(nomeArquivo)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha ao gerar arquivo:\nErro: {ex.Message}");
            }
        }
    }
}
