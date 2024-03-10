using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lanchonete.Models
{
    public class Lanche 
    {
        public Lanche(int codigo, string especificacao, decimal preco) {
            Codigo = codigo;
            Especificacao = especificacao;
            Preco = preco;
        }
        
         public int Codigo { get; set; }
         public string Especificacao { get; set; }
         public decimal Preco { get; set; }
    }
}