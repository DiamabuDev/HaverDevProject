using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("opDispositionType")]
public partial class OpDispositionType
{
    [Key]
    [Column("opDispositionTypeId")]
    public int OpDispositionTypeId { get; set; }

    [Required]
    [Column("opDispositionTypeName")]
    [StringLength(45)]
    [Unicode(false)]
    public string OpDispositionTypeName { get; set; }

    [InverseProperty("OpDispositionType")]
    public virtual ICollection<NcrPurchasing> NcrPurchasings { get; set; } = new List<NcrPurchasing>();
}
