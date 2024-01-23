using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("supplier")]
public partial class Supplier
{
    [Key]
    [Column("supplierId")]
    public int SupplierId { get; set; }

    [Required(ErrorMessage = "You must provide the Supplier Code.")]
    [Column("supplierCode")]
    [StringLength(45, ErrorMessage = "The Supplier Code cannot be more than 45 characters.")]
    [Unicode(false)]
    public string SupplierCode { get; set; }

    [Required(ErrorMessage = "You must provide the Supplier Name.")]
    [Column("supplierName")]
    [StringLength(45, ErrorMessage = "The Supplier Name cannot be more than 45 characters.")]
    [Unicode(false)]
    public string SupplierName { get; set; }

    [Column("supplierEmail")]
    [StringLength(45, ErrorMessage = "The Supplier Email cannot be more than 45 characters.")]
    [Unicode(false)]
    public string SupplierEmail { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
