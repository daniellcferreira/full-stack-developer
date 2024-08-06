// TUPLAS

(int, string, string) tupla = (1, "João", "Pedro");

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");

// Outras Sintaxe
ValueTuple<int, string, string> tupla2 = (1, "João", "Pedro");

var tupla3 = Tuple.Create(1, "João", "Pedro");



// Exemplo
LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, qtsLinhas) = arquivo.LerArquivo("arquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine($"Quantidade de linhas do arquivo: {qtsLinhas}");
    foreach (string linhas in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo");
}


// IF TERNARIO

int numero = 15;
bool ehPar = false;

ehPar = numero % 2 == 0;
Console.WriteLine($"O numero {numero} é " + (ehPar ? "par" : "impar"));