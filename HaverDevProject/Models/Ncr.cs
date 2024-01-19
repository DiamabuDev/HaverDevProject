//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverDevProject.Models
{
    public class Ncr
    {
        public int ID { get; set; }

        [Display(Name = "NCR Number")]
        [Required(ErrorMessage = "You cannot leave NCR Number blank")]
        [StringLength(10, ErrorMessage = "NCR Number cannot be more than 10 characters long")]
        public string Number { get; set; }

        [Display(Name = "Status")]
        public bool Status { get; set; }

        [Display(Name = "Last Modified")]
        [DataType(DataType.Date)]
        public DateTime? LastModified { get; set; }

        [Display(Name = "Quality Department")]
        [StringLength(45, ErrorMessage = "Quality Department cannot be more than 45 characters long")]

        public string? QualityDepartment { get; set; }

    }
}
