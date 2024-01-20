using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.NewModels;

[Table("item")]
public partial class Item
{
    [Key]
    [Column("itemId")]
    public int ItemId { get; set; }

    [Column("itemNumber")]
    public int ItemNumber { get; set; }

    [Column("itemName")]
    [StringLength(45)]
    [Unicode(false)]
    public string ItemName { get; set; } = null!;

    [Column("supplierId")]
    public int SupplierId { get; set; }

    [InverseProperty("Item")]
    public virtual ICollection<ItemDefect> ItemDefects { get; set; } = new List<ItemDefect>();

    [InverseProperty("Item")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    [ForeignKey("SupplierId")]
    [InverseProperty("Items")]
    public virtual Supplier Supplier { get; set; } = null!;
}
