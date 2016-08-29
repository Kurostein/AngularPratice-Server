using PizzaStore.Data.Logger;
using PizzaStore.Data.Mappings;
using System;
using System.Data.Entity;

namespace PizzaStore.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext() : base("Data Source=CLOUDBUILT\\SQLEXPRESS; Initial Catalog=PizzaStore; Integrated Security=True; Connect Timeout=15; Encrypt=False; TrustServerCertificate=True; ApplicationIntent=ReadWrite; MultiSubnetFailover=False")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Database.Log = (sqlText => SqlLogger.WriteSql(sqlText));
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("PizzaStore");
            modelBuilder.Configurations.Add(new ClientMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
