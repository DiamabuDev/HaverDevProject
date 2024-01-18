//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverDevProject.Models
{
    public class User
    {
        public int ID { get; set; }

        //Foreign Keys 

        [Display(Name ="Role")]
        [Required(ErrorMessage ="You must select a Role")]
        public int RoleID { get; set; }

        public Role Role { get; set; }

        [Display(Name ="Employee")]
        [Required(ErrorMessage ="you must select an Employee")]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

    }
}
