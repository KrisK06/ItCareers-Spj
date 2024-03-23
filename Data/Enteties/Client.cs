using System.ComponentModel.DataAnnotations;

namespace CarService.Data.Enteties
{
    public class Client
    {
        [Key]
        public string  Name { get; set; }

        [Required]

        public string LastName { get; set; }

        [Required]
        public int CarNumber { get; set; }



    }
}
