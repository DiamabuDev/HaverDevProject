using System.ComponentModel.DataAnnotations;

//Nigel Temple
//Revised January 18, 2024

namespace HaverIndividualTest.Models
{
    public class PurchaseOrder
    {
        public int ID { get; set; }

        [Display(Name = "Purchase Order Number")]
        [Required(ErrorMessage = "You must provide a Purchase Order Number.")]
        [StringLength(15, ErrorMessage = "Order Number cannot be more than 30 characters long.")]
        public string? PurchaseOrderNumber { get; set; }
    }
}