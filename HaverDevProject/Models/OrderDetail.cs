using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("orderDetail")]
public partial class OrderDetail
{
    [Key]
    [Column("orderId")]
    public int OrderId { get; set; }

    [Column("orderNumber")]
    public int OrderNumber { get; set; }

    [Column("orderQuanReceived")]
    public int OrderQuanReceived { get; set; }

    [Column("orderQuanDefective")]
    public int OrderQuanDefective { get; set; }

    [Column("itemId")]
    public int ItemId { get; set; }

    [Column("ncrQAId")]
    public int NcrQaid { get; set; }

    [ForeignKey("ItemId")]
    [InverseProperty("OrderDetails")]
    public virtual Item Item { get; set; }

    [ForeignKey("NcrQaid")]
    [InverseProperty("OrderDetails")]
    public virtual NcrQa NcrQa { get; set; }
}
