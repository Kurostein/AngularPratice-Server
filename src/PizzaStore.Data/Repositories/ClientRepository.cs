using PizzaStore.Data.Entities;
using System;

namespace PizzaStore.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private readonly PizzaContext _context;
        public ClientRepository(PizzaContext context) : base(context)
        {
            _context = context;
        }
    }        
}
