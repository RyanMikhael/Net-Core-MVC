using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_final.Models
{
    public class Consumidor
    {
        public int ID{get; set;}
        [Required(ErrorMessage ="Informe o nome do usuário")]
        public string Nome{get; set;}
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        [Required(ErrorMessage ="O email deve ter menos de 50 caracteres")]
        [MaxLength(50)]
        public string Email{get; set;}
        [Required(ErrorMessage ="A senha deve ter no mínimo 8 caracteres")]
        [MinLength(8)]
        [MaxLength(50)]
        public string Senha{get; set;}
        [Required]
        public string Endereço{get; set;}
        [Required]
        [MaxLength(14)]
        [MinLength(14)]
        public string Cpf{get;set;}
        public virtual List<Pedido>? Pedidos{get;set;}
    }
}