using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.NewModels;

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

    [Column("drawingUserId")]
    public int? DrawingUserId { get; set; }

    [Column("ncrEngId")]
    public int NcrEngId { get; set; }

    [ForeignKey("NcrEngId")]
    [InverseProperty("Drawings")]
    public virtual NcrEng NcrEng { get; set; } = null!;
}
