using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("ncrQA")]
public partial class NcrQa : IValidatableObject
{
    [Key]
    [Column("ncrQAId")]
    public int NcrQaid { get; set; }

    //Required?
    [Column("ncrQAItemMarNonConforming")]
    public bool NcrQaitemMarNonConforming { get; set; } = false;

    [Required(ErrorMessage = "You must provide the Sales Order.")]
    [Column("ncrQASalesOrder")]
    [StringLength(45)]
    [Unicode(false)]
    public string NcrQasalesOrder { get; set; }

    [Required(ErrorMessage = "You must provide the date the NCR was created.")]
    [Column("ncrQACreationDate", TypeName = "date")]
    public DateTime NcrQacreationDate { get; set; }

    [Required(ErrorMessage = "You must provide the last date the NCR was updated.")]
    [Column("ncrQALastUpdated", TypeName = "datetime")]
    public DateTime NcrQalastUpdated { get; set; }

    [Column("ncrQAUserId")]
    public int NcrQauserId { get; set; }

    [Column("proAppId")]
    public int ProAppId { get; set; }

    [Column("ncrId")]
    public int NcrId { get; set; }

    [Required(ErrorMessage = "You must provide the NCR.")]
    [ForeignKey("NcrId")]
    [InverseProperty("NcrQas")]
    public virtual Ncr Ncr { get; set; }

    [InverseProperty("NcrQa")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [Required(ErrorMessage = "You must provide the Applicable Process.")]
    [ForeignKey("ProAppId")]
    [InverseProperty("NcrQas")]
    public virtual ProcessApplicable ProApp { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (NcrQalastUpdated < NcrQacreationDate)
        {
            yield return new ValidationResult("The NCR cannot be updated before it was created.", new[] { "NcrQalastUpdated" });
        }
    }
}
