using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final.Models
{
    public class CartaoCredito: Pagamento
    {
        public string NumeroCartao{get;set;}
        public virtual Pedido? Pedido{get;set;}
    }
}