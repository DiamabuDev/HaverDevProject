using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("ncrEng")]
public partial class NcrEng
{
    [Key]
    [Column("ncrEngId")]
    public int NcrEngId { get; set; }

    [Column("ncrEngCustomerNotification")]
    public bool? NcrEngCustomerNotification { get; set; }

    [Column("ncrEngDispositionDescription")]
    [StringLength(300)]
    [Unicode(false)]
    public string NcrEngDispositionDescription { get; set; }

    [Column("ncrEngLastUpdated", TypeName = "datetime")]
    public DateTime NcrEngLastUpdated { get; set; }

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

    [ForeignKey("EngDispositionTypeId")]
    [InverseProperty("NcrEngs")]
    public virtual EngDispositionType EngDispositionType { get; set; }

    [ForeignKey("NcrId")]
    [InverseProperty("NcrEngs")]
    public virtual Ncr Ncr { get; set; }
}
