using ProjetoModelDDD.Domain.Entities;
using System.Data.Entity;

namespace ProjetoModelDDD.Infra.Data.Context
{
    public class ProjetoModeloContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public ProjetoModeloContext()
        : base("ProjetoModeloDDD")
        {

        }
    }
}
