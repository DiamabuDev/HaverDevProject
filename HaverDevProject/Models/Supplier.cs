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

    [Required]
    [Display(Name = "Code")]
    [Column("supplierCode")]
    [StringLength(45, ErrorMessage = "Supplier Code cannot be more than 45 characters long.")]
    [Unicode(false)]
    public string SupplierCode { get; set; }

    [Required]
    [Display(Name = "Name")]
    [Column("supplierName")]
    [StringLength(45, ErrorMessage = "Supplier Name cannot be more than 45 characters long.")]
    [Unicode(false)]
    public string SupplierName { get; set; }

    [Column("supplierEmail")]
    [Display(Name = "Email")]
    [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Invalid email format.")]
    [DataType(DataType.EmailAddress)]
    [StringLength(45, ErrorMessage = "Supplier Name cannot be more than 45 characters long.")]
    [Unicode(false)]
    public string SupplierEmail { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<Item> Items { get; set; } = new List<Item>();
}
