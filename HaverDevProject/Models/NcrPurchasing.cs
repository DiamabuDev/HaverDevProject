using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("ncrPurchasing")]
public partial class NcrPurchasing
{
    [Key]
    [Column("ncrPurchId")]
    public int NcrPurchId { get; set; }

    [Column("ncrPurchCreationDate", TypeName = "date")]
    public DateTime NcrPurchCreationDate { get; set; }

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

    [ForeignKey("NcrId")]
    [InverseProperty("NcrPurchasings")]
    public virtual Ncr Ncr { get; set; }

    [ForeignKey("OpDispositionTypeId")]
    [InverseProperty("NcrPurchasings")]
    public virtual OpDispositionType OpDispositionType { get; set; }
}
