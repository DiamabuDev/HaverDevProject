using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("ncrQA")]
public partial class NcrQa
{
    [Key]
    [Column("ncrQAId")]
    public int NcrQaid { get; set; }

    [Column("ncrQAItemMarNonConforming")]
    public bool NcrQaitemMarNonConforming { get; set; }

    [Required]
    [Column("ncrQASalesOrder")]
    [StringLength(45)]
    [Unicode(false)]
    public string NcrQasalesOrder { get; set; }

    [Column("ncrQACreationDate", TypeName = "date")]
    public DateTime NcrQacreationDate { get; set; }

    [Column("ncrQALastUpdated", TypeName = "datetime")]
    public DateTime NcrQalastUpdated { get; set; }

    [Column("ncrQAUserId")]
    public int NcrQauserId { get; set; }

    [Column("proAppId")]
    public int ProAppId { get; set; }

    [Column("ncrId")]
    public int NcrId { get; set; }

    [ForeignKey("NcrId")]
    [InverseProperty("NcrQas")]
    public virtual Ncr Ncr { get; set; }

    [InverseProperty("NcrQa")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [ForeignKey("ProAppId")]
    [InverseProperty("NcrQas")]
    public virtual ProcessApplicable ProApp { get; set; }
}
