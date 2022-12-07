using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final.Models
{
    public class Boleto: Pagamento
    {
        public string Codigo{get;set;}
        public virtual Pedido? Pedido{get;set;}
    }
}