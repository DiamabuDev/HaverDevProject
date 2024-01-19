//Nigel Temple
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverIndividualTest.Models
{
    public class PurchaseOrderDetail
    {
        public int ID { get; set; }

        [Display(Name = "Quantity Received")]
        [Required(ErrorMessage = "You must provide the Quantity Received.")]
        public int PurchaseOrderDetailQuanReceived { get; set; }

        [Display(Name = "Defective Quantity")]
        [Required(ErrorMessage = "You must provide the Defective Quantity.")]
        public int PurchaseOrderDetailQuanDefective { get; set; }

        //foreign keys
        [Display(Name = "Purchase Order")]
        [Required(ErrorMessage = "You must select a Purchase Order.")]
        public int PurchaseOrderID { get; set; }
        public PurchaseOrder? PurchaseOrder { get; set; }

        [Display(Name = "Item")]
        [Required(ErrorMessage = "You must select an Item.")]
        public int ItemID { get; set; }
        //public Item Item { get; set; }
    }
}
