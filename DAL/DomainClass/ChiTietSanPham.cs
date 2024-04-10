using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("ChiTietSanPham")]
public partial class ChiTietSanPham
{
    [Key]
    [Column("MASPCT")]
    [StringLength(10)]
    [Unicode(false)]
    public string Maspct { get; set; } = null!;

    public int? SoLuong { get; set; }

    [Column("MaSP")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MaSp { get; set; }

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

    [ForeignKey("MaChatLieu")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual ChatLieu? MaChatLieuNavigation { get; set; }

    [ForeignKey("MaMau")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual MauSac? MaMauNavigation { get; set; }

    [ForeignKey("MaSize")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual Size? MaSizeNavigation { get; set; }

    [ForeignKey("MaSp")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual SanPham? MaSpNavigation { get; set; }

    [ForeignKey("MaTh")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual ThuongHieu? MaThNavigation { get; set; }
}
