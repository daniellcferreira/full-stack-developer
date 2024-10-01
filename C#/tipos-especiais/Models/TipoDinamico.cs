using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipos_especiais.Models
{
    public class TipoDinamico
    {
        dynamic variavelDinamica = 4;

        Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, valor: {variavelDinamica}")

        variavelDinamica = "Texto";

        Console.WriteLine($"Tipo de variavel: {variavelDinamica.GetType()}, valor: {variavelDinamica}")
    }
}