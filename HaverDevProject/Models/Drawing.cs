//Catalin Spirleanu
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;


namespace HaverDevProject.Models
{
    public class Drawing
    {
        public int ID { get; set; }

        public byte? RequireUpdating { get; set; }

        public int? OriginalRevNumber { get; set; }  

        public int? UpdatedRevNumber { get; set; }

        public DateTime? RevDate { get; set; }   

        //Foreign Key 

        public int? UserID { get; set; }
        public User User { get; set; }
    }
}
