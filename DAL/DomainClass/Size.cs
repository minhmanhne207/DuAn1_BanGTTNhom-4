using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("Size")]
public partial class Size
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaSize { get; set; } = null!;

    [StringLength(50)]
    public string? KichThuoc { get; set; }

    [StringLength(30)]
    public string? TrangThai { get; set; }

    [InverseProperty("MaSizeNavigation")]
    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
