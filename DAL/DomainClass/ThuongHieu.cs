using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("ThuongHieu")]
public partial class ThuongHieu
{
    [Key]
    [Column("MaTH")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaTh { get; set; } = null!;

    [StringLength(50)]
    public string? TenThuongHieu { get; set; }

    [StringLength(30)]
    public string? TrangThai { get; set; }

    [InverseProperty("MaThNavigation")]
    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
