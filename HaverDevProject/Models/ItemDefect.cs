//Nigel Temple
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverIndividualTest.Models
{
    public class ItemDefect
    {
        public int ID { get; set; }

        //foreign keys
        [Display(Name = "Defect")]
        [Required(ErrorMessage = "You must select a Defect.")]
        public int DefectID { get; set; }
        //public Defect? Defect { get; set; }

        [Display(Name = "Item")]
        [Required(ErrorMessage = "You must select an Item.")]
        public int ItemID { get; set; }
        public Item? Item { get; set; }
    }
}
