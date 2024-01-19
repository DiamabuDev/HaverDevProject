//Nigel Temple
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverIndividualTest.Models
{
    public class EngineerDispositionType
    {
        public int ID { get; set; }

        [Display(Name = "Disposition Name")]
        [StringLength(45, ErrorMessage = "There is a maximum of 45 characters allowed for the Disposition Name.")]
        public string? EngineeringDispositionTypeName { get; set; }
    }
}
