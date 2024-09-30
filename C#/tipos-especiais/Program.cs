using Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivo/venda.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " + $"Preços: {venda.Preco} " + $"Desconto: {venda.Desconto}");
}