using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.Models;

[Table("drawing")]
public partial class Drawing
{
    [Key]
    [Column("drawingId")]
    public int DrawingId { get; set; }

    [Column("drawingOriginalRevNumber")]
    public int DrawingOriginalRevNumber { get; set; }

    [Column("drawingUpdatedRevNumber")]
    public int DrawingUpdatedRevNumber { get; set; }

    [Column("drawingRevDate", TypeName = "date")]
    public DateTime DrawingRevDate { get; set; }

    [Display(Name = "Drawing User ID")]
    [Column("drawingUserId")]
    public int DrawingUserId { get; set; }

    [Display(Name = "NCR Engineer ID")]
    [Column("ncrEngId")]
    public int NcrEngId { get; set; }

    [Display(Name = "NCR Engineer ID")]
    [ForeignKey("NcrEngId")]
    [InverseProperty("Drawings")]
    public virtual NcrEng NcrEng { get; set; }
}
