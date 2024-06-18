using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio2.Modelos
{
    internal class Pais
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("capital")]
        public string Capital { get; set; }
        [JsonPropertyName("continente")]
        public string Continente { get; set; }
        [JsonPropertyName("idioma")]
        public string Idioma { get; set; }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome do Pais: {Nome}");
            Console.WriteLine($"Capital: {Capital}");
            Console.WriteLine($"Continente: {Continente}");
            Console.WriteLine($"Idioma: {Idioma}\n");
        }
    }
}
