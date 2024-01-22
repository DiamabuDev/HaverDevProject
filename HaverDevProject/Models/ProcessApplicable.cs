using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("processApplicable")]
public partial class ProcessApplicable
{
    [Key]
    [Column("proAppId")]
    public int ProAppId { get; set; }

    [Required]
    [Column("proAppName")]
    [StringLength(45)]
    [Unicode(false)]
    public string ProAppName { get; set; }

    [InverseProperty("ProApp")]
    public virtual ICollection<NcrQa> NcrQas { get; set; } = new List<NcrQa>();
}
