using Microsoft.EntityFrameworkCore;
using ProdutosAPI.Models;

namespace ProdutosAPI.Data;

public class Connection : DbContext
{
    public Connection(DbContextOptions options) : base(options) {}

    public DbSet<Produto> Produtos { get; set; }
}
