using System.Data.Entity;

namespace PizzaStore.Data
{
    public class ModelConfiguration : DbConfiguration
    {
        public ModelConfiguration()
        {
            this.SetDatabaseInitializer<PizzaContext>(null);
        }
    }
}
