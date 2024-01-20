using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.NewModels;

[Table("car")]
public partial class Car
{
    [Key]
    [Column("carId")]
    public int CarId { get; set; }

    [Column("carNumber")]
    public int CarNumber { get; set; }

    [Column("ncrPurchId")]
    public int NcrPurchId { get; set; }

    [ForeignKey("NcrPurchId")]
    [InverseProperty("Cars")]
    public virtual NcrPurchasing NcrPurch { get; set; } = null!;
}
