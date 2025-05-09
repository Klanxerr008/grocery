using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grocery.Models
{
    public class Products
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

       
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }


        public decimal Price { get; set; }


        public int Stock { get; set; }

    }
}
