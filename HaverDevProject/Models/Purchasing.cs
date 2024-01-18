//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverDevProject.Models
{
    public class Purchasing
    {
        public int ID { get; set; }

        public bool PurchCARRaised { get; set; }

        public int? PurchasingCARNumber { get; set; }    

        public bool PurchFollowReq { get; set; }

        public DateTime? PurchExpDate { get; set; }

        public DateTime? PurchCreationDate { get; set; }

        public DateTime? PurchasingLastUpdated { get; set; }

        //Foreign Keys 
        public int OpDispositionTypeID { get; set; }

        public OpDispositionType OpDispositionType { get; set; }

        public int UserID { get; set; }
        public User User { get; set; }

        public int NcrID { get; set; }  

        public Ncr Ncr { get; set; }

        public int? FollowUpTypeID {  get; set; }
        public FollowUpType FollowUpType { get; set; }

    }
}
