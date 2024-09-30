using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tipos_especiais.Models
{
    public class TiposNulos
    {
        bool? desejaReceberEmail = null;

        if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
        {
            Console.WriteLine("O usuario optou por receber email");
        }
        else
        {
            Console.WriteLine("O usuario não respondeu ou optou por não receber o email");
        }
    }
}