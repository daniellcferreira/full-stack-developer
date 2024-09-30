using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipos_especiais.Models
{
    public class TiposAnonimos
    {
        var tipoAnonimo = new {Nome = "Daniel", Sobrenome = "Ferreira", Altura = 1.78}

        Console.WriteLine("Nome: " + tipoAnonimo.Nome);
        Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
        Console.WriteLine("Altura: " + tipoAnonimo.Altura);

    }
}