using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog
{
    public class LogEntityConfiguration : EntityTypeConfiguration<SerilogClass.Log>
    {
        public LogEntityConfiguration()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Message).IsOptional();
            this.Property(c => c.MessageTemplate).IsOptional();
            this.Property(c => c.Level).IsOptional().HasMaxLength(128);
            this.Property(c => c.TimeStamp).IsRequired();
            this.Property(c => c.Exception).IsOptional();
            this.Property(c => c.Properties).IsOptional();
        }
    }
}
