//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverDevProject.Models
{
    public class Purchasing
    {
        public int ID { get; set; }

        [Display(Name = "CAR Raised")]
        public bool PurchCARRaised { get; set; }

        [Display(Name = "CAR Number")]
        public int? PurchasingCARNumber { get; set; }

        [Display(Name = "Follow up Required")]
        public bool PurchFollowReq { get; set; }

        [Display(Name = "Expiry Date")]
        [DataType(DataType.Date)]
        public DateTime? PurchExpDate { get; set; }

        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime? PurchCreationDate { get; set; }

        [Display(Name = "Last Updated")]
        [DataType(DataType.DateTime)]
        public DateTime? PurchasingLastUpdated { get; set; }

        //Foreign Keys 

        [Display(Name = "Disposition Type")]
        [Required(ErrorMessage = "You must select an Disposition Type")]
        public int OpDispositionTypeID { get; set; }

        public OpDispositionType OpDispositionType { get; set; }

        [Display(Name = "User")]
        [Required(ErrorMessage = "You must select an User")]
        public int UserID { get; set; }
        public User User { get; set; }

        [Display(Name = "NCR")]
        [Required(ErrorMessage = "You must select a NCR")]
        public int NcrID { get; set; }  

        public Ncr Ncr { get; set; }

        [Display(Name = "Follow Up Type")]
        public int? FollowUpTypeID {  get; set; }
        public FollowUpType FollowUpType { get; set; }

    }
}
