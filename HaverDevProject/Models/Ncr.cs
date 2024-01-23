using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("ncr")]
public partial class Ncr
{
    [Key]
    [Column("ncrId")]
    public int NcrId { get; set; }

    [Required(ErrorMessage = "You must provide the NCR Number.")]
    [Column("ncrNumber")]
    [StringLength(10, ErrorMessage = "The NCR Number cannot be more than 10 characters long.")]
    [Unicode(false)]
    public string NcrNumber { get; set; }

    [Required(ErrorMessage = "You must provide the last date the NCR was updated.")]
    [Column("ncrLastUpdated", TypeName = "datetime")]
    public DateTime NcrLastUpdated { get; set; }

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

    [Required(ErrorMessage = "You must provide the Status.")]
    [ForeignKey("StatusUpdateId")]
    [InverseProperty("Ncrs")]
    public virtual StatusUpdate StatusUpdate { get; set; }
}
