//Nigel Temple
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverIndividualTest.Models
{
    public class Item
    {
        public int ID { get; set; }

        [Display(Name = "Item Number")]
        [Range(1, 8, ErrorMessage = "Item Number must be less than eight.")] //??
        [Required(ErrorMessage = "You must provide the Item Number.")]
        public int ItemNumber { get; set; }

        [Display(Name = "Item Description")]
        [Required(ErrorMessage = "You must provide the Item Number.")]
        [StringLength(45, ErrorMessage = "There is a maximum of 45 characters allowed for Item Description.")]
        public string? ItemDescription { get; set; }

        //foreign key
        [Display(Name = "Supplier")]
        [Required(ErrorMessage = "You must select a Supplier.")]
        public int SupplierID { get; set; }
        //public Supplier Supplier { get; set; }
    }
}
