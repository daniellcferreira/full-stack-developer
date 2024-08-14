using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        // usar a data no historico
        private string data;

        //construtor
        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int a, int b)
        {
            int resultado = a + b;
            listaHistorico.Insert(0, $"resultado {resultado} - data:  {data}");
            return resultado;
        }

        public int Subtrair(int a, int b)
        {
            int resultado = a - b;
            listaHistorico.Insert(0, $"resultado {resultado} - data:  {data}");
            return resultado;
        }

        public int multiplicar(int a, int b)
        {
            int resultado = a * b;
            listaHistorico.Insert(0, $"resultado {resultado} - data:  {data}");
            return resultado;
        }

        public int dividir(int a, int b)
        {
            int resultado = a / b;
            listaHistorico.Insert(0, $"resultado {resultado} - data:  {data}");
            return resultado;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }

    }
}
