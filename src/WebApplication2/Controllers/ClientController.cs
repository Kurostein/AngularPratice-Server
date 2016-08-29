using Microsoft.AspNetCore.Mvc;
using PizzaStore.Data.Entities;
using PizzaStore.Data.Repositories;

namespace WebApplication2.Controllers
{
    [Route("[controller]")]
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        public ClientController(IClientRepository repository)
        {
            _clientRepository = repository;
        }

        [HttpPost]
        public void Add([FromBody]Client client)
        {
            _clientRepository.Add(client);
        }

        [HttpGet]
        public IActionResult List()
        {
            return Json(_clientRepository.List());
        }

        [HttpGet("{id:int}")]
        public IActionResult Find(int id)
        {
            return Json(_clientRepository.Find(id));
        }

        [HttpPut]
        public void Update([FromBody]Client client)
        {
            _clientRepository.Update(client);
        }

        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            Client client = new Client()
            {
                Id = id
            };

            _clientRepository.Delete(client);
        }
    }
}
