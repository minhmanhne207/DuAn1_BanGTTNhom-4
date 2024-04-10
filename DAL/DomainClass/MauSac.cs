using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("MauSac")]
public partial class MauSac
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaMau { get; set; } = null!;

    [StringLength(50)]
    public string? TenMau { get; set; }

    [StringLength(30)]
    public string? TrangThai { get; set; }

    [InverseProperty("MaMauNavigation")]
    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
