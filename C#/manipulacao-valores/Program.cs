// Manipulação de Valores

decimal valorMonetario = 1582.40M;
Console.WriteLine(valorMonetario.ToString("C"));

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));


DateTime data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());
