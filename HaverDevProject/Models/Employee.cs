//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;


namespace HaverDevProject.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You cannot leave First Name blank")]
        [StringLength(45, ErrorMessage = "First Name cannot be more than 45 characters long")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(45, ErrorMessage = "Middle Name cannot be more than 45 characters long")]
        public string? MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You cannot leave Last Name blank")]
        [StringLength(45, ErrorMessage = "Lsst Name cannot be more than 45 characters long")]
        public string LastName { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "You cannot leave E-mail blank")]
        [StringLength(45, ErrorMessage = "E-mail cannot be more than 45 characters long")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
