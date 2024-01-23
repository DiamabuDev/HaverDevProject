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

    [Required(ErrorMessage = "You must provide the Order Number.")]
    [Column("orderNumber")]
    public int OrderNumber { get; set; }

    [Required(ErrorMessage = "You must provide the Quantity Received.")]
    [Column("orderQuanReceived")]
    public int OrderQuanReceived { get; set; }

    [Required(ErrorMessage = "You must provide the Defective Quantity.")]
    [Column("orderQuanDefective")]
    public int OrderQuanDefective { get; set; }

    [Column("itemId")]
    public int ItemId { get; set; }

    [Column("ncrQAId")]
    public int NcrQaid { get; set; }

    [Required(ErrorMessage = "You must provide an Item.")]
    [ForeignKey("ItemId")]
    [InverseProperty("OrderDetails")]
    public virtual Item Item { get; set; }

    [Required(ErrorMessage = "You must provide the Disposition Type.")]
    [ForeignKey("NcrQaid")]
    [InverseProperty("OrderDetails")]
    public virtual NcrQa NcrQa { get; set; }
}
