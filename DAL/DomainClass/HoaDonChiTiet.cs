using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("HoaDonChiTiet")]
public partial class HoaDonChiTiet
{
    [Key]
    [Column("MaHDCT")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaHdct { get; set; } = null!;

    public int? SoLuong { get; set; }

    public double? DonGia { get; set; }

    public double? TongTienSauVoucher { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaSp { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaVoucher { get; set; }

    [Column("MaHD")]
    [StringLength(10)]
    [Unicode(false)]
    public string? MaHd { get; set; }

    [InverseProperty("MaHdctNavigation")]
    public virtual ICollection<Doi> Dois { get; set; } = new List<Doi>();

    [ForeignKey("MaHd")]
    [InverseProperty("HoaDonChiTiets")]
    public virtual HoaDon? MaHdNavigation { get; set; }

    [ForeignKey("MaSp")]
    [InverseProperty("HoaDonChiTiets")]
    public virtual SanPham? MaSpNavigation { get; set; }

    [ForeignKey("MaVoucher")]
    [InverseProperty("HoaDonChiTiets")]
    public virtual Voucher? MaVoucherNavigation { get; set; }
}
