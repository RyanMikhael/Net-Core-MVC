using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final.Models
{
    public class Pagamento
    {
        public int ID{get;set;}
        public int ValorPedido{get;set;}
        public bool Faturado{get;set;}

        public void confirmarPagamento(){}
    }
}