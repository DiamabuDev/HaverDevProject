using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("ncrReInspect")]
public partial class NcrReInspect : IValidatableObject
{
    [Key]
    [Column("ncrReInspectId")]
    public int NcrReInspectId { get; set; }

    //Required?
    [Column("ncrReInspectAcceptable")]
    public bool NcrReInspectAcceptable { get; set; } = false;

    [Column("ncrReInspectNewNcrNumber")]
    public int? NcrReInspectNewNcrNumber { get; set; }

    [Required(ErrorMessage = "You must provide the date the NCR was created.")]
    [Column("ncrReInspectCreationDate", TypeName = "date")]
    public DateTime NcrReInspectCreationDate { get; set; }

    [Required(ErrorMessage = "You must provide the last date the NCR was updated.")]
    [Column("ncrReInspectLastUpdated", TypeName = "datetime")]
    public DateTime NcrReInspectLastUpdated { get; set; }

    [Column("ncrReInspectUserId")]
    public int NcrReInspectUserId { get; set; }

    [Column("ncrId")]
    public int NcrId { get; set; }

    [Required(ErrorMessage = "You must provide the NCR.")]
    [ForeignKey("NcrId")]
    [InverseProperty("NcrReInspects")]
    public virtual Ncr Ncr { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (NcrReInspectLastUpdated < NcrReInspectCreationDate)
        {
            yield return new ValidationResult("The NCR cannot be updated before it was created.", new[] { "NcrReInspectLastUpdated" });
        }
    }
}
