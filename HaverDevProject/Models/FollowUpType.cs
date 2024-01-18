//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverDevProject.Models
{
    public class FollowUpType
    {
        public int ID { get; set; }

        [Display(Name = "Follow Up Type")]
        [Required(ErrorMessage = "You cannot leave Follow  Up Type blank")]
        [StringLength(45, ErrorMessage = "Follow Up Type cannot be more than 45 characters long")]
        public string Name { get; set; }
    }
}
