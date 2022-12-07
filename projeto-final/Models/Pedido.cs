using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_final.Models
{
    public class Pedido
    {
        public int ID{get;set;}
        [Required]
        public DateTime DataPedido{get;set;}
        public virtual List<Produto>? Itens{get;set;}
        [ForeignKey("Consumidor")]
        public int IdConsumidor{get;set;}
        public Consumidor? Consumidor{get;set;}  

        public void incluirProduto(Produto produto){}
        public void excluirProduto(Produto produto){}
    }
}