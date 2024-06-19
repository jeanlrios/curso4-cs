using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class Musica
    {
        private string[] tonalidades = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        [JsonPropertyName("song")]
        public string? Nome {  get; set; }
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        [JsonPropertyName("key")]
        public int Nota { get; set; }
        public string Tonalidade { 
            get 
            {
                return tonalidades[Nota];
            } 
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Duração: {Duracao / 1000} segundos");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Tom da música: {Tonalidade}\n");
        }

        public void ExibirGeneros()
        {

        }
    }
}
