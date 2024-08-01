// Exemplos operadores condicionais

int quantidadeEstoque = 15;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É pessivel realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda invalida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe não temos a quantidade em estoque");
}


// Switch case

Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

switch (letra)  
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é uma vogal");
        break;
}

