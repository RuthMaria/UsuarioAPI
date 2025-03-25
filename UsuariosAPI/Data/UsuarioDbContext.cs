using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsuariosAPI.Models;

namespace UsuariosAPI.Data;

public class UsuarioDbContext : IdentityDbContext<Usuario>
{
    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=usuariodb;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

    public UsuarioDbContext(DbContextOptions<UsuarioDbContext> opts) : base(opts) { }
}
