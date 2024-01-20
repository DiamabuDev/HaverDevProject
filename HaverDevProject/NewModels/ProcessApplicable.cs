using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.NewModels;

[Table("processApplicable")]
public partial class ProcessApplicable
{
    [Key]
    [Column("proAppId")]
    public int ProAppId { get; set; }

    [Column("proAppName")]
    [StringLength(45)]
    [Unicode(false)]
    public string ProAppName { get; set; } = null!;

    [InverseProperty("ProApp")]
    public virtual ICollection<NcrQa> NcrQas { get; set; } = new List<NcrQa>();
}
