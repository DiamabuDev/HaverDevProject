//Nigel Temple
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverIndividualTest.Models
{
    public class PurchaseOrderDetailDefects
    {
        public int ID { get; set; }

        //foreign keys
        [Display(Name = "Purchase Order Detail")]
        [Required(ErrorMessage = "You must select a Purchase Order Detail.")]
        public int PurchaseOrderDetailID { get; set; }
        public PurchaseOrderDetail? PurchaseOrderDetail { get; set; }

        [Display(Name = "Item Defect")]
        [Required(ErrorMessage = "You must select an Item Defect.")]
        public int ItemDefectID { get; set; }
        public ItemDefect? ItemDefect { get; set; }
    }
}
