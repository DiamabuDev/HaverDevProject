using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("ncrEng")]
public partial class NcrEng : IValidatableObject
{
    [Key]
    [Column("ncrEngId")]
    public int NcrEngId { get; set; }

    //Required?
    [Column("ncrEngCustomerNotification")]
    public bool? NcrEngCustomerNotification { get; set; } = false;

    [Column("ncrEngDispositionDescription")]
    [StringLength(300)]
    [Unicode(false)]
    public string NcrEngDispositionDescription { get; set; }

    [Required(ErrorMessage = "You must provide the last date the NCR was updated.")]
    [Column("ncrEngLastUpdated", TypeName = "datetime")]
    public DateTime NcrEngLastUpdated { get; set; }

    [Required(ErrorMessage = "You must provide the date the NCR was created.")]
    [Column("ncrEngCreationDate", TypeName = "date")]
    public DateTime NcrEngCreationDate { get; set; }

    [Column("ncrEngUserId")]
    public int NcrEngUserId { get; set; }

    [Column("engDispositionTypeId")]
    public int EngDispositionTypeId { get; set; }

    [Column("ncrId")]
    public int NcrId { get; set; }

    [InverseProperty("NcrEng")]
    public virtual ICollection<Drawing> Drawings { get; set; } = new List<Drawing>();

    [Required(ErrorMessage = "You must provide the Disposition Type.")]
    [ForeignKey("EngDispositionTypeId")]
    [InverseProperty("NcrEngs")]
    public virtual EngDispositionType EngDispositionType { get; set; }

    [Required(ErrorMessage = "You must provide the NCR.")]
    [ForeignKey("NcrId")]
    [InverseProperty("NcrEngs")]
    public virtual Ncr Ncr { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (NcrEngLastUpdated < NcrEngCreationDate)
        {
            yield return new ValidationResult("The NCR cannot be updated before it was created.", new[] { "NcrEngLastUpdated" });
        }
    }
}
