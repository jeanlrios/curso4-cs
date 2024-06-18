using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Desafio2.Modelos
{
    internal class Carro
    {
        [JsonPropertyName("modelo")]
        public string? Nome { get; set; }
        [JsonPropertyName("marca")]
        public string? Marca { get; set; }
        [JsonPropertyName("tipo")]
        public string? Tipo { get; set; }
        [JsonPropertyName("motor")]
        public string? Motor { get; set; }
        [JsonPropertyName("transmissao")]
        public string? Transmissao { get; set; }
        [JsonPropertyName("ano")]
        public int Ano { get; set; }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Modelo: {Nome}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Ano: {Ano}\n");
        }
    }
}
