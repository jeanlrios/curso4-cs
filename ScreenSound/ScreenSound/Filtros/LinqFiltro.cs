using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Filtros
{
    internal class LinqFiltro
    {
        public static void FiltrarGeneros(List<Musica> musicas)
        {
            var todosGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach(var genero in todosGeneros)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistaGenero(List<Musica> musicas, string genero)
        {
            var artistaGenero = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            foreach (var artista in artistaGenero)
            {
                Console.WriteLine($"Artista: {artista} - Gênero: {genero}");
            }
        }

        public static void FiltrarMusicaArtista(List<Musica> musicas, string artista)
        {
            var musicaArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
            Console.WriteLine(artista);
            foreach (var musica in musicaArtista)
            {
                Console.WriteLine($"Musica: {musica.Nome} - Artista: {artista}\n");
            }
        }
    }
}
