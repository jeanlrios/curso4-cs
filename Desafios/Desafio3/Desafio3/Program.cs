using Desafio3;

//1
List<Livro> livros = new List<Livro>
{
    new Livro {Titulo = "Aprendendo LINQ", Autor = "João Silva", AnoPublicacao = 2005},
    new Livro {Titulo = "Programação em C#", Autor = "Ana Oliveira", AnoPublicacao = 2010},
    new Livro {Titulo = "Algoritmos e Estruturas de Dados", Autor = "Carlos Santos", AnoPublicacao = 1998},
    new Livro {Titulo = "Introdução à Inteligência Artificial", Autor = "Mariana Costa", AnoPublicacao = 2021}
};

var titulosLivros = livros.Where(l => l.AnoPublicacao > 2000).OrderBy(l => l.Titulo).Select(l => l.Titulo);

Console.WriteLine("Títulos de livros publicados após 2000, ordenados alfabeticamente");
foreach (var titulo in titulosLivros)
{
    Console.WriteLine(titulo);
}

Console.WriteLine("");

// 2
List<Produto> produtos = new List<Produto>
{
    new Produto {Nome = "Laptop", Preco = 1200},
    new Produto {Nome = "Smartphone", Preco = 800},
    new Produto {Nome = "Tablet", Preco = 500},
    new Produto {Nome = "Camera", Preco = 300}
};

var precoMedio = produtos.Average(p => p.Preco);

Console.WriteLine($"Preço médio dos produtos {precoMedio}");

Console.WriteLine("");

// 3
List<string> palavras = new List<string> { "gato", "macaco", "uva", "vaca", "pé" };

var filtrarPalavras = palavras.Where(p => p.Length > 3).OrderBy(p => p.Length);

foreach (var palavra in filtrarPalavras)
{
    Console.Write($"{palavra} ");
}