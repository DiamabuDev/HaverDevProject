using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaverDevProject.NewModels;

[Table("itemDefectVideo")]
public partial class ItemDefectVideo
{
    [Key]
    [Column("itemDefectVideoId")]
    public int ItemDefectVideoId { get; set; }

    [Column("itemDefectVideoLink")]
    [StringLength(100)]
    [Unicode(false)]
    public string ItemDefectVideoLink { get; set; } = null!;

    [Column("itemDefectId")]
    public int ItemDefectId { get; set; }

    [ForeignKey("ItemDefectId")]
    [InverseProperty("ItemDefectVideos")]
    public virtual ItemDefect ItemDefect { get; set; } = null!;
}
