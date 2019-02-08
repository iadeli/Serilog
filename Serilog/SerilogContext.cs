using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog
{
    public class SerilogContext : DbContext
    {
        public SerilogContext() : base("name=DbConnection")
        {
            Database.SetInitializer<SerilogContext>(new CreateDatabaseIfNotExists<SerilogContext>());
        }

        public DbSet<SerilogClass.Log> Logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LogEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
