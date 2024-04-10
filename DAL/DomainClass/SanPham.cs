using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("SanPham")]
public partial class SanPham
{
    [Key]
    [Column("MaSP")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaSp { get; set; } = null!;

    [StringLength(250)]
    public string? TenSanPham { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayNhap { get; set; }

    public int? SoLuong { get; set; }

    public double? Gia { get; set; }

    [StringLength(30)]
    public string? TrangThai { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaMau { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaSize { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaChatLieu { get; set; }

    [Column("MaTH")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MaTh { get; set; }

    [InverseProperty("MaSpNavigation")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    [ForeignKey("MaChatLieu")]
    [InverseProperty("SanPhams")]
    public virtual ChatLieu? MaChatLieuNavigation { get; set; }

    [ForeignKey("MaMau")]
    [InverseProperty("SanPhams")]
    public virtual MauSac? MaMauNavigation { get; set; }

    [ForeignKey("MaSize")]
    [InverseProperty("SanPhams")]
    public virtual Size? MaSizeNavigation { get; set; }

    [ForeignKey("MaTh")]
    [InverseProperty("SanPhams")]
    public virtual ThuongHieu? MaThNavigation { get; set; }
}
