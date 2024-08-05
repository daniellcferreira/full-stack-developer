// Exceções e Coleções

using excecoes_colecoes.Models;

try
{
    string[] linhas = File.ReadAllLines("arquivoLeitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção generica. {ex.Message}");
}
finally
{
    Console.WriteLine("Fim do programa...");
}


// Exemplo 2

new ExemploExcecao().Metodo1();


// FILAS

Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

fila.Dequeue();  // sempre será removido o primeiro elemento da fila


// PILHAS

Stack<int> pilha = new Stack<int>();
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

pilha.Pop();  // sempre será removido o elemento do topo da pilha


// DICTIONARY

Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

estados.Remove("RJ");  // removendo elemento

estados["SP"] = "São Paulo - valor alterado";  // alterando o valor do elemento

// verficando se existe chave dentro do dictonary
string chave = "MG";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else 
{
    Console.WriteLine($"Valor não existe, permitido a adição da chave: {chave}");
}