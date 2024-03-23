using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CarService.Data.Enteties
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Client> Clients { get; set; }



        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

           



        }

         
    }

}
