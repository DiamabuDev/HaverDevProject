//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;


namespace HaverDevProject.Models
{
    public class Drawing
    {
        public int ID { get; set; }

        [Display(Name = "Require Updating")]
        public byte? RequireUpdating { get; set; }

        [Display(Name = "Original Rev Number")]
        public int? OriginalRevNumber { get; set; }

        [Display(Name = "Updated Rev Number")]
        public int? UpdatedRevNumber { get; set; }

        [Display(Name = "Rev Date")]
        [DataType(DataType.Date)]
        public DateTime? RevDate { get; set; }

        //Foreign Key 

        [Display(Name = "User")]
        public int? UserID { get; set; }
        public User User { get; set; }
    }
}
