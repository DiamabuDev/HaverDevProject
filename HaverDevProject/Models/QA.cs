using System.ComponentModel.DataAnnotations;

//Nigel Temple
//Revised January 18, 2024

namespace HaverIndividualTest.Models
{
    public class QA
    {
        public int ID { get; set; }

        //??
        public bool QAItemMarNonConforming { get; set; }

        [Required(ErrorMessage = "You must enter a creation date and time for the NCR.")]
        [Display(Name = "Creation Date")]
        [DataType(DataType.DateTime)]
        public DateTime QACreationDate { get; set; }

        [Display(Name = "Last Updated")]
        [StringLength(45, ErrorMessage = "There is a maximum of 45 characters allowed for Last Updated value.")]
        public string? QALastUpdated { get; set; }

        //forgeign keys
        [Display(Name = "Applicable Process")]
        [Required(ErrorMessage = "You must select an Applicable Process.")]
        public int ProcessApplicableID { get; set; }
        //public ProcessApplicable ProcessApplicable { get; set; }

        [Display(Name = "Supplier")]
        [Required(ErrorMessage = "You must select a Supplier.")]
        public int SupplierID { get; set; }
        //public Supplier Supplier { get; set; }

        [Display(Name = "Purchase Order")]
        [Required(ErrorMessage = "You must select a Purchase Order.")]
        public int PurchaseOrderID { get; set; }
        //public PurchaseOrder? PurchaseOrder { get; set; }

        [Display(Name = "Product Number")]
        [Required(ErrorMessage = "You must select a Product Number.")]
        public int ProductNumberID { get; set; }
        //public ProductNumber? ProductNumber { get; set; }

        [Display(Name = "User")]
        [Required(ErrorMessage = "You must select a User.")]
        public int UserID { get; set; }
        //public User User { get; set; }

        [Display(Name = "NCR")]
        [Required(ErrorMessage = "You must select an NCR.")]
        public int NCRID { get; set; }
        //public NCR NCR { get; set; }
    }
}
