using Microsoft.EntityFrameworkCore;
using WorkList.Models;


namespace WorkList.Context
{
    public class OrganizadorContext : DbContext
    {

        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) { }

        public DbSet<Tarefas> Tarefas { get; set; }
    }
}
