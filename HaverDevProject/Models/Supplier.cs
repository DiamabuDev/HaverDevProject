//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverDevProject.Models
{
    public class Supplier
    {

        public int ID { get; set; }

        [Display(Name="Supplier Code")]
        [Required(ErrorMessage ="You cannot leave Supplier Code blank")]
        [StringLength(45, ErrorMessage = "Supplier Code cannot be more than 45 characters long")]
        public string Code { get; set; }

        [Display(Name="Supplier Name")]
        [Required(ErrorMessage ="You cannot leave Supplier Name blank")]
        [StringLength(45, ErrorMessage = "Supplier Name cannot be more than 45 characters long")]
        public string Name { get; set; }

        [Display(Name="Supplier E-mail")]
        [StringLength(45, ErrorMessage = "Supplier E-mail cannot be more than 45 characters long")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

    }
}


