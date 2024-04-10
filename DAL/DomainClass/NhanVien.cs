using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("NhanVien")]
public partial class NhanVien
{
    [Key]
    [Column("MaNV")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaNv { get; set; } = null!;

    [StringLength(50)]
    public string? TenNhanVien { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? SoDienThoai { get; set; }

    [StringLength(50)]
    public string? Email { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? GioiTinh { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgaySinh { get; set; }

    [StringLength(250)]
    public string? DiaChi { get; set; }

    [StringLength(30)]
    public string? MatKhau { get; set; }

    [StringLength(30)]
    public string? TrangThai { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaChucVu { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaCa { get; set; }

    [InverseProperty("MaNvNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    [ForeignKey("MaCa")]
    [InverseProperty("NhanViens")]
    public virtual CaLamViec? MaCaNavigation { get; set; }

    [ForeignKey("MaChucVu")]
    [InverseProperty("NhanViens")]
    public virtual ChucVu? MaChucVuNavigation { get; set; }

    [InverseProperty("MaNvNavigation")]
    public virtual ICollection<Thongke> Thongkes { get; set; } = new List<Thongke>();
}
