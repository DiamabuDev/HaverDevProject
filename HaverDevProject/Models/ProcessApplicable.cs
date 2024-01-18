//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverDevProject.Models
{
    public class ProcessApplicable
    {
        public int ID { get; set; }

        [Display(Name="Process Applicable Name")]
        [Required(ErrorMessage ="You cannot leave Process Applicable Name blank")]
        [StringLength(45, ErrorMessage= "Process Applicable Name cannot be more than 45 characters long")]
        public string Name { get; set; }
    }
}
