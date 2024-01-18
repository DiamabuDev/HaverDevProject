//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverDevProject.Models
{
    public class OpDispositionType
    {
        public int ID { get; set; }

        [Display(Name = "Disposition Type")]
        [Required(ErrorMessage = "You cannot leave Disposition Type blank")]
        [StringLength(45, ErrorMessage = "Disposition Type cannot be more than 45 characters long")]
        public string Name { get; set; }
    }
}
