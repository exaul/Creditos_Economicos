using Creditos_Ecomicos_2024.Models;
using Microsoft.EntityFrameworkCore;

namespace Creditos_Ecomicos_2024.Data
{
    public class CreditosDbContext : DbContext
    {
        public CreditosDbContext(DbContextOptions<CreditosDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetalleDelPedido { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
