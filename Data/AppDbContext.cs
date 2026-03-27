using Microsoft.EntityFrameworkCore;
using CrudMvcMySql.Models;

namespace CrudMvcMySql.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) 
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
