using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.NewModels;

[Table("ncrReInspect")]
public partial class NcrReInspect
{
    [Key]
    [Column("ncrReInspectId")]
    public int NcrReInspectId { get; set; }

    [Column("ncrReInspectAcceptable")]
    public bool NcrReInspectAcceptable { get; set; }

    [Column("ncrReInspectNewNcrNumber")]
    public int? NcrReInspectNewNcrNumber { get; set; }

    [Column("ncrReInspectCreationDate", TypeName = "date")]
    public DateTime NcrReInspectCreationDate { get; set; }

    [Column("ncrReInspectLastUpdated", TypeName = "datetime")]
    public DateTime NcrReInspectLastUpdated { get; set; }

    [Column("ncrReInspectUserId")]
    public int? NcrReInspectUserId { get; set; }

    [Column("ncrId")]
    public int NcrId { get; set; }

    [ForeignKey("NcrId")]
    [InverseProperty("NcrReInspects")]
    public virtual Ncr Ncr { get; set; } = null!;
}
