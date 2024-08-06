using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tuplas_operadoreTernario.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QtsLinhas) LerArquivo(String caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }
            

        }
    }
}