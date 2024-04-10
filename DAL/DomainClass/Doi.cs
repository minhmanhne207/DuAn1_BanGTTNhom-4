using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("Doi")]
public partial class Doi
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaDoi { get; set; } = null!;

    [StringLength(50)]
    public string? TrangThai { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayDoi { get; set; }

    [StringLength(250)]
    public string? LyDo { get; set; }

    [StringLength(100)]
    public string? DoiSangSp { get; set; }

    [Column("MaHDCT")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MaHdct { get; set; }

    [ForeignKey("MaHdct")]
    [InverseProperty("Dois")]
    public virtual HoaDonChiTiet? MaHdctNavigation { get; set; }
}
