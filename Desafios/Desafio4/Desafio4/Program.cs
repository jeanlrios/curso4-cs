using Desafio4;
using System.Text.Json;


//Pessoa dadosPessoa = new Pessoa();
//Console.Write("Digite o nome: ");
//dadosPessoa.Nome = Console.ReadLine()!;
//Console.Write("Digite a idade: ");
//dadosPessoa.Idade = int.Parse(Console.ReadLine()!);
//Console.Write("Digite o e-mail: ");
//dadosPessoa.Email = Console.ReadLine()!;

//Console.WriteLine($"Os dados referenta a {dadosPessoa.Nome} foram salvos no sistema");


//Console.WriteLine("Deseja que seja criado um arquivo?");
//Console.Write($"Digite: 1 para SIM | 2 para NÃO: ");
//int escolha = int.Parse(Console.ReadLine()!);

//if (escolha == 1)
//{
//    string arquivoJson = JsonSerializer.Serialize(dadosPessoa);
//    string nomeArquivo = $"pessoa-{dadosPessoa.Nome}.json";
//    File.WriteAllText(nomeArquivo, arquivoJson);

//    Console.WriteLine("O arquivo foi criado com sucesso!");
//}
//else
//{
//    Console.WriteLine("O arquivo não foi criado.");
//}

//string arquivo = "pessoa-Jean.json";
//if (File.Exists(arquivo))
//{
//    string json = File.ReadAllText(arquivo);

//    Pessoa pessoa = JsonSerializer.Deserialize<Pessoa>(json);

//    Console.WriteLine($"\nNome: {pessoa.Nome}");
//    Console.WriteLine($"Idade: {pessoa.Idade}");
//    Console.WriteLine($"E-mail: {pessoa.Email}");
//}
//else
//{
//    Console.WriteLine($"O arquivo {arquivo} não existe.");
//}

List<Pessoa> pessoas = new List<Pessoa>();

while (true)
{
    Pessoa pessoa = new Pessoa();
    Console.Write("Digite o nome ou 'sair' para encerrar: ");
    string nome = Console.ReadLine()!;

    if (nome.ToLower() == "sair")
        break;

    pessoa.Nome = nome;

    Console.Write("Digite a idade: ");
    pessoa.Idade = int.Parse(Console.ReadLine()!);

    Console.Write("Digite o e-mail: ");
    pessoa.Email = Console.ReadLine()!;

    pessoas.Add(pessoa);
}

string json = JsonSerializer.Serialize(pessoas);

string nomeArquivo = $"pessoa.json";

File.WriteAllText(nomeArquivo, json);

Console.WriteLine($"Os dados foram salvos em {nomeArquivo}");

string arquivo = "pessoa.json";
if (File.Exists(nomeArquivo))
{
    string jsonArquivo = File.ReadAllText(nomeArquivo);
    List<Pessoa> pessoasLista = JsonSerializer.Deserialize<List<Pessoa>>(jsonArquivo);

    Console.WriteLine("Informações das pessoas:");
    foreach (Pessoa pessoa in pessoasLista)
    {
        Console.WriteLine($"Nome: {pessoa.Nome}\nIdade: {pessoa.Idade}\nE-mail: {pessoa.Email}");
    }
}
else
{
    Console.WriteLine($"O arquivo {nomeArquivo} não existe");
}