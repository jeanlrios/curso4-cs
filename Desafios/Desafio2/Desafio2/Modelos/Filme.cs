using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio2.Modelos
{
    internal class Filme
    {
        [JsonPropertyName("title")]
        public string? Titulo { get; set; }
        [JsonPropertyName("rank")]
        public string? Posicao { get; set; }
        [JsonPropertyName("year")]
        public string? Ano { get; set; }
        [JsonPropertyName("imDbRating")]
        public string? Nota { get; set; }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Lançamento: {Ano}");
            Console.WriteLine($"Posição: {Posicao}");
            Console.WriteLine($"Nota: {Nota}\n");
        }
    }
}
