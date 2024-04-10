using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("Coupon")]
public partial class Coupon
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaCoupon { get; set; } = null!;

    [StringLength(50)]
    public string? TenCoupon { get; set; }

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
}
