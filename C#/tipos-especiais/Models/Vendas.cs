using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace tipos_especiais.Models
{
    public class Vendas
    {
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }

        public decimal Preco { get; set; }

        public decimal? Desconto { get; set; }
    }
}