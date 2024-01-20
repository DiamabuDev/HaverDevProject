using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.NewModels;

[Table("supplier")]
public partial class Supplier
{
    [Key]
    [Column("supplierId")]
    public int SupplierId { get; set; }

    [Column("supplierCode")]
    [StringLength(45)]
    [Unicode(false)]
    public string SupplierCode { get; set; } = null!;

    [Column("supplierName")]
    [StringLength(45)]
    [Unicode(false)]
    public string SupplierName { get; set; } = null!;

    [Column("supplierEmail")]
    [StringLength(45)]
    [Unicode(false)]
    public string? SupplierEmail { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
