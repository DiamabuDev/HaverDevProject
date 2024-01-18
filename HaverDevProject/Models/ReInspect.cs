//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverDevProject.Models
{
    public class ReInspect
    {
        public int ID { get; set; }

        public bool ReInspectAcceptable { get; set; }

        public int? ReInspectNewNcrNumber { get; set; }

        public DateTime ReInspectCreationDate { get; set; }

        public DateTime? ReInspectLastUpdated { get; set; }

        //Foreign Keys 

        public int UserID { get; set; }

        public User User { get; set; }

        public int NcrID { get; set; }

        public Ncr Ncr { get; set; }
    }
}
