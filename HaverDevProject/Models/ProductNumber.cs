using System.ComponentModel.DataAnnotations;

//Nigel Temple
//Revised January 18, 2024

namespace HaverIndividualTest.Models
{
    public class ProductNumber
    {
        public int ID { get; set; }

        [Display(Name = "Product Number")]
        [StringLength(15, ErrorMessage = "Product Number cannot be more than 30 characters long.")]
        public string? Product_Number { get; set; } //???
    }
}
