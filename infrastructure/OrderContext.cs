namespace lojawahoo.trayDataload.Infrastructure
{
    using Microsoft.EntityFrameworkCore;

    public class OrderContext : DbContext
    {
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=wahoo;Username=wahoo;Password=wahoo");
    }

    public class Pedidos
    {
         public string codigo { get; set; }
    }
}