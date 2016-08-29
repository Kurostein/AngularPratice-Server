using PizzaStore.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PizzaStore.Data.Mappings
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            ToTable("dbo.Client");
            HasKey(c => c.Id);
            Property(c => c.Id).HasColumnName("id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name).HasColumnName("name");
            Property(c => c.Tel).HasColumnName("tel");
        }
    }
}
