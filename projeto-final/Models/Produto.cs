using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_final.Models
{
    public class Produto
    {
        public int ID{get;set;}
        public string Nome{get;set;}
        public string Descricao{get;set;}
        public double Valor{get;set;}
        public int Quantidade{get;set;}
        
        [ForeignKey("PedidoAtual")]
        public int IdPedido{get;set;}
        public Pedido? PedidoAtual{get;set;}
    }
}