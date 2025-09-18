using System;
using System.Collections.Generic;

namespace QuanLyDatVeMayBay.Models.Entities;

public partial class KhachHangGiayTo
{
    public long Id { get; set; }

    public long IdKhachHang { get; set; }

    public string LoaiGiayTo { get; set; } = null!;

    public string SoGiayTo { get; set; } = null!;

    public string? QuocTich { get; set; }

    public DateOnly? NgayCap { get; set; }

    public DateOnly? NgayHetHan { get; set; }

    public string? NoiCap { get; set; }

    public virtual KhachHang IdKhachHangNavigation { get; set; } = null!;
}
