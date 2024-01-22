using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("followUp")]
public partial class FollowUp
{
    [Key]
    [Column("followUpId")]
    public int FollowUpId { get; set; }

    [Column("followUpExpectedDate", TypeName = "date")]
    public DateTime FollowUpExpectedDate { get; set; }

    [Column("followUpTypeId")]
    public int FollowUpTypeId { get; set; }

    [Column("ncrPurchId")]
    public int NcrPurchId { get; set; }

    [ForeignKey("FollowUpTypeId")]
    [InverseProperty("FollowUps")]
    public virtual FollowUpType FollowUpType { get; set; }

    [ForeignKey("NcrPurchId")]
    [InverseProperty("FollowUps")]
    public virtual NcrPurchasing NcrPurch { get; set; }
}
