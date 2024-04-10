using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("Voucher")]
public partial class Voucher
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaVoucher { get; set; } = null!;

    [StringLength(50)]
    public string? TenVoucher { get; set; }

    public double? GiaTri { get; set; }

    [StringLength(250)]
    public string? MoTa { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? DieuKien { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayBatDau { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayKetThuc { get; set; }

    [InverseProperty("MaVoucherNavigation")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();
}
