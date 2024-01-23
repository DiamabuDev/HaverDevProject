using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("ncrPurchasing")]
public partial class NcrPurchasing : IValidatableObject
{
    [Key]
    [Column("ncrPurchId")]
    public int NcrPurchId { get; set; }

    [Required(ErrorMessage = "You must provide the date the NCR was created.")]
    [Column("ncrPurchCreationDate", TypeName = "date")]
    public DateTime NcrPurchCreationDate { get; set; }

    [Required(ErrorMessage = "You must provide the last date the NCR was updated.")]
    [Column("ncrPurchasingLastUpdated", TypeName = "datetime")]
    public DateTime NcrPurchasingLastUpdated { get; set; }

    [Column("ncrPurchasingUserId")]
    public int NcrPurchasingUserId { get; set; }

    [Column("opDispositionTypeId")]
    public int OpDispositionTypeId { get; set; }

    [Column("ncrId")]
    public int NcrId { get; set; }

    [InverseProperty("NcrPurch")]
    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    [InverseProperty("NcrPurch")]
    public virtual ICollection<FollowUp> FollowUps { get; set; } = new List<FollowUp>();

    [Required(ErrorMessage = "You must provide the NCR.")]
    [ForeignKey("NcrId")]
    [InverseProperty("NcrPurchasings")]
    public virtual Ncr Ncr { get; set; }

    [Required(ErrorMessage = "You must provide the Disposition Type.")]
    [ForeignKey("OpDispositionTypeId")]
    [InverseProperty("NcrPurchasings")]
    public virtual OpDispositionType OpDispositionType { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (NcrPurchasingLastUpdated < NcrPurchCreationDate)
        {
            yield return new ValidationResult("The NCR cannot be updated before it was created.", new[] { "NcrPurchasingLastUpdated" });
        }
    }
}
