using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_poo.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        public override void InstalarApp(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo... \"{nomeApp}\" no Nokia.");
        }
    }
}