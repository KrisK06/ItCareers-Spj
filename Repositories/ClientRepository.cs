using CarService.Data.Enteties;
using CarService.Repositories.Interface;

namespace CarService.Repositories
{
    public class ClientRepository : IClientrepository
    {

        private readonly ApplicationContext context;

        public ClientRepository(ApplicationContext context)
        {

            this.context = context;
        }


        public void Add(Client client)
        {
            context.Clients.Add(client);
            context.SaveChanges(); 
        }
    }
}
