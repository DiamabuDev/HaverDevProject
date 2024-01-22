using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("statusUpdate")]
public partial class StatusUpdate
{
    [Key]
    [Column("statusUpdateId")]
    public int StatusUpdateId { get; set; }

    [Required]
    [Column("statusUpdateName")]
    [StringLength(45)]
    [Unicode(false)]
    public string StatusUpdateName { get; set; }

    [InverseProperty("StatusUpdate")]
    public virtual ICollection<Ncr> Ncrs { get; set; } = new List<Ncr>();
}
