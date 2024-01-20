using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.NewModels;

[Table("statusUpdate")]
public partial class StatusUpdate
{
    [Key]
    [Column("statusUpdateId")]
    public int StatusUpdateId { get; set; }

    [Column("statusUpdateName")]
    [StringLength(45)]
    [Unicode(false)]
    public string StatusUpdateName { get; set; } = null!;

    [InverseProperty("StatusUpdate")]
    public virtual ICollection<Ncr> Ncrs { get; set; } = new List<Ncr>();
}
