//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverDevProject.Models
{
    public class ReInspect
    {
        public int ID { get; set; }

        [Display(Name = "Reinspect Acceptable")]
        public bool ReInspectAcceptable { get; set; }

        [Display(Name = "Reinspection NCR Number")]
        public int? ReInspectNewNcrNumber { get; set; }

        [Display(Name = "Reinspection Date")]
        [Required(ErrorMessage = "You cannot leave Reinspection Date blank")]
        [DataType(DataType.DateTime)]
        public DateTime ReInspectCreationDate { get; set; }

        [Display(Name = "Reinspection Last Updated")]
        [DataType(DataType.DateTime)]
        public DateTime? ReInspectLastUpdated { get; set; }

        //Foreign Keys 

        [Display(Name = "User ")]
        [Required(ErrorMessage = "You must select an User")]
        public int UserID { get; set; }

        public User User { get; set; }

        [Display(Name = "NCR")]
        [Required(ErrorMessage = "You must select a NCR")]
        public int NcrID { get; set; }

        public Ncr Ncr { get; set; }
    }
}
