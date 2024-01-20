using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.NewModels;

[Table("defect")]
public partial class Defect
{
    [Key]
    [Column("defectId")]
    public int DefectId { get; set; }

    [Column("defectName")]
    [StringLength(45)]
    [Unicode(false)]
    public string DefectName { get; set; } = null!;

    [InverseProperty("Defect")]
    public virtual ICollection<ItemDefect> ItemDefects { get; set; } = new List<ItemDefect>();
}
