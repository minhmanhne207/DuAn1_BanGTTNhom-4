using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("Tra")]
public partial class Tra
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaTra { get; set; } = null!;

    [StringLength(10)]
    public string? TrangThai { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayDoi { get; set; }

    [StringLength(250)]
    public string? LyDo { get; set; }

    [Column("MaHDCT")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MaHdct { get; set; }

    [ForeignKey("MaHdct")]
    [InverseProperty("Tras")]
    public virtual HoaDonChiTiet? MaHdctNavigation { get; set; }
}
