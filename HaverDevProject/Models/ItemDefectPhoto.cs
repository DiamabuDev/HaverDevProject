//Nigel Temple
//Revised January 18, 2024

using System.ComponentModel.DataAnnotations;

namespace HaverIndividualTest.Models
{
    public class ItemDefectPhoto
    {
        public int ID { get; set; }

        [Display(Name = "Defect Photo")]
        public byte[]? ItemDefectPhotoContent { get; set; } //fix?

        [StringLength(45)]
        public string? ItemDefectPhotoMimeType { get; set; }

        [Display(Name = "Defect Photo Description")]
        [StringLength(45, ErrorMessage = "There is a maximum of 45 characters allowed for the Defect Photo Description.")]
        public string? ItemDefectPhotoDescription { get; set; }

        //foreign key
        [Display(Name = "Item Defect")]
        [Required(ErrorMessage = "You must select an Item Defect.")]
        public int ItemDefectID { get; set; }
        public ItemDefect? ItemDefect { get; set; }
    }
}
