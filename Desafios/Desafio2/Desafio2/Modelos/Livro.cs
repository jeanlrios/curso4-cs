using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio2.Modelos
{
    internal class Livro
    {
        [JsonPropertyName("titulo")]
        public string? Nome { get; set; }
        [JsonPropertyName("autor")]
        public string? Autor { get; set; }
        [JsonPropertyName("genero")]
        public string? Genero { get; set; }
        [JsonPropertyName("ano_publicacao")]
        public int Ano { get; set; }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Título: {Nome}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Ano: {Ano}\n");
        }
    }
}
