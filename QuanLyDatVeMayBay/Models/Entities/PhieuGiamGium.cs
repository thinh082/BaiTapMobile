using System;
using System.Collections.Generic;

namespace QuanLyDatVeMayBay.Models.Entities;

public partial class PhieuGiamGium
{
    public long Id { get; set; }

    public string MaGiamGia { get; set; } = null!;

    public decimal GiaTriGiam { get; set; }

    public DateOnly NgayKetThuc { get; set; }

    public string? LoaiPhieuGiamGia { get; set; }

    public string? DieuKienGiamGia { get; set; }

    public string? NoiDung { get; set; }

    public virtual ICollection<ChiTietPhieuGiamGium> ChiTietPhieuGiamGia { get; set; } = new List<ChiTietPhieuGiamGium>();
}
