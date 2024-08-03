// Arrays

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

// percorrendo o Array com o FOR
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
   Console.WriteLine($"Posição n° {contador} - {arrayInteiros[contador]}"); 
}

// percorrendo o Array com o FOREACH
int contadorForeach = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição n° {contadorForeach} - {valor}");
    contadorForeach++;
}

// redimensionando o Array
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// copiando um Array para o outro
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// Listas
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição n° {contador} - {listaString[contador]}");    
}

int contadorForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição n° {contadorForeach} - {item}");
}