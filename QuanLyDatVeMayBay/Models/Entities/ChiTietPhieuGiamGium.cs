using System;
using System.Collections.Generic;

namespace QuanLyDatVeMayBay.Models.Entities;

public partial class ChiTietPhieuGiamGium
{
    public int Id { get; set; }

    public string MaGiamGia { get; set; } = null!;

    public long IdTaiKhoan { get; set; }

    public DateOnly NgaySuDung { get; set; }

    public virtual TaiKhoan IdTaiKhoanNavigation { get; set; } = null!;

    public virtual PhieuGiamGium MaGiamGiaNavigation { get; set; } = null!;
}
