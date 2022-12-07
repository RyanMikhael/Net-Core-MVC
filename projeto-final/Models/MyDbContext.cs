using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace projeto_final.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options){}

        public DbSet<Consumidor> Consumidors {get;set;}
        public DbSet<Pedido> Pedidos {get;set;}
        public DbSet<Produto> Produtos {get;set;}
        public DbSet<Pagamento> Pagamentos{get;set;}
        public DbSet<Boleto> Boletos {get;set;}
        public DbSet<CartaoCredito> CartaoCreditos {get;set;}
    }
}
