using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.NewModels;

[Table("engDispositionType")]
public partial class EngDispositionType
{
    [Key]
    [Column("engDispositionTypeId")]
    public int EngDispositionTypeId { get; set; }

    [Column("engDispositionTypeName")]
    [StringLength(45)]
    [Unicode(false)]
    public string EngDispositionTypeName { get; set; } = null!;

    [InverseProperty("EngDispositionType")]
    public virtual ICollection<NcrEng> NcrEngs { get; set; } = new List<NcrEng>();
}
