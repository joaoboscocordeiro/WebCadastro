using Microsoft.EntityFrameworkCore;
using WebCadastro.Models.Pessoa;

namespace WebCadastro.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
