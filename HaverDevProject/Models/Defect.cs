//Nigel Temple
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverIndividualTest.Models
{
    public class Defect
    {
        public int ID { get; set; }

        [Display(Name = "Defect Description")]
        [StringLength(45, ErrorMessage = "There is a maximum of 45 characters allowed for Defect Description.")]
        public string? DefectDescription { get; set; }
    }
}
