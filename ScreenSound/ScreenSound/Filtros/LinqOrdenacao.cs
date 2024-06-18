using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Filtros
{
    internal class LinqOrdenacao
    {
        public static void FiltrarArtistaOrdenados(List<Musica> musicas)
        {
            var todosArtista = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var artista in todosArtista)
            {
                Console.WriteLine($"- {artista}");
            }
        }
    }
}
