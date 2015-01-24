using Projeto.Business.Entities;
using Projeto.Data.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projeto.Data
{
    public class Context : DbContext
    {
        public Context()
            : base("name=CNN")
        {
        }

        public DbSet<Aluno> Aluno { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new AlunoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
