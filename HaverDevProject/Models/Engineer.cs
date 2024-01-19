//Nigel Temple
//Revised January 18, 2024

using HaverDevProject.Models;
using System.ComponentModel.DataAnnotations;

namespace HaverIndividualTest.Models
{
    public class Engineer
    {
        public int ID { get; set; }

        [Display(Name = "Customer Notification")]
        public bool CustomerNotification { get; set; }

        [Display(Name = "Item Description")]
        [StringLength(300, ErrorMessage = "There is a maximum of 300 characters allowed for the Disposition Description.")]
        public string? DispositionDescription { get; set; }

        [Display(Name = "Drawing Update")]
        public bool DrawingUpdate { get; set; }

        [Display(Name = "Original Review Number")]
        public int OriginalReviewNumber { get; set; }

        [Display(Name = "Last Updated")]
        public int LastUpdated { get; set; }

        [Display(Name = "Revision Date")]
        [DataType(DataType.DateTime)]
        public DateTime? RevDate { get; set; }

        [Required(ErrorMessage = "You must enter a creation date and time.")]
        [Display(Name = "Creation Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Engineering")]
        [Required(ErrorMessage = "You must provide the Engineering.")] //??
        [StringLength(45, ErrorMessage = "There is a maximum of 45 characters allowed for Engineering.")]
        public string? Engineering { get; set; } //??

        //foreign keys
        [Display(Name = "Disposition Type")]
        [Required(ErrorMessage = "You must select a Disposition Type.")]
        public int DispositionTypeID { get; set; }
        public EngineerDispositionType? EngineerDispositionType { get; set; }

        [Display(Name = "User")]
        [Required(ErrorMessage = "You must select a User.")]
        public int UserID { get; set; }
        public User? User { get; set; }

        [Display(Name = "NCR")]
        [Required(ErrorMessage = "You must select an NCR.")]
        public int NCRID { get; set; }
        public Ncr? NCR { get; set; }
    }
}
