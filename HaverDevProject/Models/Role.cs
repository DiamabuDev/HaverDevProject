//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverDevProject.Models
{
    public class Role
    {
        public int ID { get; set; }

        [Display(Name = "Role")]
        [Required(ErrorMessage = "You cannot leave Role blank")]
        [StringLength(45, ErrorMessage = "Role cannot be more than 45 characters long")]
        public string Name { get; set; }
    }
}
