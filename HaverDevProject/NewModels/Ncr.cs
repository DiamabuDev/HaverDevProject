using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.NewModels;

[Table("ncr")]
public partial class Ncr
{
    [Key]
    [Column("ncrId")]
    public int NcrId { get; set; }

    [Column("ncrNumber")]
    [StringLength(10)]
    [Unicode(false)]
    public string NcrNumber { get; set; } = null!;

    [Column("ncrLastModified", TypeName = "datetime")]
    public DateTime NcrLastModified { get; set; }

    [Column("statusUpdateId")]
    public int StatusUpdateId { get; set; }

    [InverseProperty("Ncr")]
    public virtual ICollection<NcrEng> NcrEngs { get; set; } = new List<NcrEng>();

    [InverseProperty("Ncr")]
    public virtual ICollection<NcrPurchasing> NcrPurchasings { get; set; } = new List<NcrPurchasing>();

    [InverseProperty("Ncr")]
    public virtual ICollection<NcrQa> NcrQas { get; set; } = new List<NcrQa>();

    [InverseProperty("Ncr")]
    public virtual ICollection<NcrReInspect> NcrReInspects { get; set; } = new List<NcrReInspect>();

    [ForeignKey("StatusUpdateId")]
    [InverseProperty("Ncrs")]
    public virtual StatusUpdate StatusUpdate { get; set; } = null!;
}
